using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Threading;
using Npgsql;


namespace DAL
{
    public class SessionManager
    {
        #region dbaccess
        private static NpgsqlConnection _conn;
        private static string _server;
        private static int _port;
        private static string _database;
        private static string _mdp;
        #endregion

        #region log
        private static bool _logRequests;
        private static string _pathLog;
        static DateTime _d0, _d1;
        #endregion


        public static void SetSessionContext(string server, int port, string database, string mdp, bool logRequests, string pathLog)
        {
            _server = server;
            _port = port;
            _database = database;
            _mdp = mdp;
            _logRequests = logRequests;
            _pathLog = pathLog;

            _mainThread = new Thread(ThreadedMainJob);
            _mainThread.Start();
        }
        public static List<object[]> ExecuteQuery(string query)
        {
            List<object[]> lRes = null;
            var key = RegisterQuery(query);
            if (key > -1)
            {
                while (!HasResult(key, out lRes))
                    Thread.Sleep(15);
            }
            return lRes;
        }

        #region Connection State
        private static DateTime _dateConnectionOpening = DateTime.MinValue;
        private static void OpenConn()
        {
            if (_conn == null)
                _conn = new NpgsqlConnection("Server=" + _server + ";Port= " + _port + ";User Id=postgres;" + "Password=" + _mdp + ";Database=" + _database);
            
            if (_conn != null)
            {                
                _conn.Open();
                _dateConnectionOpening = DateTime.Now;
            }

            System.Console.WriteLine("Connexion : " + _conn);
        }
        private static void CloseConn()
        {
            if (_conn != null)
            {
                try { _conn.Close(); }
                catch { }
                try { _conn.Dispose(); }
                catch { }
                _conn = null;
            }
        }
        private static bool CheckConnection()
        {
            if ((DateTime.Now - _dateConnectionOpening).TotalHours > 0.5)
            {
                try
                {
                    CloseConn();
                    OpenConn();
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        private static bool _endMainThread;
        private static long _lastQuerryKey;
        private static readonly object LockerDicoWaitingQueries = new object();
        private static readonly List<long> WaitingKeys = new List<long>();
        private static readonly Dictionary<long, string> DicoWaitingQueries = new Dictionary<long, string>();
        private static readonly object LockerDicoWaitingResults = new object();
        private static readonly Dictionary<long, List<object[]>> DicoWaitingResults = new Dictionary<long, List<object[]>>();
        private static long RegisterQuery(string sql)
        {
            if (!string.IsNullOrEmpty(sql))
            {
                lock (LockerDicoWaitingQueries)
                {
                    _lastQuerryKey++;
                    if (!DicoWaitingQueries.ContainsKey(_lastQuerryKey))
                    {
                        WaitingKeys.Add(_lastQuerryKey);
                        DicoWaitingQueries.Add(_lastQuerryKey, sql);
                    }
                    return _lastQuerryKey;
                }
            }
            return -1;
        }

        private static bool HasResult(long key, out List<object[]> result)
        {
            lock (LockerDicoWaitingResults)
            {
                if (DicoWaitingResults.ContainsKey(key))
                {
                    result = DicoWaitingResults[key];
                    DicoWaitingResults.Remove(key);
                    return true;
                }
                result = null;
                return false;
            }
        }

        private static Thread _mainThread;
        private static void ThreadedMainJob()
        {
            while (!_endMainThread)
            {
                if (CheckConnection())
                {
                    long key = -1;
                    string query = null;

                    lock (LockerDicoWaitingQueries)
                    {
                        if (WaitingKeys.Count > 0)
                        {
                            key = WaitingKeys[0];
                        }
                        if (DicoWaitingQueries.ContainsKey(key))
                        {
                            query = DicoWaitingQueries[key];
                            DicoWaitingQueries.Remove(key);
                            WaitingKeys.Remove(key);
                        }
                    }

                    if (!string.IsNullOrEmpty(query))
                    {
                        var lRes = PerformSqlQuery(query);
                        lock (LockerDicoWaitingResults)
                        {
                            if (!DicoWaitingResults.ContainsKey(key))
                                DicoWaitingResults.Add(key, lRes);
                        }
                    }
                    Thread.Sleep(0);
                }
                else
                {
                    _endMainThread = true;
                }
            }
            CloseConn();
        }
        private static List<object[]> PerformSqlQuery(string sql)
        {
            var l = new List<object[]>();

            if (!string.IsNullOrEmpty(sql))
                try
                {
                    if (_logRequests)
                        _d0 = DateTime.Now;

                    var command = _conn.CreateCommand();
                    command.CommandTimeout = 3600;
                    command.CommandText = sql;

                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var o = new object[dr.FieldCount];
                            for (var i = 0; i < dr.FieldCount; i++)
                                o[i] = dr[i];
                            l.Add(o);
                        }
                        dr.Close();
                    }
                    command.Dispose();

                    if (_logRequests)
                    {
                        _d1 = DateTime.Now;
                        try
                        {
                            using (var w = new StreamWriter(_pathLog, true, Encoding.UTF8))
                            {
                                w.WriteLine("-----------------------------------------------------------------------------");
                                w.WriteLine(_d0.ToShortDateString() + " " + _d0.TimeOfDay);
                                w.WriteLine(sql);
                                w.WriteLine("{0} res. - {1} ms", l.Count, (_d1 - _d0).TotalMilliseconds);
                            }
                        }
                        catch { }
                    }
                }
                catch (Exception e)
                {
                    if (_logRequests)
                    {
                        try
                        {
                            using (var w = new StreamWriter(_pathLog, true, Encoding.UTF8))
                            {
                                w.WriteLine("-----------------------------------------------------------------------------");
                                w.WriteLine(_d0.ToShortDateString() + " " + _d0.TimeOfDay);
                                w.WriteLine(sql);
                                w.WriteLine(e.Message);
                                w.WriteLine(e.StackTrace);
                            }
                        }
                        catch { }
                    }
                    throw e;
                }
            else
                l = null;
            return l;

        }


        #region Notification
        private static NpgsqlConnection _connNotification;

        public static void SetSessionContextNotification()
        {
            _connNotification = new NpgsqlConnection(_conn.ConnectionString);
            //_server = server;
            //_port = port;
            //_database = database;
            //_mdp = mdp;
        }

        public static List<object[]> ExecuteQueryForNotification(string query)
        {
            try
            {
                if (_connNotification == null || _connNotification.State != ConnectionState.Open)
                    OpenConnNotification();

                //ListObject lstSelect = new ListObject();
                var l = new List<object[]>();
                var sql = query;

                //while (!IsSessionAccessible())
                //    Thread.Sleep(10);

                //setSessionNonAccessible();

                var command = new NpgsqlCommand(sql, _connNotification);
                var dr = command.ExecuteReader();

                while (dr.Read())
                {
                    var o = new object[dr.FieldCount];
                    for (var i = 0; i < dr.FieldCount; i++)
                    {
                        o[i] = dr[i];
                    }
                    l.Add(o);
                }

                dr.Close();
                command.Dispose();

                //setSessionAccessible();

                CloseConnNotification();
                return l;
            }
            catch
            {
                CloseConnNotification();
                //setSessionAccessible();
                return null;
            }
        }

        private static void OpenConnNotification()
        {
            try
            {
                if (_connNotification == null)
                    SetSessionContextNotification();
                if (_connNotification != null) _connNotification.Open();
            }
            catch
            {
            }
        }

        public static void CloseConnNotification()
        {
            try
            {
                _connNotification.Close();
            }
            catch
            {
            }
        }
        #endregion
    }
}
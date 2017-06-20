using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Projet
    {
        private int i_id_projet;
        private string w_name_projet;
        private string w_desc_projet;
        private DateTime d_date_creation;

        public Projet (int id_projet, string name_projet, string desc_projet, DateTime date_creation)
        {
            i_id_projet = id_projet;
            w_name_projet = name_projet;
            w_desc_projet = desc_projet;
            d_date_creation = date_creation;
        }

        public int getId()
        {
            return i_id_projet;
        }

        public string getName()
        {
            return w_name_projet;
        }

        public string getDesc()
        {
            return w_desc_projet;
        }

        public DateTime getDatecreation()
        {
            return d_date_creation;
        }
    }
}

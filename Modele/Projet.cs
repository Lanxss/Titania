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
        private DateTime d_date_modif;
        private List<string> lst_collab;

        public Projet (int id_projet, string name_projet, string desc_projet, DateTime date_creation, DateTime date_modif, List<string> _lst_collab) 
        {
            i_id_projet = id_projet;
            w_name_projet = name_projet;
            w_desc_projet = desc_projet;
            d_date_creation = date_creation;
            d_date_modif = date_modif;
            lst_collab = _lst_collab;
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

        public DateTime getDatemodif()
        {
            return d_date_modif;
        }

        public List<string> getCollab()
        {
            return lst_collab;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Hemsire
    {
        public int ID {get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Props
        public int PoliclinicID { get; set; }
        public Poliklinik Policlinic { get; set; }
    }
}

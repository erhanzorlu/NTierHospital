using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Poliklinik
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Navigation props

        public List<Hemsire> Nurses { get; set; }

        public List<Randevu> Appointments { get; set; }

        public List<Doktor> Doctors { get; set; }


    }
}

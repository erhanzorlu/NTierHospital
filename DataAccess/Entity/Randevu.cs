using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Randevu
    {
        public Randevu()
        {
            ApointmentDate = DateTime.Now;
        }
        public int ID { get; set; }

        public DateTime ApointmentDate { get; set; }

        //Navigation props

        public int PoliklinikID { get; set; }
        public int HastaID { get; set; }

    }
}

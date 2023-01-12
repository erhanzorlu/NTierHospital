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
            AppointmentDate = DateTime.Now;
        }
        public int ID { get; set; }

        public DateTime AppointmentDate { get; set; }
        //Navigation props

        public int PoliclinicID { get; set; }
        public int PatientID { get; set; }
        public Poliklinik Policlinic { get; set; }
        public Hasta Patient { get; set; }

    }
}

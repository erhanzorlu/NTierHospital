using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Hasta
    {
        public Hasta()
        {
            RegisterDate = DateTime.Now;
        }

        
        public int ID { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime RegisterDate { get; set; }
        

        //Navigation Props
        public List<Randevu> Appointments { get; set; }
    }
}

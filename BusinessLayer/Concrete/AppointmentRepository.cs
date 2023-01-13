using BusinessLayer.Abstract;
using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AppointmentRepository:IRepository<Randevu>
    {
        HospitalDbContext db = new HospitalDbContext();
        public string Create(Randevu entity)
        {
            try
            {
                db.Appointments.Add(entity);
                db.SaveChanges();
                return "Kayıt oluşturuldu";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Delete(int id)
        {
            try
            {
                db.Appointments.Remove(GetById(id));
                db.SaveChanges();
                return "Silme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Randevu> GetAll()
        {
            return db.Appointments.ToList();
        }

        public Randevu GetById(int id)
        {

            return db.Appointments.Find(id);



        }

        public string Update(Randevu entity)
        {
            try
            {
                db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return "Güncellme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}

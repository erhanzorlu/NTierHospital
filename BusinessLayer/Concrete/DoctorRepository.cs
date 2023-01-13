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
    public class DoctorRepository : IRepository<Doktor>
    {
        HospitalDbContext db=new HospitalDbContext();
        public string Create(Doktor entity)
        {
            try
            {
                db.Doctors.Add(entity);
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
                db.Doctors.Remove(GetById(id));
                db.SaveChanges();
                return "Silme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Doktor> GetAll()
        {
            return db.Doctors.ToList();
        }

        public Doktor GetById(int id)
        {
            
                return db.Doctors.Find(id);
            
            
           
        }

        public string Update(Doktor entity)
        {
            try
            {
                db.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
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

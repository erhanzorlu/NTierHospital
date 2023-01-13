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
    public class PatientRepository:IRepository<Hasta>
    {
        HospitalDbContext db = new HospitalDbContext();
        public string Create(Hasta entity)
        {
            try
            {
                db.Patients.Add(entity);
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
                db.Patients.Remove(GetById(id));
                db.SaveChanges();
                return "Silme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Hasta> GetAll()
        {
            return db.Patients.ToList();
        }

        public Hasta GetById(int id)
        {

            return db.Patients.Find(id);



        }

        public string Update(Hasta entity)
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

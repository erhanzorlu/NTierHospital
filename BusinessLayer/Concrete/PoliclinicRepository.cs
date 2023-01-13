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
    public class PoliclinicRepository:IRepository<Poliklinik>
    {
        HospitalDbContext db = new HospitalDbContext();
        public string Create(Poliklinik entity)
        {
            try
            {
                db.Policlinic.Add(entity);
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
                db.Policlinic.Remove(GetById(id));
                db.SaveChanges();
                return "Silme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Poliklinik> GetAll()
        {
            return db.Policlinic.ToList();
        }

        public Poliklinik GetById(int id)
        {

            return db.Policlinic.Find(id);



        }

        public string Update(Poliklinik entity)
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

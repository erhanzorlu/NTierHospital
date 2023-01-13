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
    public class NurseRepository:IRepository<Hemsire>
    {
        HospitalDbContext db = new HospitalDbContext();
        public string Create(Hemsire entity)
        {
            try
            {
                db.Nurses.Add(entity);
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
                db.Nurses.Remove(GetById(id));
                db.SaveChanges();
                return "Silme başarılı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Hemsire> GetAll()
        {
            return db.Nurses.ToList();
        }

        public Hemsire GetById(int id)
        {

            return db.Nurses.Find(id);



        }

        public string Update(Hemsire entity)
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

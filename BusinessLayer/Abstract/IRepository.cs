using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRepository<T>
    {
        public string Create(T entity);
        public string Update(T entity);
        public string Delete(int id);
        public T GetById(int id);
        public List<T> GetAll();

    }
}

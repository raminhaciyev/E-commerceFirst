using DataAccessLayer.Abstact;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            var x = new Context();
            x.Remove(t);
            x.SaveChanges();
        }

        public List<T> GetAllList()
        {
            var x = new Context();
            return x.Set<T>().ToList();   
        }

        public T GetById(int id)
        {
            var x = new Context();
            return x.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            var x = new Context();
            x.Add(t);
            x.SaveChanges();
        }

        public void Update(T t)
        {
            var x = new Context();
            x.Update(t);
            x.SaveChanges();
        }
    }
}

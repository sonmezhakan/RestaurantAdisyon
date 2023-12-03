using RA.BusinessLogic.Core.Abstract;
using RA.DataAccess.Concrete;
using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Core.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : EntityAbstract
    {
        RestaurantAdisyonContext context = new RestaurantAdisyonContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var entityUpdate = context.Set<T>().Find(entity.ID);
            context.Entry(entityUpdate).CurrentValues.SetValues(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entityDelete = context.Set<T>().Find(id);
            context.Set<T>().Remove(entityDelete);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}

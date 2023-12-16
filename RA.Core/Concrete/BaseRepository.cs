using Microsoft.EntityFrameworkCore;
using RA.Core.Abstract;
using RA.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RA.Core.Concrete
{
    public class BaseRepository<T, TContext> : IBaseRepository<T>
    where T: IEntity,new()
    where TContext : DbContext,new()
    {
        public void Add(T entity)
        {
            using(TContext context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using(TContext context = new TContext())
            {
                var entityUpdate = context.Set<T>().Find(entity.ID);
                context.Entry(entityUpdate).CurrentValues.SetValues(entity);
                context.SaveChanges();
            }
            
        }


        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }

        public void Delete(T entity)
        {
           using(TContext context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}

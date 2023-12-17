using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RA.DataAccess.Repositories.Concretes
{
    public class BaseRepository<T,TContext> : IRepository<T> where T : class, IEntity
        where TContext :  DbContext, new()
    {
        /*private readonly RestaurantAdisyonContext _context;

        public BaseRepository(RestaurantAdisyonContext context)
        {
            _context = context;
        }*/

        public void Add(T entity)
        {
            using (TContext context = new TContext())
            {
                entity.CreatedDate = DateTime.Now;
                context.Set<T>().Add(entity);
                context.SaveChanges();
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

        public T FirstOrDefault(Expression<Func<T, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }

        public bool FirstOrDefaultBool(Expression<Func<T, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().Any(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Update(T entity)
        {
            using(TContext context = new TContext())
            {
                entity.UpdatedDate = DateTime.Now;
                T original = context.Set<T>().Find(entity.ID);
                context.Entry(original).CurrentValues.SetValues(entity);
                context.SaveChanges();
            }
        }
    }
}

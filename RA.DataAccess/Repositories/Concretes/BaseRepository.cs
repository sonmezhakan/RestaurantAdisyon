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
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {

        private readonly RestaurantAdisyonContext _context;

        public BaseRepository(RestaurantAdisyonContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().FirstOrDefault(filter);
        }

        public bool FirstOrDefaultBool(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Any(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            T original = _context.Set<T>().Find(entity.ID);
            _context.Entry(original).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}

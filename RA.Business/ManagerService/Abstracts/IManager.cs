using RA.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IManager<T> where T : class, IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T FirstOrDefault(Expression<Func<T, bool>> filter);
        bool FirstOrDefaultBool(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

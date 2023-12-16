using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.ManagerService.Concretes
{
    public class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        private readonly IRepository<T> _repository;

        public BaseManager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return _repository.FirstOrDefault(filter);
        }

        public bool FirstOrDefaultBool(Expression<Func<T, bool>> filter)
        {
            return _repository.FirstOrDefaultBool(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _repository.GetAll(filter);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}

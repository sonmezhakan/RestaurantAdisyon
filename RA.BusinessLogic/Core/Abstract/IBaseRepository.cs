using RA.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Core.Abstract
{
    public interface IBaseRepository<T> where T: EntityAbstract
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public List<T> GetAll();
        public T GetById(int id);
    }
}

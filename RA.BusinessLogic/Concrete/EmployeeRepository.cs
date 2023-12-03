using RA.BusinessLogic.Abstract;
using RA.BusinessLogic.Core.Abstract;
using RA.BusinessLogic.Core.Concrete;
using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Concrete
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository<Employee>
    {
        BaseRepository<Employee> repository = new BaseRepository<Employee>();

        public bool GetByEmail(string email)
        {
            return repository.GetAll().Any(x => x.Email == email);
        }

        public Employee GetByFirstAndLastName(string firstName, string lastName)
        {
            return repository.GetAll().FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }

        public List<Employee> GetByFirstName(string firstName)
        {
            return repository.GetAll().Where(x=>x.FirstName == firstName).ToList();
        }
    }
}

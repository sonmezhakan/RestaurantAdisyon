using RA.Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.BusinessLogic.Abstract
{
    public interface IEmployeeRepository<Employe>
    {
        public void Add(Employee employee);
        public void Update(Employee employee);
        public void Delete(int id);
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public Employee GetByFirstAndLastName(string firstName,string lastName);
        public bool GetByEmail(string email);
        public List<Employe> GetByFirstName(string firstName);
    }
}

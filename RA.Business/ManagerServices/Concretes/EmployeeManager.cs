using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.DataAccess.Repositories.Concretes;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            if (!_employeeDal.FirstOrDefaultBool(x=>x.Email == employee.Email))
            {
                _employeeDal.Add(employee);
            }
        }
        public void Update(Employee employee)
        {
            if (_employeeDal.FirstOrDefaultBool(x=>x.ID == employee.ID))
            {
                _employeeDal.Update(employee);
            }
        }
        public void Delete(int id)
        {
            var getEmployee = _employeeDal.FirstOrDefault(x=>x.ID == id);
            if (getEmployee != null)
            {
                _employeeDal.Delete(getEmployee);
            }
        }

        public List<Employee> GetByAllComboBox()
        {
            return _employeeDal.GetAll().Select(x => new Employee
            {
                ID = x.ID,
                FirstName = x.FirstName
            }).ToList();
        }

        public bool GetByEmail(string email)
        {
            return _employeeDal.FirstOrDefaultBool(x => x.Email == email);
        }

        public Employee GetByFirstAndLastName(string firstName, string lastName)
        {
            return _employeeDal.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }

        public List<Employee> GetByFirstName(string firstName)
        {
            return _employeeDal.GetAll().Select(x => new Employee
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).Where(x => x.FirstName == firstName).ToList();
        }

        public Employee GetById(int id)
        {
            return _employeeDal.FirstOrDefault(x => x.ID == id);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }
    }
}

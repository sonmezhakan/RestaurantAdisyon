using RA.Business.ManagerService.Abstracts;
using RA.DataAccess.Repositories.Abstracts;
using RA.DataAccess.Repositories.Concretes;
using RA.Entities.Entity;

namespace RA.Business.ManagerService.Concretes
{
    public class EmployeeManager : BaseManager<Employee>,IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository):base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void Add(Employee employee)
        {
            if (!_employeeRepository.FirstOrDefaultBool(x=>x.Email == employee.Email))
            {
                _employeeRepository.Add(employee);
            }
        }
        public void Update(Employee employee)
        {
            if (_employeeRepository.FirstOrDefaultBool(x=>x.ID == employee.ID))
            {
                _employeeRepository.Update(employee);
            }
        }
        public void Delete(int id)
        {
            var getEmployee = _employeeRepository.FirstOrDefault(x=>x.ID == id);
            if (getEmployee != null)
            {
                _employeeRepository.Delete(getEmployee);
            }
        }

        public List<Employee> GetByAllComboBox()
        {
            return _employeeRepository.GetAll().Select(x => new Employee
            {
                ID = x.ID,
                FirstName = x.FirstName
            }).ToList();
        }

        public bool GetByEmail(string email)
        {
            return _employeeRepository.FirstOrDefaultBool(x => x.Email == email);
        }

        public Employee GetByFirstAndLastName(string firstName, string lastName)
        {
            return _employeeRepository.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }

        public List<Employee> GetByFirstName(string firstName)
        {
            return _employeeRepository.GetAll().Select(x => new Employee
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).Where(x => x.FirstName == firstName).ToList();
        }

        public Employee GetById(int id)
        {
            return _employeeRepository.FirstOrDefault(x => x.ID == id);
        }
    }
}

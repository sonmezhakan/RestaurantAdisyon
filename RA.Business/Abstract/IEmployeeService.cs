using RA.Entities.Entity;

namespace RA.Business.Abstract
{
    public interface IEmployeeService<Employe>
    {
        public void Add(Employee employee);
        public void Update(Employee employee);
        public void Delete(int id);
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public Employee GetByFirstAndLastName(string firstName, string lastName);
        public bool GetByEmail(string email);
        public List<Employe> GetByFirstName(string firstName);
    }
}

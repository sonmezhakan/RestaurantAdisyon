using RA.Entities.Entity;

namespace RA.Business.ManagerService.Abstracts
{
    public interface IEmployeeManager:IManager<Employee>
    {
        public bool GetByEmail(string email);
        public List<Employee> GetByAllComboBox();
        public List<Employee> GetByFirstName(string firstName);
        public Employee GetByFirstAndLastName(string firstName, string lastName);
        public Employee GetById(int id);
        /*public void Add(Employee employee);
        public void Update(Employee employee);
        public void Delete(int id);
        public List<Employee> GetAll();
        public Employee GetById(int id);
        public Employee GetByFirstAndLastName(string firstName, string lastName);
        public bool GetByEmail(string email);
        public List<Employee> GetByAllComboBox();
        public List<Employee> GetByFirstName(string firstName);*/
    }
}

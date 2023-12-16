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

    }
}

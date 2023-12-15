﻿using RA.Business.Abstract;
using RA.Core.Concrete;
using RA.Entities.Entity;

namespace RA.Business.Concrete
{
    public class EmployeeManager : BaseRepository<Employee>, IEmployeeService<Employee>
    {
        BaseRepository<Employee> repository = new BaseRepository<Employee>();

        public List<Employee> GetByAllComboBox()
        {
            return repository.GetAll().Select(x => new Employee
            {
                ID = x.ID,
                FirstName = x.FirstName
            }).ToList();
        }

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
            return repository.GetAll().Select(x=>new Employee
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).Where(x => x.FirstName == firstName).ToList();
        }
    }
}
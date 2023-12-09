using RA.Entities.Abstract;

namespace RA.Entities.Entity
{
    public class Employee : EntityAbstract
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public List<AppUser> User { get; set; }
    }
}

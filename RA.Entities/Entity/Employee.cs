﻿using RA.Entities.Interfaces;

namespace RA.Entities.Entity
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public virtual AppUser User { get; set; }
    }
}

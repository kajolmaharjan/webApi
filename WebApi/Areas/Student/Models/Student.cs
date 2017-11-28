using System;
using System.Collections.Generic;

namespace WebApi.Areas.Student.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }
        public int PhoneId { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int UserId { get; set; }

        public Address Address { get; set; }
        public Phone Phone { get; set; }
    }
}

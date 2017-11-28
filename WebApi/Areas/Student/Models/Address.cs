using System;
using System.Collections.Generic;

namespace WebApi.Areas.Student.Models
{
    public partial class Address
    {
        public Address()
        {
            Student = new HashSet<Student>();
        }

        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}

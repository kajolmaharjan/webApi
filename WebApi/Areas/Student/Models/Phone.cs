using System;
using System.Collections.Generic;

namespace WebApi.Areas.Student.Models
{
    public partial class Phone
    {
        public Phone()
        {
            Student = new HashSet<Student>();
        }

        public int PhoneId { get; set; }
        public string MobileNumber { get; set; }
        public string Landline { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}

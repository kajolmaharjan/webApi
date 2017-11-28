using System;
using System.Collections.Generic;

namespace WebApi.Areas.Account.Models
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public bool? IsRegisterd { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.demo.Core.Model
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string RegistrationNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
    }
}

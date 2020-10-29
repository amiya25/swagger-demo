using swagger.demo.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.demo.Data
{
    public interface IStudentDataService
    {
        List<StudentModel> GetAllStudents();

    }
}

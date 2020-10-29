using swagger.demo.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.demo.Core.BusinessService
{
    public interface IStudentBusinessService
    {
        List<StudentModel> GetAllStudents();
        StudentModel GetStudentById(int id);
    }
}

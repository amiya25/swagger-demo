using swagger.demo.Core.Model;
using swagger.demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.demo.Core.BusinessService
{
    public class StudentBusinessService : IStudentBusinessService
    {
        private IStudentDataService _studentDataService;
        public StudentBusinessService(IStudentDataService studentDataService)
        {
            _studentDataService = studentDataService;
        }

        public List<StudentModel> GetAllStudents()
        {
            return _studentDataService.GetAllStudents();
        }

        public StudentModel GetStudentById(int id)
        {
            return  _studentDataService.GetAllStudents()
                   .Where(x=> x.StudentId == id).FirstOrDefault();
        }

    }
}

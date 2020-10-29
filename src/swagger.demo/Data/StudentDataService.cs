using swagger.demo.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger.demo.Data
{
    public class StudentDataService : IStudentDataService
    {

        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> studentList = new List<StudentModel>();

            var student1 = new StudentModel { 
                StudentId = 1 ,
                RegistrationNo = "00001",
                FirstName = "Audrey", 
                LastName  = "Spencerc" ,
                MobileNo = "0112223335",
                Address = "No:20/1,Main Street,Colombo"
            };
            var student2 = new StudentModel
            {
                StudentId = 2,
                RegistrationNo = "00002",
                FirstName = "Jason",
                LastName = "Peterson",
                MobileNo = "0223345678",
                Address = "No:20/1,Second Street,Colombo"
            };

            studentList.Add(student1);
            studentList.Add(student2);

            return  studentList;
        }



    }
}

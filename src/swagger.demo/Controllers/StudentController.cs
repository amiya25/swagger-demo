using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using swagger.demo.Core.BusinessService;
using swagger.demo.Core.Model;

namespace swagger.demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentBusinessService _studentBusinessService;
        public StudentController(IStudentBusinessService studentBusinessService)
        {
            _studentBusinessService = studentBusinessService;
        }

        [Route("students")]
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var results = _studentBusinessService.GetAllStudents();

            if (!results.Any())
                return BadRequest();

            return Ok(results);
        }

        [Route("students/{id}")]
        [HttpGet]
        public IActionResult GetStudentById(int id)
        {
            var result = _studentBusinessService.GetStudentById(id);

            if (result != null && result.StudentId > 0)
                return Ok(result);

            return NoContent();
        }
    }
}

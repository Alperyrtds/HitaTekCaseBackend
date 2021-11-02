
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDal.Interfaces;
using StudentDal.Models;
using StudentDal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HitaTekCase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public IStudentRepository students = new StudentRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            return students.GetAllStudents();
        }
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = students.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}

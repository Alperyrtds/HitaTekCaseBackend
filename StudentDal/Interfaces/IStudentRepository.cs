using StudentDal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDal.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudent(int id);
    }
}

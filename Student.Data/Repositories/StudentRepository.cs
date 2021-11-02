using Student.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Name = "Alper",
                Surname = "Yurtdaş",
                GradeAverage = 2.98

            },
            new Student
            {
                Id = 2,
                Name = "Aybey",
                Surname = "Bayazıt",
                GradeAverage = 3.58

            },
            new Student
            {
                Id = 3,
                Name = "Fehmi",
                Surname = "Arslan",
                GradeAverage = 2.76

            },
            new Student
            {
                Id = 4,
                Name = "Deniz",
                Surname = "Akdağ",
                GradeAverage = 3.14

            },

        };
        public List<Student> GetAllStudents()
        {
            return students;

        }

        public Student GetStudent(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }
    }
}

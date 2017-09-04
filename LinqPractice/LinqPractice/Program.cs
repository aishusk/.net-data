using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Student.stud_list.AddRange(new List<Student> {
                new Student { ID = 111, name = "Tom", age = 10 },
                new Student { ID = 130,  name="Bandar1" , age = 22 },
                new Student { ID = 140,  name="Bandar2" , age = 23 },
                new Student { ID = 150,  name="Bandar3" , age = 24 },
                new Student { ID = 160,  name="Bandar4" , age = 2 },
                new Student { ID = 170,  name="Bandar5" , age = 222 }
                
            });

            Teacher t = new Teacher();
            Teacher.teacher_list.AddRange(new List<Teacher> {
                new Teacher { ID = 150, tName="teacher1" },
                new Teacher { ID = 130, tName="teacher2"},
                new Teacher { ID = 140, tName="teacher3"},
                new Teacher { ID = 111, tName="teacher4"},
                new Teacher { ID = 160, tName="teacher5" },
                new Teacher { ID = 170, tName="teacher6"}

            });
            s.GetStudentTeacher();
            //s.GetAllStudents();
            //s.getEldestStud();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Student
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public static List<Student> stud_list = new List<Student>();
        

        public Student(int ID,string name,int age)
        {
            this.ID = ID;
            this.name = name;
            this.age = age;
        }
        public Student()
        {

        }
         public void GetAllStudents()
        {
            var stud = (from ci in stud_list
                        select ci);
            foreach(var item in stud)
            Console.WriteLine(item);
        }
         public void getEldestStud()
        {
            var stud = (from ci in stud_list
                        orderby ci.age descending
                        select ci).FirstOrDefault();
            Console.WriteLine("The eldest student is \n");
            Console.WriteLine(stud);
        }

        public void GetStudentTeacher()
        {
            var st = (
                from teach in Teacher.teacher_list
                join stud in stud_list on teach.ID equals stud.ID into stud_teach
                from prod2 in stud_teach
                select new {Name = prod2.name, Age = prod2.age, TeacherName = teach.tName}
                );

            foreach (var item in st)
            {
                Console.WriteLine("Name: {0} Age: {1} TeacherName: {2}", item.Name, item.Age, item.TeacherName);
            }
            
        }
        public override string ToString()
        {
            return string.Format("Name : {0}  Age : {1} ",name,age);
        }



    }

    class Teacher
    {
        public string tName { get; set; }
        public int ID { get; set; }
        public static List<Teacher> teacher_list = new List<Teacher>();

        public Teacher()
        {

        }

        public override string ToString()
        {
            return string.Format("Name : {0}  ID : {1} ",tName, ID);
        }
    }

}

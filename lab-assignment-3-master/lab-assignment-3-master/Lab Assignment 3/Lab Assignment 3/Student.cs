using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3
{
    class Student
    {

            private string Name;
            private int Grade;
            private Instructor Teacher;

            public Student(string name, Instructor teacher)
            {
                this.Name = name;
                this.Teacher = teacher;
                this.Grade = 0;
            }

            public void SetGrade(int grade)
            {
                this.Grade = grade;
            }

            public string NameAndGrade()
            {
                return "Student: " + Name.PadRight(8) + " Grade: " + Grade;
            }

            public void PrintNameGradeAndTeacher()
            {
                System.Console.WriteLine(NameAndGrade() + " ".PadRight(3) + Teacher.NameAndCourse());
            }
        }
    }
}
}

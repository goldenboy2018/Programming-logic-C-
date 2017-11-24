using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instuctor instr1 = new Instructor();
            instr1.InstructorName = "John";
            instr1.CourseName = "English";
            instr1.printInstructor();

            Instuctor instr2 = new Instructor();
            instr2.InstructorName = "Mike";
            instr2.CourseName = "Math";
            instr2.printInstructor();

            Student stud1 = new student();
            stud1.NameStudent = "Jane";
            stud1.InstructorName = "John";
            stud1.printStudent();

            stud1.SetStudentGrade2("John", "95");

            Student stud2 = new student();
            stud2.NameStudent = "Joe";
            stud2.InstructorName = "John";
            stud2.printStudent();

            stud2.SetStudentGrade2("John", "85");

            Student stud3 = new student();
            stud3.NameStudent = "Melissa";
            stud3.InstructorName = "Mike";
            stud3.printStudent();

            stud3.SetStudentGrade2("Mike", "90");

            Student stud4 = new student();
            stud4.NameStudent = "Matt";
            stud4.InstructorName = "Mike";
            stud4.printStudent();

            stud4.SetStudentGrade2("Mike", "92");

            Console.ReadLine();







            {
       
        }



           

        }
    }
}

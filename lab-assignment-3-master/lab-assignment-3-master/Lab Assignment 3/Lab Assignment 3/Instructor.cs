using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3
{
    class Instructor
    {
    private static string instructorName;
    public string InstructorName;

    }

    get {return Instructor.instructorName;}
    set {Instructor.instructorName = value;}
    
    }

    private static string insstructorLastName;
    public string InstructorLastName

    {
    get { return Instructor.instructorLastName; }
    set { Instructor.instructorLastName = value; }

    }

private static string courseName;
public string CourseName;

{
    
    get {return Instructor.courseName;}
    set {Instructor.courseName = value;}
       
    }

    public void SetStudentGrade2(string name, string grade)
{
    name = InstructorName;
    Console.WriteLine("Instructor Name:" + name);
    Instructor.setStudentGrade = grade;
    Console.WriteLine("grade:" + grade);
    Console.WriteLine("...........");
}

private static string setStudentGrade;
public string SetStudentGrade;

{
get {return Instructor.setStudentGrade;}
set {Instructor.setStudentGrade = value;}

}
    public void printInstructor()
{
    Console.WriteLine("Instructor first Name:" + InstructorName);
    Console.WriteLine("Instructor last Name:" + instructorLastName);
    Console.WriteLine("Course Name:" + courseName);
    Console.WriteLine("...........");
}

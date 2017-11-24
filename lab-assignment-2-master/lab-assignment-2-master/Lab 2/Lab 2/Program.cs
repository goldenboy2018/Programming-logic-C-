using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class program
    {
        static void Main(string[] args)
        {
            Person P1 = newPerson();

            Console.WriteLine("Enter Person First Name");

            P1.FirstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Person Last Name");

            P1.LastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Person's Age");

            P1.Age = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Enter Person Spouse Name");

            P1.SpouseName = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" Enter Person Spouse Age");

            P1.SpouseAge = Convert.ToInt16(Console.ReadLine());

            Person P2 = newPerson();

            Console.WriteLine("Enter Person First Name");

            P2.FirstName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Person Last Name");

            P2.LastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Person's Age");

            P2.Age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Person Spouse Name");

            P2.SpouseName = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" Enter Person Spouse Age");

            P2.SpouseAge = Convert.ToInt16(Console.ReadLine());

            P1.GetFullName();

            P1.PrintNameAndAge();

            P1.GetFullNameSpouse();

            P2.GetFullName();

            P2.PrintNameAndAge();

            P2.GetFullNameSpouse();

            P1.AverageOfAge();

            P1.AverageOfAgeSpouse();

            P2.AverageOfAge();

            P2.AverageOfAgeSpouse();

            Console.ReadLine();










        }

       
        }
    }
}

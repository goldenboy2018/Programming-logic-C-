using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public string SpouseName;
        public int SpouseAge;
        public double SumOfAllAges;

        public string GetFullName()
        {
            Console.WrtieLine("\n Full Name: " + " " + SpouseName);

            return null;
        }


        public string GetFullNameSpouse()

        {
            Console.WriteLine("\n Spouse Full Name: " + " " + SpouseName);

            return null;
        }

            public void PrintNameAndAge()
        {
            Console.WriteLine("\n Age: " + Age);
        }
       
            public void AverageOfAge()
        {
            SumOfAllAges = SumOfAllAges + Age + SpouseAge;

            Console.WriteLine("\n Average of Age: " + SumOfAllAges / Age);
        }
            public void AverageOfAgeSpouse()
        {
            SumOfAllAges = SumOfAllAges + Age + SpouseAge;

            Console.WriteLine("\n Average of Suppose Age:" + SumOfAllAges / SpouseAge);
        }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            Console.WriteLine("First Name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Middel Initial:");
            middleInitial = Console.ReadLine();
            Console.WriteLine("Last Name:");
            lastName = Console.ReadLine();
            fullName = firstName + " " + middleInitial + "." + lastName;

            Console.WriteLine("Height Feet:");
            heightFeet = int.Parse(Console.ReadLine());
            Console.WriteLine("Height Inches:");
            heightInches = double.Parse(Console.ReadLine());
            Console.WriteLine("Total Height CM:");
            totalHeightCM = 2.54 * heightInches;

            Console.Write("Age:");
            age = int.Parse(Console.ReadLine());
            Console.Write("Citizen (true/false):");
            isCitizen = bool.Parse(Console.ReadLine());
            canVote = isCitizen && age >= 18;

            Console.WriteLine("Your name is " + fullName + ".");
            Console.WriteLine("Your height is " + totalHeightCM + ".");
            Console.WriteLine("Your voter eligibility is " + canVote + ".");

           
            
            

            

        }

        private static string Citizen(object p)
        {
            throw new NotImplementedException();
        }
    }
}

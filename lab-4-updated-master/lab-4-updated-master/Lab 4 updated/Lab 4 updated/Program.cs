using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_updated
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            const float matineeChild = 3.99;
            const float matineeAdult = 5.99;
            const float matineeSenior = 4.50;

            const float eveningChild = 6.99;
            const float eveningAdult = 10.99;
            const float eveningSenior = 8.50;

            const float concessionSmallSoda = 3.50;
            const float concessionLargeSoda = 5.99;
            const float concessionHotDog = 3.99;
            const float concessionPopcorn = 4.50;
            const float concessionCandy = 1.99;

            string firstName;
            string lastName;

            float addMantineeChild;
            float addMatineeAdult;
            float addMatineeSenior;

            float addEveningChild;
            float addEveningAdult;
            float addEveningSenior;

            float addSmallSoda;
            float addLargeSoda;
            float addHotDog;
            float addPopcorn;
            float addCandy;

            float TotalMatineeTickets;
            float TotalEveningTickets;
            float TotalConcessions;

            //Ticket asks

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.Write("How many Matinee Childrens' tickets are you buying? ");
            addMatineeChild = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many Matinee Adults' tickets are you buying?");
            addMatineeAdult = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many Matinee Seniors' tickets are you buying? ");
            addMatineeSenior = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many Evening Childrens' tickets are you buying? ");
            addEveningChild = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many Matinee Adults' tickets are you buying? ");
            addEveningAdult = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many Matinee Seniors' tickets are you buying? ");
            addEveningSenior = int.Parse(System.Console.ReadLine());

            //Food asks

            System.Console.Write("How many of the small sodas do you want? ");
            addSmallSoda = int.Parse(System.Console.ReadLine());

            System.Console.Write("Would you like any large sodas? ");
            addLargeSoda = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many hot dogs? ");
            addHotDog = int.Parse(System.Console.ReadLine());

            System.Console.Write("Would you like any popcorn with that? ");
            addPopcorn = int.Parse(System.Console.ReadLine());

            System.Console.Write("What about candy? ");
            addCandy = int.Parse(System.Console.ReadLine());

            //Adding everything

            totalMatineeTickets += addMatineeAdult += addMantineeChild += addMatineeSenior;

            totalEveningTickets += addEveningAdult += addEveningChild += addEveningSenior;

            totalConcessions += addHotDog += addLargeSoda += addSmallSoda += addPopcorn += addCandy;


            //If/else statements//

            bool addOn = addLargeSoda += addPopcorn;
            bool addPeople = addEveningAdult + addEveningChild + addEveningSenior > 3;
            bool addCandies = addCandies > 3;

            if (input.addOn)
            {
                System.Console.WriteLine("You have gotten a large soda & popcorn; this means you've been given a $2 discount!");
                int discount = addLargeSoda += addPopcorn += 2;
            }

            else (input.addOn)
            {
                System.Console.WriteLine("You did not get a discount, sorry!");
                int discount != addLargeSoda + addPopcorn;
            }

            if (input.addPeople())
            {
                System.Console.WriteLine("You've gotten a free bag of popcorn!");
                int addPeople() = addEveningAdult + addEveningChild + addEveningSenior > 3;
            }

            else (input.addPeople)
                    {
                System.Console.WriteLine("There are less than three people, so no free bag of popcorn.");
                int addPeople() != addEveningAdult + addEveningChild + addEveningSenior > 3;
            }

            if (addCandies > 3)
            {
                System.Console.WriteLine("Because you got 3 candies, you get one free!");
                addCandies = addCandy +> 3;
            }

            //Everything else//

               private static void EndProgram()
        {
            System.Console.WriteLine(" | Press any key to complete your order. | ");
            System.Console.Write(" ");
            System.Console.ReadKey();
        }
    }
}
       

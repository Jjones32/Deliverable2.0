using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Welcome to the buffet, the price per person is $9.99 and we charge $2.00 per coffee water is free.");
            Console.WriteLine("How many people are in your party? We do not accept parties over 6 people.");

            var people = Convert.ToInt32(Console.ReadLine());
            int coffee = 0;
            int water = 0;
            double bill = 0;

            if (people <= 6 && people >= 1)
            {

                Console.WriteLine(people + " guest(s), great right this way...");
                Console.WriteLine("What would each peron like to drink?");
                Console.WriteLine("We have two drinks to choose from. We have Coffee for $2.00 or Water for free.");
                Console.WriteLine("Alrighty then, what drink can i get the first person?");
                for (int i = 1; i <= people;)
                {
                    bill = bill + 9.99;
                    Console.WriteLine(" person " + i + " What would you like to drink");
                    string drink = Console.ReadLine();
                    if (drink == "coffee" || drink == "water")
                    {

                        if (drink == "coffee")
                        {
                            coffee = coffee + 1;
                            bill = bill + 2;
                            Console.WriteLine("Thank you " + i + " for ordering coffee ");
                        }

                        if (drink == "water")
                        {
                            water = water + 1;
                            Console.WriteLine("Thank you " + i + " for ordering water.");

                        }

                        i++;
                    }

                    else
                    {
                        Console.WriteLine("Sorry we don't have that beverage. Please choose either water or coffee. Thank you.");
                    }
                }
            }

            Console.WriteLine("Okay so you guys had " + coffee + " coffee(s) and you had " + water + " water(s) today. Ill be back with the bill shortly.");
            Console.WriteLine(" ");
            Console.WriteLine("Heres your bill, total price : " + String.Format("{0:0.00}", bill));
            Console.WriteLine(" ");
            Console.WriteLine(people + " Buffets = " + people + " x $9.99 = $" + people * 9.99);
            Console.WriteLine(coffee + " Coffee(s) = " + coffee + " x $2.00 = $" + coffee * 2.00);
            Console.WriteLine(water + " Water(s) = free");

            if (people >= 6)
            {
                Console.WriteLine("Sorry, but we can only serve 6 guests per party. Have a nice day!");
            }
             
        }
    }
}

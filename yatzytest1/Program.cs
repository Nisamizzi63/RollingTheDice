using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yatzytest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> dices = new List<int>();

            Console.WriteLine("Welcome to the Yatzy!)");


            Console.WriteLine("Do you wish to roll your dices? Enter >Yes or >No");
            string choose = Console.ReadLine().ToLower();
            int roll1, roll2, roll3, roll4, roll5;

            roll1 = rnd.Next(1, 7);
            roll2 = rnd.Next(1, 7);
            roll3 = rnd.Next(1, 7);
            roll4 = rnd.Next(1, 7);
            roll5 = rnd.Next(1, 7);

            switch (choose)
            {
                case "yes":
                    Console.WriteLine("\nYour rolled dices are: ");
                    Console.WriteLine("\nDice1 :" + roll1 + "\nDice2 :" + roll2 + " \nDice3 :" +
                        roll3 + " \nDice4 :" + roll4 + " \nDice5 :" + roll5);
                    break;
                case "no":
                    Console.WriteLine("okey bye");
                    break;

            }

            Console.WriteLine("\nDo you wish to reroll your dices?: y/n ");
            string reroll = Console.ReadLine();

            do

            {
                
                Console.WriteLine("\nDo you wish to reroll dice 1 y/n?");
                string choice1 = Console.ReadLine();

                Random random = new Random();

                switch (choice1)
                {
                    case "y":

                        roll1 = random.Next(1, 7);
                        break;

                    case "n":

                        break;
                }
                Console.WriteLine("do you wish to reroll dice 2? y/n");
                string choice2 = Console.ReadLine();

                switch (choice2)
                {
                    case "y":

                        roll2 = random.Next(1, 7);
                        break;

                    case "n":

                        break;

                }
                Console.WriteLine("do you wish to reroll dice 3? y/n");
                string choice3 = Console.ReadLine();



                switch (choice3)
                {
                    case "y":

                        roll3 = random.Next(1, 7);
                        break;

                    case "n":

                        break;

                }
                Console.WriteLine("do you wish to reroll dice 2? y/n");
                string choice4 = Console.ReadLine();

                switch (choice4)
                {
                    case "y":

                        roll4 = random.Next(1, 7);
                        break;

                    case "n":

                        break;

                }
                Console.WriteLine("do you wish to reroll dice 2? y/n");
                string choice5 = Console.ReadLine();

                switch (choice5)
                {
                    case "y":

                        roll5 = random.Next(1, 7);
                        break;

                    case "n":

                        break;

                }
                Console.WriteLine("\nYour new dices are: " + "\ndice1 :" + roll1 + "\ndice2 :" + roll2 +
                    "\ndice3 :" + roll3 + "\ndice4 :" + roll4 + "\ndice5: " + roll5);

            } while (reroll == "y");



        }  
    }
}

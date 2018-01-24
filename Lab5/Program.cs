using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        public static List<int> RollDice(int Sides, int Dice)
        {
            Random DiceRoller = new Random();
            List<int> Numbers = new List<int>();

            for (int i = 1; i <= Dice; i++)
            {
                int Roll = DiceRoller.Next(1, Sides + 1);
                Numbers.Add(Roll);
            }
            return Numbers;
        }


        static void Main(string[] args)
        {
            int HowSided, NumDice;
            List<int> Result;
            bool Repeat = true;
            string DoAgain;

            Console.WriteLine("Welcome to Dice Roller!");

            while (Repeat == true)
            {
                Console.WriteLine("How many sides should the dice have? Please enter a positive integer.");
                HowSided = int.Parse(Console.ReadLine());
                Console.WriteLine("How many dice do you want to roll? Please enter a positive integer.");
                NumDice = int.Parse(Console.ReadLine());

                Result = RollDice(HowSided, NumDice);

                foreach (int i in Result)
                {
                    Console.WriteLine($"Your roll resulted in: {i}");
                }
                
                Console.WriteLine("Would you like to roll again? (Y or N)");
                DoAgain = Console.ReadLine();

                if (DoAgain == "Y" || DoAgain == "y")
                {
                    Repeat = true;
                }
                else if (DoAgain == "N" || DoAgain == "n")
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    Repeat = false;
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("You did not enter Y or N. Goodbye!");
                    Repeat = false;
                    Console.Read();
                }
            }
        }
    }
}

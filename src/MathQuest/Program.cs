using System;

namespace MathQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            // Makes a string variable that stores the next input from the user
            string userName = Console.ReadLine(); 

            Console.WriteLine($"Hello, {userName}!");

            Random rnd = new Random();
            Console.WriteLine("\n20 random integers from -100 to 100:");
            for (int ctr = 1; ctr <= 20; ctr++)
            {
                Console.Write("{0,6}", rnd.Next(-100, 101));
                if (ctr % 5 == 0) 
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

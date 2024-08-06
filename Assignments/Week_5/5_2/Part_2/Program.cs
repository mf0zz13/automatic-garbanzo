using System;

namespace WeekFive
{
    class FiveTwo_2
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {   // Getting a number from the user. If user enters something other than a number a format exception is thrown
                    int userInput;
                    Console.WriteLine("This program outputs the natural numbers from 1 to the entered number");
                    Console.Write("Please enter a number: ");
                    bool validInput = Int32.TryParse(Console.ReadLine(), out userInput);
                    switch (validInput) { case false: throw new FormatException("Please Only enter numbers"); break; }

                    // Calling PrintNumber_Recurison method.
                    PrintNumbers_Recursion(userInput);
                    Console.ReadKey();
                    exit = true;
                }

                catch (Exception e) // Catching exceptions, displaying them to the user and then clearing the console to allow another attempt.
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        // Method takes the number passed and then using head recursion to print the numbers from smallest to greatest.
        static void PrintNumbers_Recursion(int n)
        {
            if (n > 0)
            {
                PrintNumbers_Recursion(n - 1);
                Console.Write(n + " ");
            }
        }
    }
}
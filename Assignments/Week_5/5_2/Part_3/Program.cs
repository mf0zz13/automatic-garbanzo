using System;

namespace WeekFive
{
    class FiveTwo_3
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {   // Getting the input from user. If the user enters something other than a number a format exception is thrown.
                    int userInput;
                    Console.WriteLine("This program outputs the natural numbers from the entered number to 1");
                    Console.Write("Please enter a number: ");
                    bool validInput = Int32.TryParse(Console.ReadLine(), out userInput);
                    switch (validInput) { case false: throw new FormatException("Please Only enter numbers"); break; }

                    // Calling the PrintNumbers_Recursion Method.
                    PrintNumbers_Recursion(userInput);
                    Console.ReadKey();
                    exit = true;
                }

                catch (Exception e) // Catching excepitons, displaying the message to the user and then clearing the console to allow another attempt.
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        // Method uses tail recursion to output the numbers from greatest to least.
        static void PrintNumbers_Recursion(int n)
        {
            if (n > 0)
            {
                Console.Write(n + " ");
                PrintNumbers_Recursion(n - 1);
            }
        }
    }
}
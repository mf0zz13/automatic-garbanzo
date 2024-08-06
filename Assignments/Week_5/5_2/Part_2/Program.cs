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
                {
                    int userInput;
                    Console.WriteLine("This program outputs the natural numbers from 1 to the entered number");
                    Console.Write("Please enter a number: ");
                    bool validInput = Int32.TryParse(Console.ReadLine(), out userInput);
                    switch (validInput) { case false: throw new FormatException("Please Only enter numbers"); break; }

                    PrintNumbers_Recursion(userInput);
                    Console.ReadKey();
                    exit = true;
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }


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
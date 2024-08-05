using System;

namespace WeekFive
{
    class FiveOne_3
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                try
                {   // Getting input from user.
                    Console.WriteLine("Integer Array Duplicate Checker");
                    Console.WriteLine("Please enter the numbers you would like in the array separtaed my a comma.");
                    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

                    // Outputting results.
                    Console.WriteLine($"\nDuplicates Present: {CheckForDoubles(numbers)}");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadLine();
                    exit = true;
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Hit any key to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public static bool CheckForDoubles(int[] numArray)
        {
            HashSet<int> numbers = new HashSet<int>();

            // Iterating through array. If a number is a duplicate the switch case true returns true.
            foreach (int num in numArray)
            {
                switch (numbers.Contains(num))
                {
                    case true:
                        return true;
                        break;
                    case false:
                        numbers.Add(num);
                        break;
                }
            }
            return false;
        }
    }
}
using System;

namespace WeekFive
{
    class FiveTwo_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will output the number of characters in the last word of a string.");
            Console.Write("Please enter a sentence: ");
            string[] inputString = Console.ReadLine().Split(' ');

            Console.WriteLine($"The last word is \"{inputString[inputString.Length - 1]}\" with a length of {inputString[inputString.Length - 1].Length} ");
            Console.ReadKey();
        }
    }
}

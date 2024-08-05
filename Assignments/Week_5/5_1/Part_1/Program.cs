using System;

namespace WeekFive
{
    class FiveOne_1
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                try
                {
                    int number;
                    char exitInput = ' ';

                    Console.WriteLine("Palindrome Checker");
                    Console.Write("Please enter a number: ");
                    bool status = Int32.TryParse(Console.ReadLine(), out number);
                    switch (status)
                    {
                        case false:
                            throw new FormatException("Only enter numbers.");
                            break;
                    }

                    Console.WriteLine($"Is Palindrome: {IsPalindrome(number)}");

                    Console.WriteLine("Would you like to enter another Number? (Y/N)");
                    status = Char.TryParse(Console.ReadLine().ToUpper(), out exitInput);
                    switch (status)
                    {
                        case false:
                            throw new FormatException("Only enter 'Y' or 'N'");
                    }

                    switch (exitInput)
                    {
                        case 'Y':
                            Console.Clear();
                            continue;
                            break;
                        case 'N':
                            exit = true;
                            break;
                        default:
                            throw new IndexOutOfRangeException("Only enter 'Y' or 'N'");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please hit any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            int originalNum = num;
            int currNum = 0;
            int reversedNum = 0;

            while (num > 0)
            {
                currNum = num % 10;
                reversedNum = (reversedNum * 10) + currNum;
                num /= 10;
            }

            return reversedNum == originalNum;
        }
    }
}
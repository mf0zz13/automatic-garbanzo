using System;

namespace WeekFive
{
    class FiveThree_2
    {
        static void CalculateOptions(int stairs)
        {
            int first = 2, second = 3, result =0;

            switch (stairs)
                {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                default:
                    for(int i = 4; i <= stairs; i++)
                    {
                        result = first + second;
                        first = second;
                        second = result;
                    }

                    Console.WriteLine(result);
                    break;
                }

        }

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                try
                {
                    int stairs;
                    Console.WriteLine("This Application will output the number of unique ways you can climb a set number of stairs if you take one or two steps at a time.");
                    Console.Write("Enter the amount stairs will you be climbing: ");
                    bool parseStatus = Int32.TryParse(Console.ReadLine(), out stairs);
                    if (!parseStatus) throw new Exception("Please only enter a number");
                    Console.Write("Amount of ways to climb to the top: ");
                    CalculateOptions(stairs);
                    Console.ReadKey();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}


using System;

namespace WeekFive
{
    class FiveOne_2
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while(!exit)
            {
                try
                {
                    // Getting input from the user;
                    Console.WriteLine("Calcualte the sum of the individual digits in a number.");
                    Console.Write("Please enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    //Outpuing the users results and exiting the program.
                    Console.WriteLine($"The sum of the digits of the number {number} is: {AddNumbers(number)}");
                    Console.WriteLine("\nPress any key to exit");
                    Console.ReadLine();
                    exit = true;
                }
                catch(Exception e)
                { 
                    // If exception is raised message is displayed and then user is allowed to conintue.
                    Console.WriteLine($"{e.Message}\nHit any key to conitnue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public static int AddNumbers(int num)
        {
            int sum = 0;

            // While loop takes the last integer off of the number and adds it to the running sum.
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
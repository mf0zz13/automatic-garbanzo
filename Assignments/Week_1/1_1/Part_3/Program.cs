namespace WeekOne
{
    class OneOne_3
    {
        static void Main(string[] args)
        {
            // The following block gets the first and second inputs from user converting the input from string to long.
            Console.Write("Please enter your first number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int sum = numberOne + numberTwo; // Adding the numbers.

            Console.WriteLine();
            Console.WriteLine($"{numberOne} + {numberTwo} = {sum}"); // Outputting the result of adding the inputs.
            Console.Read();
        }
    }
}
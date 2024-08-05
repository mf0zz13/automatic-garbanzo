namespace WeekOne
{
    class OneOne_4
    {
        static void Main(string[] args)
        {
            // The following block gets the first and second inputs from user converting the input from string to double.
            Console.Write("Please enter your first number: ");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());
            double sum = numberOne / numberTwo; // Dividing the numbers

            Console.WriteLine();
            Console.WriteLine($"{numberOne} / {numberTwo} = {sum}");// Outputting the result of dividing the inputs.
            Console.Read();

        }
    }
}
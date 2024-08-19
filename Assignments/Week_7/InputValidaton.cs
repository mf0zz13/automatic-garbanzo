using System;
using System.Windows.Forms;

namespace WeekSevenAssignments
{
    internal static class InputValidation
    {
        internal static class Arrays
        {
            public static int[] GetInt()
            {
                int[] intArray = new int[0];
                try
                {
                    bool validInputs = false;
                    while (!validInputs)
                    {
                        int arrayLength = 0;
                        Console.Write("How many integers would you like to store in the Array: ");
                        bool parseStatus = Int32.TryParse(Console.ReadLine(), out arrayLength);
                        if (!parseStatus) { throw new IndexOutOfRangeException("Only enter numbers"); }

                        intArray = new int[arrayLength];

                        Console.WriteLine("Please enter one number per line");
                        for (int i = 1; i <= arrayLength; i++)
                        {
                            Console.Write($"{i}: ");
                            intArray[i - 1] = Int32.Parse(Console.ReadLine());
                            
                        }
                        validInputs = true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return intArray;
            }
        }

        internal static class Ints
        {
            public static int GetNum()
            {
                int output = 0;
                try
                {
                    bool parseStatus = false;
                    while (!parseStatus)
                    {
                        parseStatus = Int32.TryParse(Console.ReadLine(), out output);
                        if (!parseStatus) { throw new ArgumentOutOfRangeException("Only enter a number"); }
                    }
                }
                catch (Exception e)
                { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                return output;
            }
        }
    }
}

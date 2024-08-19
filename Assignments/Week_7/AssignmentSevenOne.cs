using System;
using System.Text;

namespace WeekSevenAssignments
{
    internal static class AssignmentSevenOne
    {
        public static void PartOne()
        {
            Console.WriteLine("This part will sort grades in ascending order");
            int[] numArray = InputValidation.Arrays.GetInt();

            for (int i = 0; i < numArray.Length - 1; i++)
            {
                int minNumPos = i;
                for (int j = i + 1; j < numArray.Length; j++)
                {
                    if (numArray[minNumPos] > numArray[j]) { minNumPos = j; }

                    if (minNumPos != i)
                    {
                        int tempNum = numArray[i];
                        numArray[i] = numArray[minNumPos];
                        numArray[minNumPos] = tempNum;
                    }
                }
            }

            Console.Write($"[{numArray[0]}");
            for (int i = 1; i < numArray.Length; i++)
            {
                Console.Write($", {numArray[i]}");
            }
            Console.WriteLine("]");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }





        public static void PartTwo()
        {
            Console.Write("This part will merge two words together\nEnter the first word: ");
            string wordOne = Console.ReadLine();
            Console.Write("Enter the second word: ");
            string wordTwo = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int shortestWordLength = 0;
            bool wordOneShortest;

            if(wordOne.Length <= wordTwo.Length) { shortestWordLength = wordOne.Length; wordOneShortest = true; }
            else { shortestWordLength = wordTwo.Length; wordOneShortest = false; }

            for (int i = 0; i < shortestWordLength; i++)
            {
                sb.Append(wordOne[i]);
                sb.Append(wordTwo[i]);
            }

            if (wordOneShortest) 
            {
                for (int i = shortestWordLength; i < wordTwo.Length; i++)
                {
                    sb.Append(wordTwo[i]);
                }
            }
            else
            {
                for (int i = shortestWordLength; i < wordOne.Length; i++)
                {
                    sb.Append(wordOne[i]);
                }
            }

            Console.WriteLine($"Merged word: {sb.ToString()}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

    }
}
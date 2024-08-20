using System;
using System.Text;

namespace WeekSevenAssignments
{
    internal static class AssignmentSevenTwo
    {
        public static void PartOne()
        {
            Console.WriteLine("This part implements a Shell Sort");
            int[] nums = InputValidation.Arrays.GetInt();

            int gap = nums.Length / 2;
            int i;
            int j;

            while (gap > 0)
            {
                i = gap;
                while (i < nums.Length)
                {
                    j = i - gap;
                    int temp = nums[i];
                    while (j >= 0 && nums[j] > temp)
                    {
                        nums[j + gap] = nums[j];
                        j = j - gap;
                    }
                    nums[j + gap] = temp;
                    i++;
                }
                gap /= 2;
            }

            Console.Write($"[{nums[0]}");
            for (i = 1; i < nums.Length; i++)
            {
                Console.Write($", {nums[i]}");
            }
            Console.WriteLine("]");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static void PartTwo()
        {
            Console.WriteLine("This part will reverse all the vowels in a word");
            Console.Write("Please enter a word: ");
            string userInput = InputValidation.Strings.GetWord().ToLower();

            List<char> vowels = new List<char>();
            List<int> place = new List<int>();

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u')
                {
                    vowels.Add(userInput[i]);
                    place.Add(i);
                }
            }

            vowels.Reverse();

            StringBuilder sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (counter < vowels.Count && i == place[counter])
                {
                    sb.Append(vowels[counter]);
                    counter++;
                }
                else { sb.Append(userInput[i]); }
            }

            Console.WriteLine($"Output: {sb.ToString()}");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        public static void PartThree()
        {
            bool isAnagram = true;
            Console.WriteLine("This part will test if a word is an Anagram");
            Console.Write("Enter the first word: ");
            char[] wordOne = InputValidation.Strings.GetWord().ToLower().ToArray();

            Console.Write("Enter the second word: ");
            char[] wordTwo = InputValidation.Strings.GetWord().ToLower().ToArray();
            InsertionSort(wordOne);
            InsertionSort(wordTwo);

            if (wordOne.Length == wordTwo.Length)
            {
                for (int i = 0; i < wordOne.Length; i++)
                {
                    if (wordOne[i] != wordTwo[i]) { isAnagram = false; }
                }
            }
            else { isAnagram = false; }

            if (isAnagram) { Console.WriteLine("They are an anagram"); }
            else { Console.WriteLine("They are not an anagram"); }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private static void InsertionSort(char[] array)
        {
            char temp;
            int position = 0;

            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i];
                position = i;

                while (position > 0 && array[position - 1].CompareTo(temp) > 0)
                {
                    array[position] = array[position - 1];
                    position--;
                }
                array[position] = temp;
            }
        }
    }
}
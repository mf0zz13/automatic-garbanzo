using System;

namespace WeekFive
{
    class FiveTwo_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Checker");
            Console.Write("Enter a word to be checked: ");
            Console.WriteLine(PalindromeCheck(Console.ReadLine()));
            Console.ReadKey();

        }

        static bool PalindromeCheck(string word, int place = 0)
        {
            bool valid = true;
            word = word.ToUpper();

            if (place < Math.Ceiling(word.Length / 2.0))
            {
                if(!PalindromeCheck(word, place + 1)) return false;
                if (word[place] == word[(word.Length - 1) - place]) valid = true;
                else valid = false;
                
            }
            return valid;
        }
    }
}

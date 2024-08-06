using System;

namespace WeekFive
{
    class FiveTwo_4
    {
        static void Main(string[] args)
        {
            // Getting a word form the user, and passing it to the PalidromeCheck Method.
            Console.WriteLine("Palindrome Checker");
            Console.Write("Enter a word to be checked: ");
            Console.WriteLine(PalindromeCheck(Console.ReadLine()));
            Console.ReadKey();

        }

        /* Method takes two argument a string which is the word to be checked, and an int 'place' to track placement in the word. Place's default is set to zero.
         * Once in the method a bool is declared with the name value, and the string is converted to upper case to prevent false results due to capital letters. 
         * Next a if statment checks if the current place is half way through the word because it checks beyond the midpoit are duplicative.
         * If the if statment runs then another if statment is run, this statment calls itself adding one to the placement and evaluating if the result is fase, if so it will return false. This passes a false from the interior call to the original call.
         * Once the recursion to the center of the word is complete another if statment evaluates if the mirrored character placement in the word are the same. If so then true is returned else false.
         */
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

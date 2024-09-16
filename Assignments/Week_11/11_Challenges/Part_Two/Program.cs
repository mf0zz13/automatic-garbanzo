namespace Weel11ChallengeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindBallon("nlaebolko"));
            Console.WriteLine(FindBallon("loonbalxballpoon"));
            Console.ReadKey();
        }

        static int FindBallon(string input)
        {
            Dictionary<char, int> letterCount = new();

            foreach (char letter in input.ToLower())
            {
                if (letterCount.ContainsKey(letter))
                {
                    letterCount[letter] += 1;
                }
                else
                {
                    letterCount.Add(letter, 1);
                }
            }

            int maxInstances = 0;
            foreach (char letter in "balon")
            {
                switch (letter)
                {
                    case 'b':
                        if (!letterCount.ContainsKey(letter))
                            return 0;
                        maxInstances = letterCount[letter];
                        break;
                    case 'a':
                    case 'n':
                        if (!letterCount.ContainsKey(letter))
                            return 0;
                        if (letterCount[letter] < maxInstances)
                            maxInstances = letterCount[letter];
                        break;
                    case 'l':
                    case 'o':
                        if (!letterCount.ContainsKey(letter))
                            return 0;
                        int tempMaxInstances = Convert.ToInt32(Math.Floor((double)letterCount[letter] / 2.0));
                        if (tempMaxInstances < maxInstances)
                            maxInstances = tempMaxInstances;
                        break;
                }
            }

            return maxInstances;
        }
    }
}

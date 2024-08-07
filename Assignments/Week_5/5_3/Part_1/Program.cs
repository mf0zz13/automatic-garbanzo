namespace WeekFive
{
    class FiveThree_1
    {
        static bool SpaceInFlowerBed(int[] flowerBed, int numFlowers)
        {
            int openSpaces = 0;

            for (int i = 0; i < flowerBed.Length; i++)
            {
                switch (flowerBed[i])
                {
                    case 0:
                        if (flowerBed[i + 1] == 0 && flowerBed[i + 2] == 0) openSpaces++;
                        i += 2;
                        break;
                    case 1:
                        break;
                }
                if (openSpaces == numFlowers) return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                int numFlowers;
                Console.WriteLine("This application will check to see if there is space to plant a flower in an array flowerbed");
                Console.Write("Please enter a list consisting of 1's and 0's separted by commas: ");
                int[] flowerBed = Console.ReadLine()
                    .Split(',')
                    .Where(x => Int32.TryParse(x, out _))
                    .Select(Int32.Parse).ToArray();

                Console.Write("How many flowers would you like to try and add?: ");
                bool parseStatus = Int32.TryParse(Console.ReadLine(), out numFlowers);
                try
                {
                    if (parseStatus == false) throw new IndexOutOfRangeException("Only numbers are accepted.");
                }
                catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }

                Console.WriteLine(SpaceInFlowerBed(flowerBed, numFlowers));
                Console.ReadKey();
                Console.Clear();
                exit = true;
                }
            }
        }
    }
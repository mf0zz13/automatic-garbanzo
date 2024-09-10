using System.Linq;

namespace ten_two
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int[] numArray = new int[] { 2, -1, 3, -3, 10, -200 };

            partOne(numArray);

            Console.ReadLine();
        }

        public static void PartOne(int[] nums)
        {
            IEnumerable<int> results = from num in nums
                                       where num >= 0
                                       select num;

            Console.Write($"{{{results.First()}");

            for (int i = 1; i < results.Count(); i++)
            {
                Console.Write($", {results.ElementAt(i)}");
            }

            Console.WriteLine("}");
        }

        public static void PartOneTestCase()
        {

        }
    }
}
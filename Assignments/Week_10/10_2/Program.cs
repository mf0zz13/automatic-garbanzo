using System.Linq;

namespace ten_two
{
    public class Program
    {
        public static void Main(string[] args)
        {

            TestCase(nameof(PartOne));

            Console.ReadLine();
        }

        public static IEnumerable<int> PartOne(int[] nums)
        {
            IEnumerable<int> results = from num in nums
                                       where num >= 0
                                       select num;

            return results;
        }

        public static void PartTwo()
        {

        }

        public static void TestCase(string part)
        {
            // Test inputs
            int[] numArray1 = new int[] { 2, -1, 3, -3, 10, -200 };
            int[] numArray2 = new int[] { 7, 2, -100, 50 };
            int[] numArray3 = new int[] { -1, -2, -3, -50 };
            int[] numArray4 = new int[] { 1, 2, 3, 4 };

            // Valid outputs
            int[] output1 = new int[] { 2, 3, 10 };
            int[] output2 = new int[] { 7, 2, 50 };
            int[] output3 = new int[0];
            int[] output4 = new int[] { 1, 2, 3, 4 };



            if (part != nameof(PartTwo))
            {
                var result1 = PartOne(numArray1);
                var result2 = PartOne(numArray2);
                var result3 = PartOne(numArray3);
                var result4 = PartOne(numArray4);

                Console.WriteLine($"XXXXXXXXXXXXXXXXXXXXXXXXXXXX {part} XXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Console.WriteLine("Test Case 1:" + (result1.ToArray().SequenceEqual(output1) ? true : false));
                Console.WriteLine("Test Case 2:" + (result2.ToArray().SequenceEqual(output2) ? true : false));
                Console.WriteLine("Test Case 3:" + (result3.ToArray().SequenceEqual(output3) ? true : false));
                Console.WriteLine("Test Case 4:" + (result4.ToArray().SequenceEqual(output4) ? true : false));
            }


        }
    }
}
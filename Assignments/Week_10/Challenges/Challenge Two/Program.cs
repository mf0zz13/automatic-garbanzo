namespace Week10ChallengeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 5, 6 };
            int m = 3;
            int n = 3;

            MergeArray(nums1, m, nums2, n);
            foreach (int num in nums1)
            {
                Console.Write(num + " ");
            }
            Console.Read();
        }

        static void MergeArray(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1;
            int p2 = n - 1;

            if (n == 0)
                return;
            if (m == 0)
            {
                nums1 = nums2;
                return;
            }
            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (p2 < 0)
                    return;

                if (p1 >= 0 && nums1[p1] > nums2[p2])
                {
                    nums1[i] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[i] = nums2[p2];
                    p2--;
                }
            }
        }
    }
}
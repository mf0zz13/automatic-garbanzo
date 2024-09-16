namespace Week11ChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] colors = [2, 0, 2, 1, 1, 0];

            ColorSort(colors);

            foreach (int num in colors)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }

        static void ColorSort(int[] colors)
        {
            for (int i = 1; i < colors.Length; i++)
            {
                int temp = colors[i];
                int position = i;
                while (position > 0 && colors[i - 1] > temp)
                {
                    colors[position] = colors[position - 1];
                    position--;
                }
                colors[position] = temp;
            }
        }


    }
}
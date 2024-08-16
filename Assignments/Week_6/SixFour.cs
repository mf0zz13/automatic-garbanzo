using System;
using System.Windows.Forms;

namespace WeekSixAssignments
{
    public static class SixFour
    {
        public static void SixFourOne()
        {
            int[,] matrix = new int[,] { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"\t{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            RotateMatrix(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"\t{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void RotateMatrix(int[,] matrix)
        {
            int length = matrix.GetLength(0) - 1;
            for (int i = 0; i < (length + 1) / 2; i++)
            {
                for (int j = 0 + i; j < length - i; j++)
                {
                    int tempNum = matrix[i, j];
                    matrix[i, j] = matrix[length - j, i];
                    matrix[length - j, i] = matrix[length - i,length - j];
                    matrix[length - i, length - j] = matrix[j, length - i];
                    matrix[j, length - i] = tempNum;

                }
            }
        }
    }
}
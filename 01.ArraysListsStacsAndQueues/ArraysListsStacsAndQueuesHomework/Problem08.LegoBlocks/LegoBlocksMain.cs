namespace Problem08.LegoBlocks
{
    using System;
    using System.Linq;

    public class LegoBlocksMain
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] firstArray = new int[n][];
            int[][] secondArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] tempArray = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                firstArray[i] = tempArray;
            }

            for (int i = 0; i < n; i++)
            {
                int[] tempArray = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                secondArray[i] = tempArray;
            }

            int totalLength = firstArray[0].Length + secondArray[0].Length;
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                if (firstArray[i].Length + secondArray[i].Length == totalLength)
                {
                    count++;
                }
            }

            int[,] rectangle = new int[n, totalLength];
            if (count != n)
            {
                int numOfElements = firstArray.Sum(row => row.Length);
                numOfElements += secondArray.Sum(row => row.Length);
                Console.WriteLine("The total number of cells is: " + numOfElements);
            }
            else
            {
                ReverseJaggedArray(secondArray);
                for (int row = 0; row < rectangle.GetLength(0); row++)
                {
                    for (int col = 0; col < rectangle.GetLength(1); col++)
                    {
                        if (col < firstArray[row].Length)
                        {
                            rectangle[row, col] = firstArray[row][col];
                        }
                        else
                        {
                            rectangle[row, col] = secondArray[row][col - firstArray[row].Length];
                        }
                    }
                }

                PrintMatrix(rectangle);
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.Write("[");
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write("{0}, ", matrix[row, col]);
                }

                Console.Write("{0}]", matrix[row, matrix.GetLength(1) - 1]);
                Console.WriteLine();
            }
        }

        public static void ReverseJaggedArray(int[][] jaggedArray)
        {
            for (int rowIndex = 0;
              rowIndex <= jaggedArray.GetUpperBound(0); rowIndex++)
            {
                for (int colIndex = 0;
                     colIndex <= jaggedArray[rowIndex].GetUpperBound(0) / 2;
                     colIndex++)
                {
                    int tempHolder = jaggedArray[rowIndex][colIndex];
                    jaggedArray[rowIndex][colIndex] =
                      jaggedArray[rowIndex][jaggedArray[rowIndex].GetUpperBound(0) -
                              colIndex];
                    jaggedArray[rowIndex][jaggedArray[rowIndex].GetUpperBound(0) -
                              colIndex] = tempHolder;
                }
            }
        }
    }
}

namespace Problem01.FillTheMatrix
{
    using System;

    public class MatrixMain
    {
        public static void Main()
        {
            // Read the matrix dimensions
            Console.Write("Number of rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Number of columns = ");
            int cols = int.Parse(Console.ReadLine());

            // Allocate the matrix
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Matrix whit pattern A.");
            FirstPattern(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Matrix whit pattern B.");
            SecondPattern(matrix);
            PrintMatrix(matrix);
        }

        private static void FirstPattern(int[,] matrix)
        {
            int matrixNumber = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrixNumber++;
                    matrix[row, col] = matrixNumber;
                }
            }
        }

        private static void SecondPattern(int[,] matrix)
        {
            int matrixNumber = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrixNumber++;
                        matrix[row, col] = matrixNumber;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrixNumber++;
                        matrix[row, col] = matrixNumber;
                    }
                }
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}

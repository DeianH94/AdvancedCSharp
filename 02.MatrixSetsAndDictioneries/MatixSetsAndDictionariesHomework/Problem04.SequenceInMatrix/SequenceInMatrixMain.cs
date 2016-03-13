namespace Problem04.SequenceInMatrix
{
    using System;
    using System.Linq;

    public class SequenceInMatrixMain
    {
        public static void Main()
        {
            // Read the matrix dimensions
            Console.Write("Number of rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Number of columns = ");
            int cols = int.Parse(Console.ReadLine());

            // Allocate the matrix
            string[,] matrix = new string[rows, cols];

            // Example input
            // s qq ss
            // pp pp ss
            // pp qq ss

            // ss ss ss qq
            // pp pp pp pp
            // ww zz vv qq

            // ha fifi ho hi
            // fo ha hi xx
            // xxx ho ha xx

            // Fils the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] matrixRow = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixRow[col];
                }
            }

            int maxLength = int.MinValue;
            string simbol = matrix[0, 0];
            int currentLength = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                    }

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        simbol = matrix[row, col];
                    }
                }

                currentLength = 1;
            }

            for (int col = 1; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentLength = 1;
                    }

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        simbol = matrix[row, col];
                    }
                }

                currentLength = 1;
            }

            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    simbol = matrix[row, col];
                }
            }

            currentLength = 1;

            for (int row = 0, col = matrix.GetLength(1) - 2; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    simbol = matrix[row, col];
                }
            }


            Console.WriteLine("\nLongest sequence:");
            for (int i = 0; i < maxLength; i++)
            {
                if (i == maxLength - 1)
                {
                    Console.WriteLine("{0} ", simbol);
                }
                else
                {
                    Console.Write("{0}, ", simbol);
                }
            }
        }
    }
}

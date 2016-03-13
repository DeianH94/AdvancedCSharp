namespace Problem03.MatrixShuffling
{
    using System;
    using System.Linq;

    public class MatrixShufflingMain
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

            // Fils the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    string cellString = Console.ReadLine();
                    matrix[row, col] = cellString;
                }
            }

            Console.WriteLine();

            string[] command = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() != "swap" || command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int firstRow = int.Parse(command[1]);
                    int firstCol = int.Parse(command[2]);
                    int secondRow = int.Parse(command[3]);
                    int secondCol = int.Parse(command[4]);
                    bool rowOutsideMatrix = firstRow >= matrix.GetLength(0) || secondRow >= matrix.GetLength(0);
                    bool coloutsideMatrix = firstCol >= matrix.GetLength(1) || secondCol >= matrix.GetLength(1);
                    if (rowOutsideMatrix || coloutsideMatrix)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string temp = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = temp;
                        PrintMatrix(matrix);
                    }
                }

                Console.WriteLine();
                command = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }

        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}

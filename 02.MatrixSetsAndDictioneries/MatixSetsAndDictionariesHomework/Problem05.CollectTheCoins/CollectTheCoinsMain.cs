namespace Problem05.CollectTheCoins
{
    using System;

    class CollectTheCoinsMain
    {
        static void Main()
        {
            char[][] jaggedArray = new char[4][];

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = Console.ReadLine().ToCharArray();
            }

            char[] movementCommands = Console.ReadLine().ToCharArray();

            int currentRow = 0;
            int currentCol = 0;
            int coinsCollected = 0;
            int wallsHit = 0;

            foreach (char command in movementCommands)
            {
                if (command == '>' && jaggedArray[currentRow].Length - 1 > currentCol)
                {
                    currentCol++;
                }
                else if (command == '<' && currentCol > 0)
                {
                    currentCol--;
                }
                else if (command == '^' && currentRow > 0 
                    && jaggedArray[currentRow - 1].Length > currentCol)
                {
                    currentRow--;
                }
                else if (command == 'V' && currentRow < 4 
                    && jaggedArray[currentRow + 1].Length > currentCol)
                {
                    currentRow++;
                }
                else
                {
                    wallsHit++;
                }

                if (jaggedArray[currentRow][currentCol].Equals('$'))
                {
                    coinsCollected++;
                }
            }

            Console.WriteLine("Walls hit: {0}", wallsHit);
            Console.WriteLine("Coins collected: {0}", coinsCollected);
        }
    }
}

namespace Problem02.SortArrayUsingSelectionSort
{
    using System;
    using System.Linq;

    public class SelectionSortMain
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int posMin = i;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[posMin])
                    {
                        posMin = j;
                    }
                }

                if (posMin != i)
                {
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[posMin];
                    inputArray[posMin] = temp;
                }
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}

namespace Problem01.SortArrayOfNumbersUsingBubbleSort
{
    using System;
    using System.Linq;

    class BubbleSortMain
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            BubbleSort(inputArray);

            Console.WriteLine("[{0}]", string.Join(", ", inputArray));
        }

        private static void BubbleSort(int[] array)
        {
            for (int i = 1; i <= array.Length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

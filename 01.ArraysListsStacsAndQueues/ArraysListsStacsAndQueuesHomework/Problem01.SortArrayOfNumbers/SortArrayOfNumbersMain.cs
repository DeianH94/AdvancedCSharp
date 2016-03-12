namespace Problem01.SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public class SortArrayOfNumbersMain
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(inputArray);

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}

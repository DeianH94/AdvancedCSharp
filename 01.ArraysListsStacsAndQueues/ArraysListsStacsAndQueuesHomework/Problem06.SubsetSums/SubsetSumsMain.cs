namespace Problem06.SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSumsMain
    {
        private static void Main()
        {
            int sumToFind = int.Parse(Console.ReadLine());

            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<string> allCombinations = getAllCombinations(inputArray, sumToFind);

            if (allCombinations.Count == 0)
            {
                Console.WriteLine("No matching subsets.");
            }

            foreach (var element in allCombinations)
            {
                Console.WriteLine("{0} = {1}", element, sumToFind);
            }
        }

        private static List<string> getAllCombinations(int[] array, int sumToFind)
        {
            //http://stackoverflow.com/questions/7802822/all-possible-combinations-of-a-list-of-values-in-c-sharp
            List<string> allCombinations = new List<string>();
            List<int> currentList = new List<int>();
            double count = Math.Pow(2, array.Length);

            for (int i = 1; i <= count - 1; i++)
            {
                string str = Convert.ToString(i, 2).PadLeft(array.Length, '0');
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == '1')
                    {
                        currentList.Add(array[j]);
                    }
                }

                if (currentList.Sum() == sumToFind)
                {
                    allCombinations.Add(string.Join(" + ", currentList));
                }

                currentList.Clear();
            }

            return allCombinations;
        }
    }
}

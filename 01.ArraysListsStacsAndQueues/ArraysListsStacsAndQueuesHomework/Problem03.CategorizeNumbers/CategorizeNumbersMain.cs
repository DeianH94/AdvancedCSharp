namespace Problem03.CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CategorizeNumbersMain
    {
        public static void Main()
        {
            double[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            List<int> intNums = new List<int>();
            List<double> doubleNums = new List<double>();

            foreach (double element in inputArray)
            {
                if (element % 1 == 0)
                {
                    intNums.Add((int)element);
                }
                else
                {
                    doubleNums.Add(element);
                }
            }

            Console.WriteLine(
                "[{0}] -> Min: {1:0.###}, Max: {2:0.###}, Sum: {3:0.###}, Average: {4:0.00}",
                string.Join(" ", doubleNums),
                doubleNums.Min(),
                doubleNums.Max(),
                doubleNums.Sum(),
                doubleNums.Average());

            Console.WriteLine(
                "[{0}] -> Min: {1}, Max: {2}, Sum: {3}, Average: {4:0.00}",
                string.Join(" ", intNums),
                intNums.Min(),
                intNums.Max(),
                intNums.Sum(),
                intNums.Average());
        }
    }
}

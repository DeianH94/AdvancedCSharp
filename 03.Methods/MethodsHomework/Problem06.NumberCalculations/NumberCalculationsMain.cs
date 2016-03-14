namespace Problem06.NumberCalculations
{
    using System;

    public class NumberCalculationsMain
    {
        public static void Main()
        {
            decimal[] decimalNums = { 1.58m, 2.84m, 3.14m, 4.26m, 5.95m, 6.57m, 7.98m, 8.34m, 9.57m };
            double[] doubleNums = { 1.59, 2.24, 3.97, 4.24, 5.46, 6.14, 7.18, 8.56, 9.34 };

            Console.WriteLine("Decimal numbers:");
            Console.WriteLine("Average = " + GetAverage(decimalNums));
            Console.WriteLine("Max = " + GetMax(decimalNums));
            Console.WriteLine("Min = " + GetMin(decimalNums));
            Console.WriteLine("Product = " + GetProduct(decimalNums));
            Console.WriteLine("Sum = " + GetSum(decimalNums));

            Console.WriteLine("\nDouble numbers:");
            Console.WriteLine("Average = " + GetAverage(doubleNums));
            Console.WriteLine("Max = " + GetMax(doubleNums));
            Console.WriteLine("Min = " + GetMin(doubleNums));
            Console.WriteLine("Product = " + GetProduct(doubleNums));
            Console.WriteLine("Sum = " + GetSum(doubleNums));
        }

        public static decimal GetAverage(decimal[] decimalNums)
        {
            return GetSum(decimalNums) / decimalNums.Length;
        }

        public static double GetAverage(double[] doubleNums)
        {
            return GetSum(doubleNums) / doubleNums.Length;
        }

        public static decimal GetSum(decimal[] decimalNums)
        {
            decimal sum = 0;
            foreach (decimal num in decimalNums)
            {
                sum += num;
            }

            return sum;
        }

        public static double GetSum(double[] doubleNums)
        {
            double sum = 0;
            foreach (double num in doubleNums)
            {
                sum += num;
            }

            return sum;
        }

        public static decimal GetMax(decimal[] decimalNums)
        {
            decimal maxElement = decimal.MinValue;
            foreach (decimal num in decimalNums)
            {
                if (num > maxElement)
                {
                    maxElement = num;
                }
            }

            return maxElement;
        }

        public static decimal GetMin(decimal[] decimalNums)
        {
            decimal minElement = decimal.MaxValue;
            foreach (decimal num in decimalNums)
            {
                if (num < minElement)
                {
                    minElement = num;
                }
            }

            return minElement;
        }

        public static double GetMax(double[] doubleNums)
        {
            double maxElement = double.MinValue;
            foreach (double num in doubleNums)
            {
                if (num > maxElement)
                {
                    maxElement = num;
                }
            }

            return maxElement;
        }

        public static double GetMin(double[] doubleNums)
        {
            double minElement = double.MaxValue;
            foreach (double num in doubleNums)
            {
                if (num < minElement)
                {
                    minElement = num;
                }
            }

            return minElement;
        }

        public static decimal GetProduct(decimal[] decimalNums)
        {
            decimal sum = 1;
            foreach (decimal num in decimalNums)
            {
                sum *= num;
            }

            return sum;
        }

        public static double GetProduct(double[] doubleNums)
        {
            double sum = 1;
            foreach (double num in doubleNums)
            {
                sum *= num;
            }

            return sum;
        }
    }
}

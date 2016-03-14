namespace Problem05.ReverseNumber
{
    using System;
    using System.Linq;

    public class ReverseNumberMain
    {
        public static void Main()
        {
            double reversed = GetReversedNumber(double.Parse(Console.ReadLine()));
            Console.WriteLine(reversed);
        }

        private static double GetReversedNumber(double num)
        {
            string reverseString = new string(num.ToString().Reverse().ToArray());
            double reverseNum = double.Parse(reverseString);

            return reverseNum;
        }
    }
}

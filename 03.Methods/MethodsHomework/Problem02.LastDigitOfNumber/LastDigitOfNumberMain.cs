namespace Problem02.LastDigitOfNumber
{
    using System;

    public class LastDigitOfNumberMain
    {
        public static void Main()
        {
            Console.WriteLine(GetLastDigitAsWord(512));
            Console.WriteLine(GetLastDigitAsWord(1024));
            Console.WriteLine(GetLastDigitAsWord(12309));
        }

        public static string GetLastDigitAsWord(int num)
        {
            string[] digitAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int digit = num % 10;

            return digitAsWord[digit];
        }
    }
}

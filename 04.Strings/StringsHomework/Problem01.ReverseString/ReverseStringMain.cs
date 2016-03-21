namespace Problem01.ReverseString
{
    using System;

    public class ReverseStringMain
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] charArray = inputString.ToCharArray();
            string reverseString = string.Empty;

            // Array.Reverse(charArray);
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverseString += charArray[i];
            }

            Console.WriteLine(reverseString);
        }
    }
}

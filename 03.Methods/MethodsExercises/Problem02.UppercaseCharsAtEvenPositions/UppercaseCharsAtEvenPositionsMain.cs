namespace Problem02.UppercaseCharsAtEvenPositions
{
    using System;

    class UppercaseCharsAtEvenPositionsMain
    {
        static void Main()
        {
            Console.WriteLine("Input a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine(UppercaseCharsAtEvenPositions(inputString));
        }

        public static string UppercaseCharsAtEvenPositions(string str)
        {
            char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }

            return new string(arr);
        }
    }
}

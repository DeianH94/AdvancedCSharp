namespace Problem02.StringLength
{
    using System;

    public class StringLengthMain
    {
        public static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();
            if (charArray.Length >= 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(charArray[i]);
                }
            }
            else
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    Console.Write(charArray[i]);
                }

                Console.Write(new string('*', 20 - charArray.Length));
            }

            Console.WriteLine();
        }
    }
}

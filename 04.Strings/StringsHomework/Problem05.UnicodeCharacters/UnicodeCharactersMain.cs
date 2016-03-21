namespace Problem05.UnicodeCharacters
{
    using System;

    public class UnicodeCharactersMain
    {
        public static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)charArray[i]);
            }

            Console.WriteLine();
        }
    }
}

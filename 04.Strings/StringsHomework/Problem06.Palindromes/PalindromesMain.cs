namespace Problem06.Palindromes
{
    using System;
    using System.Linq;

    public class PalindromesMain
    {
        public static void Main(string[] args)
        {
            string[] consoleInput =
                Console.ReadLine()
                    .Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            bool isItFirst = true;

            for (int i = 0; i < consoleInput.Length; i++)
            {
                char[] word = consoleInput[i].ToCharArray();
                Array.Reverse(word);
                string backwards = new string(word);
                if (consoleInput[i].Equals(backwards))
                {
                    if (isItFirst)
                    {
                        Console.Write(consoleInput[i]);
                        isItFirst = false;
                    }
                    else
                    {
                        Console.Write(", " + consoleInput[i]);
                    }    
                }
            }

            Console.WriteLine();
        }
    }
}

namespace Problem06.CountSymbols
{
    using System;
    using System.Collections.Generic;

    class CountSymbolsMain
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            var chars = new SortedDictionary<char, int>();

            foreach (var ch in inputString)
            {
                if (chars.ContainsKey(ch))
                {
                    chars[ch]++;
                }
                else
                {
                    chars[ch] = 1;
                }
            }

            foreach (var pair in chars)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}

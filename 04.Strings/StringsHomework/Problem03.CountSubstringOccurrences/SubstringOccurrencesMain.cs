namespace Problem03.CountSubstringOccurrences
{
    using System;

    public class SubstringOccurrencesMain
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();
            string stringToCompare = Console.ReadLine().ToLower();

            int cout = 0;
            int index = inputString.IndexOf(stringToCompare);
            while (index != -1)
            {
                cout++;
                index = inputString.IndexOf(stringToCompare, index + 1);
            }

            Console.WriteLine(cout);
        }
    }
}

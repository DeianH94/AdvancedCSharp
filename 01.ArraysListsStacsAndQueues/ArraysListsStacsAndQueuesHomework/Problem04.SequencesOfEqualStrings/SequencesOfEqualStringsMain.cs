namespace Problem04.SequencesOfEqualStrings
{
    using System;
    using System.Linq;

    public class SequencesOfEqualStringsMain
    {
        public static void Main()
        {
            string[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.Write(inputArray[0] + " ");
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] != inputArray[i - 1])
                {
                    Console.WriteLine();
                }

                Console.Write(inputArray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

namespace Problem05.LongestIncreasingSequence
{
    using System;
    using System.Linq;

    public class LongestIncreasingSequenceMain
    {
        public static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startOfSequence = 0;
            int sequenceLength = 1;
            int currentLength = 1;

            Console.Write(inputArray[0] + " ");
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] <= inputArray[i - 1])
                {
                    Console.WriteLine();
                    if (currentLength > sequenceLength)
                    {
                        sequenceLength = currentLength;
                        startOfSequence = i - currentLength;
                    }

                    currentLength = 0;
                }

                Console.Write(inputArray[i] + " ");
                currentLength++;
            }

            if (currentLength > sequenceLength)
            {
                sequenceLength = currentLength;
                startOfSequence = inputArray.Length - currentLength;
            }

            Console.WriteLine();
            Console.Write("Longest: ");
            for (int i = startOfSequence; i < startOfSequence + sequenceLength; i++)
            {
                Console.Write(inputArray[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

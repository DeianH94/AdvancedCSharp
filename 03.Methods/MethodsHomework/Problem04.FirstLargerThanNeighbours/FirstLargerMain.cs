namespace Problem04.FirstLargerThanNeighbours
{
    using System;
    using Problem03.LargerThanNeighbours;

    public class FirstLargerMain
    {
        public static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        public static int GetIndexOfFirstElementLargerThanNeighbours(int[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                if (LargerThanNeighboursMain.IsLargerThanNeighbours(sequence, i))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

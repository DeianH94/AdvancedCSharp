namespace Problem01.BiggerNumber
{
    using System;

    public class BiggerNumberMain
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int max = GetMax(firstNum, secondNum);
            Console.WriteLine(max);
        }

        public static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }

            return secondNum;
        }
    }
}

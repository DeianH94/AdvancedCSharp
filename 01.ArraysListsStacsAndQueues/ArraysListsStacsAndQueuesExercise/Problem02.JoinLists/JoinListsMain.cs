namespace Problem02.JoinLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class JoinListsMain
    {
        static void Main()
        {
            int[] firstArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> joinedList = new List<int>();

            AddArrayToList(joinedList, firstArray);
            AddArrayToList(joinedList, secondArray);
            joinedList.Sort();

            Console.WriteLine(string.Join(" ", joinedList));
        }

        private static void AddArrayToList(List<int> list, int[] array)
        {
            foreach (int elemnet in array)
            {
                if (!list.Contains(elemnet))
                {
                    list.Add(elemnet);
                }
            }
        }
    }
}

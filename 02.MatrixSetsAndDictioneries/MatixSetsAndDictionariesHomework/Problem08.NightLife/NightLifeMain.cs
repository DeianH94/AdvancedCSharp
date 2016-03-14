namespace Problem08.NightLife
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class NightLifeMain
    {
        static void Main()
        {
            string[] inputData = Console.ReadLine()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var clubInfo = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            while (inputData[0].ToLower() != "end")
            {
                string city = inputData[0];
                string venue = inputData[1];
                string performer = inputData[2];

                if (!clubInfo.ContainsKey(city))
                {
                    clubInfo.Add(city, new SortedDictionary<string, SortedSet<string>>());
                }

                if (!clubInfo[city].ContainsKey(venue))
                {
                    clubInfo[city].Add(venue, new SortedSet<string>());
                }

                clubInfo[city][venue].Add(performer);
                inputData = Console.ReadLine()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var city in clubInfo)
            {
                Console.WriteLine(city.Key);
                foreach (var pair in city.Value)
                {
                    Console.WriteLine("->{0}: {1}", pair.Key, string.Join(", ", pair.Value));
                }
            }
        }
    }
}

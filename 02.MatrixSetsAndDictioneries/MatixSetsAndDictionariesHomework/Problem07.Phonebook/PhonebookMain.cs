namespace Problem07.Phonebook
{
    using System;
    using System.Collections.Generic;

    class PhonebookMain
    {
        static void Main()
        {
            string[] inputContact = Console.ReadLine().Split('-');
            var phonebook = new Dictionary<string, List<string>>();

            while (inputContact[0] != "search")
            {
                if (!phonebook.ContainsKey(inputContact[0]))
                {
                    phonebook[inputContact[0]] = new List<string>();
                }

                phonebook[inputContact[0]].Add(inputContact[1]);
                inputContact = Console.ReadLine().Split('-');
            }

            string searchName = Console.ReadLine();
            while (searchName != string.Empty)
            {
                if (phonebook.ContainsKey(searchName))
                {
                    Console.WriteLine("{0} -> {1}", searchName, string.Join(", ", phonebook[searchName]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", searchName);
                }

                searchName = Console.ReadLine();
            }
        }
    }
}

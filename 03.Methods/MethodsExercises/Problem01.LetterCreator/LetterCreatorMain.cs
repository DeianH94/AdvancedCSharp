namespace Problem01.LetterCreator
{
    using System;

    public class LetterCreatorMain
    {
        public static void Main()
        {
            Console.WriteLine("Input the name of the receiver:");
            string receiver = Console.ReadLine();
            Console.WriteLine("Input the name of the sender:");
            string sender = Console.ReadLine();

            DateTime currentTime = DateTime.Today;
            PrintLetter(sender, receiver, currentTime);
        }

        public static void PrintLetter(string sender, string receiver, DateTime currenTime)
        {
            Console.WriteLine("Dear {0},", receiver);
            Console.WriteLine("I hope I find you in good health.");
            Console.WriteLine("I need to inform you that the cheese has run away.");
            Console.WriteLine("Sincerely, {0}", sender);
            Console.WriteLine(currenTime.ToString("dd/MM/yyyy"));
        }
    }
}

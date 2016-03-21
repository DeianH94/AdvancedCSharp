namespace Problem04.TextFilter
{
    using System;
    using System.Linq;

    public class TextFilterMain
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] wordToCensor =
                Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] censor = new string[wordToCensor.Length];
            for (int i = 0; i < censor.Length; i++)
            {
                censor[i] = new string('*', wordToCensor[i].Length);
                text = text.Replace(wordToCensor[i], censor[i]);
            }

            Console.WriteLine(text);
        }
    }
}

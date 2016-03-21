namespace Problem09.StuckNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StuckNumbersMain
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            int count = 0;
            StringBuilder first = new StringBuilder();
            StringBuilder second = new StringBuilder();
            StringBuilder result = new StringBuilder();
            for (int firstNum = 0; firstNum < nums.Length; firstNum++)
            {
                string a = nums[firstNum];
                for (int secondNum = 0; secondNum < nums.Length; secondNum++)
                {
                    string b = nums[secondNum];
                    for (int thirdNum = 0; thirdNum < nums.Length; thirdNum++)
                    {
                        string c = nums[thirdNum];
                        for (int fourthNum = 0; fourthNum < nums.Length; fourthNum++)
                        {
                            string d = nums[fourthNum];

                            if (a != b && a != c & a != d &&
                            b != c && b != d && c != d)
                            {
                                first.Append(a);
                                first.Append(b);
                                second.Append(c);
                                second.Append(d);
                                if (first.Equals(second))
                                {
                                    result.Append(a);
                                    result.Append("|");
                                    result.Append(b);
                                    result.Append("==");
                                    result.Append(c);
                                    result.Append("|");
                                    result.Append(d);
                                    result.Append("\n");
                                    Console.Write(result);
                                    count++;
                                }

                                first.Clear();
                                second.Clear();
                                result.Clear();
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}

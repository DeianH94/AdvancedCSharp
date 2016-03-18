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
            int[] nums = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int count = 0;
            for (int firstNum = 0; firstNum < nums.Length; firstNum++)
            {
                for (int secondNum = 0; secondNum < nums.Length; secondNum++)
                {
                    for (int thirdNum = 0; thirdNum < nums.Length; thirdNum++)
                    {
                        for (int fourthNum = 0; fourthNum < nums.Length; fourthNum++)
                        {
                            int a = nums[firstNum];
                            int b = nums[secondNum];
                            int c = nums[thirdNum];
                            int d = nums[fourthNum];

                            if (a != b && a != c & a != d &&
                            b != c && b != d && c != d)
                            {
                                string first = a + b.ToString();
                                string second = c + d.ToString();
                                if (first == second)
                                {
                                    Console.Write("{0}|{1}=={2}|{3}\n", a, b, c, d);
                                    count++;
                                }
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

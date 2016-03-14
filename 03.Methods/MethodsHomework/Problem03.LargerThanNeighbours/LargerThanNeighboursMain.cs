namespace Problem03.LargerThanNeighbours
{
    using System;

    public class LargerThanNeighboursMain
    {
        public static void Main()
        {
            int[] nums = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(nums, i));
            }
        }

        public static bool IsLargerThanNeighbours(int[] nums, int i)
        {
            bool isLarger = false;

            if (i == 0)
            {
                isLarger = nums[i] > nums[i + 1];
            }
            else if (i > 0 && i < nums.Length - 1)
            {
                isLarger = nums[i] > nums[i + 1] && nums[i] > nums[i - 1];
            }
            else
            {
                isLarger = nums[i] > nums[i - 1];
            }

            return isLarger;
        }
    }
}

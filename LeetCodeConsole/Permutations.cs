using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    public static class Permutations
    {
        // Given an array of integers, find all possible permutations
        public static void Run() 
        {
            int[] _Nums = new int[] { 1, 2, 3 };

            Console.WriteLine($"Given {string.Join(", ", _Nums)}, the combinations are:");
        }

        private static int[] Permute(int[] nums) 
        {
            return PermuteHelper(nums);
        }

        private static int[] PermuteHelper(int[] nums, int startIndex = 0) 
        {
            if (startIndex == nums.Length)
            {
                return nums;
            }

            IList<int[]> _Result = new List<int[]>();

            for (int i = startIndex; i < nums.Length; i++)
            {
                SwapElements(ref nums, startIndex, i);

                _Result.Add(PermuteHelper(nums, startIndex + 1));

                SwapElements(ref nums, startIndex, i);
            }

            // TODO: return result
            return new int[] { };
        }

        private static void SwapElements(ref int[] nums, int index1, int index2)
        {
            int _Temp = index1;

            nums[index1] = nums[index2];
            nums[index2] = nums[_Temp];
        }
    }
}

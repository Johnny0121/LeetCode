using System;

namespace LeetCodeConsole
{
    public static class GetRanges
    {
        // Given a sorted array of numbers, and a target number, find the FIRST and LAST indices within the array of that target number
        // [1, 3, 3, 5, 7, 8, 9, 9, 15], Target = 9, Output = [6, 7]
        public static void Run()
        {
            int[] _Nums = new int[] { 1, 3, 3, 5, 7, 8, 8, 9, 9, 9, 9, 9, 15 };
            int _Target = 9;

            Console.WriteLine(string.Join(", ", GetRangeByBinarySearch(_Nums, _Target)));
            Console.WriteLine(string.Join(", ", GetRangeByScan(_Nums, _Target)));
        }

        // Scan through array and look for the first and last instance
        // Linear time, Constant space
        private static int[] GetRangeByScan(int[] nums, int target)
        {
            int firstIndex = 0, lastIndex = 0, previousValue = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if (previousValue != target)
                    {
                        firstIndex = i;
                    }
                    else
                    {
                        lastIndex = i;
                    }
                }
                else if (previousValue == target)
                {
                    break;
                }

                previousValue = nums[i];
            }

            return new int[] { firstIndex, lastIndex };
        }

        // Two Binary searches to find the lowest index and highest index for that target
        // Logarithmic time, LogN space complexity if recursion, Constant space if iterative
        private static int[] GetRangeByBinarySearch(int[] nums, int target) 
        {
            int _First = BinarySearch(nums, 0, nums.Length - 1, target, true);
            int _Last = BinarySearch(nums, 0, nums.Length - 1, target, false);

            return new int[] { _First, _Last };
        }

        private static int BinarySearch(int[] nums, int low, int high, int target, bool firstOccurence) {
            if (high < low)
            {
                return -1;
            }

            int _Mid = low + (high - low) / 2;

            if (firstOccurence)
            {
                if (_Mid == 0 || target > nums[_Mid - 1] && target == nums[_Mid])
                {
                    return _Mid;
                }

                if (target > nums[_Mid])
                {
                    return BinarySearch(nums, _Mid + 1, high, target, firstOccurence);
                }
                else
                {
                    return BinarySearch(nums, low, _Mid - 1, target, firstOccurence);
                }
            }
            else
            {
                if (_Mid == nums.Length - 1 || target < nums[_Mid + 1] && target == nums[_Mid])
                {
                    return _Mid;
                }
                else if (target < nums[_Mid])
                {
                    return BinarySearch(nums, low, _Mid - 1, target, firstOccurence);
                }
                else
                {
                    return BinarySearch(nums, _Mid + 1, high, target, firstOccurence);
                }
            }
        }
    }
}

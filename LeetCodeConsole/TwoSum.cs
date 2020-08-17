using System;
using System.Collections.Generic;

namespace LeetCodeConsole
{
    public static class TwoSum
    {
        // Given an array of integers [1, 2, 3, 4, 5] and a target
        // Find two unique numbers and return their INDEXES in the array that sum together to equal the target, otherwise return nothing

        public static void Run()
        {
            int _Target = 6;
            int[] _Nums = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine($"Given the array [1, 2, 3, 4, 5, 6] and a target of {_Target}");
            Console.WriteLine($"The indexes are: {string.Join(", ", FindTwoSums(_Nums, _Target)) }");
        }


        // This solution picks out the first instance of finding the target and not possible outcomes
        private static int[] FindTwoSums(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Dictionary<int, List<int>> _Map = nums.Map();
                _Map[nums[i]].Remove(i);

                int keyToFind = target - nums[i];

                if (_Map.ContainsKey(keyToFind) && _Map[keyToFind].Count >= 1)
                {
                    return new int[] { i, _Map[keyToFind][0] };
                }
            }

            return new int[] { };
        }

        private static Dictionary<int, List<int>> Map(this int[] nums)
        {
            Dictionary<int, List<int>> _Result = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (_Result.ContainsKey(nums[i]))
                {
                    _Result[nums[i]].Add(i);
                }
                else
                {
                    _Result.Add(nums[i], new List<int> { i });
                }
            }

            return _Result;
        }
    }
}

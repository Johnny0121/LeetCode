using System;
using System.Collections.Generic;

namespace LeetCodeConsole
{
    // Given an array of DISTINCT integers and a target value, return two numbers within the array that sum to the target value
    public static class SimpleTwoSum
    {
        public static void Run()
        {
            int[] _Nums = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };

            Console.WriteLine(string.Join(", ", TwoSum(_Nums, 10)));
        }

        public static int[] TwoSum(int[] array, int target)
        {
            Dictionary<int, bool> _Dict = new Dictionary<int, bool>();

            foreach (int num in array)
            {
                if (_Dict.ContainsKey(target - num))
                {
                    return new int[] { num, target - num };
                }
                else
                {
                    _Dict.Add(num, true);
                }
            }

            return new int[] { };
        }
    }
}

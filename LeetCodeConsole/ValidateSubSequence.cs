using System;
using System.Linq;

namespace LeetCodeConsole
{
    // Problem: https://gyazo.com/4ee4c4c2a3c7edd921919abacbd32be8

    public static class ValidateSubSequence
    {
        public static void Run()
        {
            int[] _Array = new int[] { 5, 1, 22, 25, 6, -1, 8, 10 };
            int[] _Sequence = new int[] { 1, 6, -1, 10 };

            Console.WriteLine($"Valid Subsequence: {IsValidSubSequence2(_Array, _Sequence)}");
        }

        public static bool IsValidSubSequence(int[] array, int[] sequence)
        {
            int _Pointer = 0;
            while (_Pointer < array.Length)
            {
                if (array[_Pointer] == sequence[0])
                {
                    sequence = sequence.Skip(1).ToArray();
                }
                _Pointer++;
            }

            return sequence.Length > 0 ? false : true;
        }

        public static bool IsValidSubSequence2(int[] array, int[] sequence)
        {
            int _Pointer = 0;
            foreach (int num in array)
            {
                if (_Pointer == sequence.Length)
                {
                    break;
                }

                if (sequence[_Pointer] == num)
                {
                    _Pointer++;
                }
            }

            return _Pointer == sequence.Length;
        }
    }
}

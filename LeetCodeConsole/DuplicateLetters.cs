using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeConsole
{
    // Takes in a string of letters, returns letters that are duplicated

    public static class DuplicateLetters
    {
        public static void Run()
        {
            CheckForDuplicateLetters("indivisibilities");
        }

        public static void CheckForDuplicateLetters(string input)
        {
            IDictionary<char, int> _Letters = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (!_Letters.ContainsKey(letter))
                {
                    _Letters.Add(new KeyValuePair<char, int>(letter, 1));
                }
                else
                {
                    _Letters[letter] += 1;
                }
            }

            //string output = string.Join(", ", _Letters.Where(x => x.Value > 1).Select(x => $"{x.Key} ({x.Value})"));
            Console.WriteLine(_Letters.Where(x => x.Value > 1).Count());
        }
    }
}

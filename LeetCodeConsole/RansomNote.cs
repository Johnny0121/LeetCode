using System;
using System.Collections.Generic;

namespace LeetCodeConsole
{
    public class RansomNote
    {
        public static void Run()
        {
            char[] _Magazine = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };

            Console.WriteLine($"Given this magazine: {string.Join(", ", _Magazine)}\n");

            Console.WriteLine($"Can spell 'DOG': {CanSpell(_Magazine, "DOG")}");
            Console.WriteLine($"Can spell 'FED': {CanSpell(_Magazine, "FED")}");
            Console.WriteLine($"Can spell 'RED': {CanSpell(_Magazine, "RED")}");
            Console.WriteLine($"Can spell 'FEED': {CanSpell(_Magazine, "FEED")}");
            Console.WriteLine($"Can spell 'BEDA': {CanSpell(_Magazine, "BEDA")}");
        }

        // O(n) time complexity
        // O(k) space complexity where k represents the size of the created hashmap
        private static bool CanSpell(char[] availableLetters, string wordToSpell)
        {
            Dictionary<char, int> _Characters = new Dictionary<char, int>();

            foreach (char letter in availableLetters)
            {
                _Characters[letter] = (_Characters.ContainsKey(letter)) ? _Characters[letter] + 1 : 1;
            }

            foreach (char letter in wordToSpell)
            {
                if (_Characters.ContainsKey(letter) && _Characters[letter] >= 1)
                {
                    _Characters[letter]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        // Go through each letter in wordToSpell, remove them from available letters. If you cannot find the letter, then it cannot be spelt.
        // O(m * n) time complexity
        private static bool CanSpellBruteForce(char[] availableLetters, string wordToSpell)
        {
            if (!string.IsNullOrWhiteSpace(wordToSpell))
            {
                char[] _AvailableLettersCopy = (char[])availableLetters.Clone();

                foreach (char letter in wordToSpell)
                {
                    bool _FoundLetter = false;

                    for (int i = 0; i < _AvailableLettersCopy.Length; i++)
                    {
                        if (letter.Equals(_AvailableLettersCopy[i]))
                        {
                            _AvailableLettersCopy[i] = '0';
                            _FoundLetter = true;
                            break;
                        }
                    }

                    if (!_FoundLetter)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}

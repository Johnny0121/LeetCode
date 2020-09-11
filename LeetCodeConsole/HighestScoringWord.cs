using System;

namespace LeetCodeConsole
{
    public static class HighestScoringWord
    {
        public static void Run()
        {
            HighestScoring("what time are we climbing up to the volcano");
        }

        public static void HighestScoring(string sentence)
        {
            string[] _Sentence = sentence.Split(" ");

            int _HighestScore = 0;
            string _HighestScoreWord = string.Empty;

            foreach (string word in _Sentence)
            {
                if (GetScore(word) > _HighestScore)
                {
                    _HighestScore = GetScore(word);
                    _HighestScoreWord = word;
                }
            }

            Console.WriteLine($"{_HighestScoreWord} - {_HighestScore} points");
        }

        public static int GetScore(string word)
        {
            int _Score = 0;

            foreach (char letter in word)
            {
                _Score += char.ToLower(letter) - 96;
            }

            return _Score;
        }
    }
}

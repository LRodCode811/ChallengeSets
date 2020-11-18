using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach (var w in words)
            {
                if (w != null && words != null)
                {
                    if (ignoreCase == true && w.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                    else if (ignoreCase == false && w == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int counter = 0;
            int last = 0;
            if (str == "")
            {
                return -1;
            }

            int[] counts = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                foreach (var letter in str)
                {
                    if (str[i] == letter)
                    {
                        counts[i]++;
                    }
                }
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 1)
                {
                    last = i;
                }
                else if (counts[i] > 1)
                {
                    counter++;
                }
            }
            if (counter == str.Length)
            {
                return -1; 
            }
            return last;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxConsecCount = 0;
            int consecCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    consecCount++;
                }

                if (numbers[i] != numbers[i - 1])
                {
                    consecCount = 1;
                }

                if (consecCount > maxConsecCount)
                {
                    maxConsecCount = consecCount;
                }
            }
            return maxConsecCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> dubTrub = new List<double>();
            if (elements == null)
            {
                return dubTrub.ToArray();
            }

            if (n < 1)
            {
                return dubTrub.ToArray();
            }

            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % n == 0)
                {
                    dubTrub.Add(elements[i - 1]);
                }
            }
            return dubTrub.ToArray();
        }
    }
}

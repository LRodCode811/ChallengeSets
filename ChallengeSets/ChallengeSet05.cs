using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
          foreach (Business biz in businesses)
            {
                if (biz.TotalRevenue <= 0)
                {
                    biz.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
           if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

                int previousNum = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < previousNum)
                    {
                    return false;
                    }
                previousNum = numbers[i];  
                }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sumNextEven = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                   sumNextEven += numbers[i];
                }
            }
            return sumNextEven;
        }


        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0 || words.Length == 1)
            {
                return "";
            }
            string sentence = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
                if (sentence.Length == 0)
                {
                return "";
                }
            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
           if (elements == null)
            {
                return new double[0];
            }
            List<double> everyFourth = new List<double>();
            for (int i = 1; i <= elements.Count; i++)
            {
                if (i % 4 == 0)
                {
                    everyFourth.Add(elements[i - 1]);
                }
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (var letter in lowercaseAlphabet)
            {
                if (c == letter)
                {
                    return true;
                }
            }

            foreach (var letter in lowercaseAlphabet.ToUpper())
            {
                if (c == letter)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Count() % 2 == 0)            
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length; 
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int addition = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (int  i = 0;  i < numbers.Length;  i++)
            {
                addition += numbers[i];
            }
            return addition;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int evens = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens += num;
                }
            }
            return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
           if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            else
            {
                return number / 2; 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;  
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            bool pass = false;

            foreach (var x in password)
            {
                if (Char.IsUpper(x) == true)
                {
                    upper = true;
                }
                if (Char.IsLower(x) == true)
                {
                    lower = true;
                }
                if (Char.IsNumber(x) == true)
                {
                    number = true;
                }
            }
                if (upper && lower && number)
                {
                    pass = true;
                }
                return pass;
        }

        public char GetFirstLetterOfString(string val)
        {
            var first = val[0];
            return first;
        }

        public char GetLastLetterOfString(string val)
        {
            var last = val[val.Length - 1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        { 
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {

            List<int> numbers = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }
            return numbers.ToArray();

            //int[] numbers1 = new int[numbers.Count];
            //for (int j = 0; j < numbers.Count; j++)
            //{
            //    numbers1[j] = numbers[j];
            //}
            //return numbers1;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}

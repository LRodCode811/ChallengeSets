using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)

        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i; 
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestString = 10;
            if (str1.Length < shortestString)
            {
                shortestString = str1.Length;
            }
            if (str2.Length < shortestString)
            {
                shortestString = str2.Length;
            }
            if (str3.Length < shortestString)
            {
                shortestString = str3.Length;
            }
            if (str4.Length < shortestString)
            {
                shortestString = str4.Length;
            }
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = 8;

            if (number1 < smallestNumber)
            {
                smallestNumber = number1;
            }
            if (number2 < smallestNumber)
            {
                smallestNumber = number2;
            }
            if (number3 < smallestNumber)
            {
                smallestNumber = number3;
            }
            if (number4 < smallestNumber)
            {
                smallestNumber = number4;
            }
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        { 
            if (double.TryParse(input, out double result))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var elementCount = objs.Length;
            var majority = (elementCount / 2) + 1;
            var count = 0; 

            foreach (var element in objs)
            {
                if (element == null)
                {
                    count++;
                }
            }
                if (count >= majority)
                {
                return true;
                }
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double sumEven = 0;
            double evenCount = 0;
            foreach (double i in numbers)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                    evenCount++;
                }
            }
                if (evenCount == 0)
                {
                    return 0;
                }
            return sumEven / evenCount;
        }

        public int Factorial(int number)
        {
            var storeNum = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
                    for (int i = number; i > 0; i--)
                    {
                        storeNum *= i;
                    }
                    return storeNum;
        }
        
    }
}

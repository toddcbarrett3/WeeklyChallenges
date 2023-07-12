using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length%2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null && numbers.Any())
            {
                var min = numbers.Min();
                var max = numbers.Max();
                return min + max;
            }
            else
            {
                return 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length <= str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers?.Sum() ?? 0; //numbers is allowed to be null "numbers?" and if null will default to 0 "?? 0;"

            //var answer = 0;

            //if (numbers != null && numbers.Any())
            //{
            //    foreach (var item in numbers)
            //    {
            //        answer += item;

            //    }
            //    return answer;
            //}
            //else 
            //{
            //    return 0;
            //}
        }
                public int SumEvens(int[] numbers)
        {
            return numbers?.Where(x => x%2==0).Sum() ?? 0;

            //var answer = 0;

            //if (numbers != null && numbers.Any())
            //{
            //    foreach (var item in numbers)
            //    {
            //        if (item%2 == 0)
            //        {
            //            answer += item;
            //        }
            //    }
            //    return answer;
            //}
            //else
            //{
            //    return 0;
            //}
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers?.Any() ?? false ? numbers.Sum() % 2 != 0 : false;

            //var answer = 0;

            //if (numbers != null && numbers.Any())
            //{
            //    foreach (var item in numbers)
            //    {
            //        answer += item;

            //    }
            //    if (answer%2 == 0)
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number < 0 ? 0 : number / 2;

            //long answer = 0;
            
            //if (number%2 != 0)
            //{
            //    for (var i = number-2; i > 0; i-=2)
            //    {
            //        answer++;
            //    }
            //    return answer;
            //}
            //else
            //{
            //    for (var i = number-1; i > 0; i -= 2)
            //    {
            //        answer++;
            //    }
            //    return answer;
            //}
            
        }
    }
}

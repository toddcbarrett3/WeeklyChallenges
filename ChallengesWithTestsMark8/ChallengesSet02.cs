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
            return Char.IsLetter(c) ? true : false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length%2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number%2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
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
            var answer = 0;

            if (numbers != null && numbers.Any())
            {
                foreach (var item in numbers)
                {
                    answer = answer + item;

                }
                return answer;
            }
            else 
            {
                return 0;
            }
        }

        public int SumEvens(int[] numbers)
        {
            var answer = 0;

            if (numbers != null && numbers.Any())
            {
                foreach (var item in numbers)
                {
                    if (item%2 == 0)
                    {
                        answer = answer + item;
                    }
                }
                return answer;
            }
            else
            {
                return 0;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var answer = 0;

            if (numbers != null && numbers.Any())
            {
                foreach (var item in numbers)
                {
                    answer = answer + item;

                }
                if (answer%2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long answer = 0;
            
            if (number%2 != 0)
            {
                for (var i = number-2; i > 0; i-=2)
                {
                    answer++;
                }
                return answer;
            }
            else
            {
                for (var i = number-1; i > 0; i -= 2)
                {
                    answer++;
                }
                return answer;
            }
            
        }
    }
}

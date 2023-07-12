using System;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return (numbers.Where(x =>  x % 2 == 0).Sum()) - (numbers.Where(x => x % 2 != 0).Sum());
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strLength = { str1, str2, str3, str4 };
            return strLength.OrderBy(x => x.Length).First().Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] num = { number1, number2, number3, number4 };
            return num.OrderBy(x => x).First();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] triangle = { sideLength1, sideLength2, sideLength3 };
            Array.Sort(triangle);
            return triangle[0] + triangle[1] > triangle[2];
            
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var total = objs.Count();
            var nTotal = objs.Where(x => x == null).Count();
            return nTotal > total/2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers != null && numbers.Any())
            {
                if (numbers.Where(x => x % 2 == 0).Any())
                { 
                    return numbers.Where(x => x % 2 == 0).Average();
                }
                else return 0;
            }
            else { return 0; }
        }

        public int Factorial(int number)
        {
            
            if (number < 0) throw new ArgumentOutOfRangeException();
            int sum = 1;
            for (int i = number; i > 0; i--) 
            {
                sum *= i;      
            }
            return sum;
        }
    }
}

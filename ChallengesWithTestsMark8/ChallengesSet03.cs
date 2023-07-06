using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool answer = false;
            if (vals.Length == 0)
            {
                return false;
            }
            foreach (var val in vals)
            { 
                if (!val)
                {
                    answer = true;
                }
            }
            return answer;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            bool answer;
            int sum = 0;
            if (numbers != null && numbers.Count() != 0)
            {
                foreach (var val in numbers)
                {
                    if (val % 2 != 0)
                    {
                        sum = sum + val;
                    }
                }
                if (sum%2 != 0) { answer = true; }
                else { answer = false; }
            }
            else { answer = false; }
            return answer;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool answer;
            int lowerTest = 0;
            int upperTest = 0;
            int numberTest = 0;
            foreach (var item in password)
            {
                if (Char.IsLower(item))
                {
                    lowerTest++;
                }
                else if (Char.IsUpper(item))
                {
                    upperTest++;
                }
                else if (Char.IsNumber(item))
                {
                    numberTest++;
                }
            }
            if (lowerTest > 0 && upperTest > 0 && numberTest > 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddInts = new int[50];
            int j = 0;
            for (int i = 1;  i < 100; i+=2)
            {
                oddInts[j] += i;
                j++;
            }
            return oddInts;
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            string[] newString = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                newString[i] += words[i];
            }
            return newString;
        }
    }
}

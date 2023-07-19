using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) {  return false; }
            bool answer = false;
            foreach (var item in words)
            {
                if (item == null) { return false; }
                if (ignoreCase)
                {
                    if (item.ToLower() == word) { answer = true; }
                }
                else
                {
                    if (item == word) { answer = true; }
                }
            }
            return answer;
        }

        public bool IsPrimeNumber(int num)
        {
            bool answer = true;
            if (num < 2) { return false; }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) { answer = false; }
            }
            return answer;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //throw new NotImplementedException();
            int answer = -1;
            int count = 0;
            if (str.Length < 1)
            {
                return -1;
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    answer = i;
                    break;
                }
                count = 0;
            }
            return answer;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxValue = 0;
            int count = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1]) 
                {
                    count++;
                }
                else if (count > maxValue)
                {
                    maxValue = count;
                    count = 1;
                }
            }
            if (count > maxValue)
            {
                maxValue = count;
            }
            return maxValue;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //throw new NotImplementedException();
            if (elements == null || elements.Count < n || n < 1)
            {
                return new double[0];
            }
            var newElements = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                newElements.Add(elements[i]);
            }
            return newElements.ToArray();
        }
    }
}

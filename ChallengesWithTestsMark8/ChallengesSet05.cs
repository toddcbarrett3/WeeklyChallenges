using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var item in businesses)
            {
                if (item.TotalRevenue == 0) { item.Name = "CLOSED"; }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            var answer = false;
            if (numbers == null) { return false; }
            if (numbers.Length == 1) { return true; }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= numbers[i - 1])
                {
                    answer = true;
                }
                else
                {
                    answer = false; break;
                }
            }
            return answer;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }
            for (int j = 1; j < numbers.Length; j++)
            {
                if (numbers[j - 1] % 2 == 0)
                {
                    sum += numbers[j];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            var newWords = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Trim() != "")
                {
                    newWords.Add(words[i].Trim());
                }
            }
            var newString = string.Join(" ", newWords);
            return newString == "" ? "" : $"{newString}.";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
            {
                return new double[0];
            }
            var newElements = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                newElements.Add(elements[i]);
            }
            return newElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool answer = false;
            if (nums.Length < 2)
            {
                return false;
            }
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        answer = true;
                    }
                }
            }
            return answer;
        }
    }
}

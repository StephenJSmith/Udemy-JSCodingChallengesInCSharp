using System;

namespace CodingChallenge
{
    public class Palindromes
    {
        public bool IsPalindromeComparingReversedString(string input)
        {
            var util = new StringReversal();

            var reversed = util.ExecuteWithStringBuilder(input);

            return input == reversed;
        }

        public bool IsPalindromeUsingOppositeIndices(string input)
        {
            var index0 = 0;
            var index1 = input.Length - 1;

            while (index0 <= index1)
            {
                if (input[index0] != input[index1])
                {
                    return false;
                }
                index0++;
                index1--;
            }

            return true;
        }

        public bool IsPalindromeUsingRecursion(string input)
        {
            if (input.Length <= 1)
            {
                return true;
            }

            if (input.Length == 2)
            {
                return input[0] == input[1];
            }

            var index1 = input.Length - 1;
            if (input[0] != input[index1])
            {
                return false;
            }

            var nextInput = input.Substring(1, input.Length - 2);

            return IsPalindromeUsingRecursion(nextInput);
        }
    }
}

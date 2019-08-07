using System;
using System.Collections.Generic;

namespace CodingChallenge
{
    public class SentenceCapitalization
    {
        public string ExecuteWithSplitString(string input)
        {
            var wordsIn = input.Split(' ', StringSplitOptions.None);
            var wordsOut = new List<string>();

            foreach (var word in wordsIn)
            {
                var capitalized = word[0].ToString().ToUpper() + word.Substring(1).ToLower();
                wordsOut.Add(capitalized);
            }

            var output = string.Join(' ', wordsOut);

            return output;
        }

        public string ExecuteEnumeratingString(string input)
        {
            var arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = IsFirstLetter(i, arr)
                    ? char.ToUpper(arr[i])
                    : char.ToLower(arr[i]);
            }

            var output = string.Concat(arr);

            return output;
        }

        private bool IsFirstLetter(int index, char[] arr)
        {
            var isFirst = index == 0 || arr[index - 1] == ' ';

            return isFirst;
        }
    }
}

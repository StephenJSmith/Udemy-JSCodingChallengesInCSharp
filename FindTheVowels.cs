using System.Linq;
using System.Text.RegularExpressions;

namespace CodingChallenge
{
    public class FindTheVowels
    {
        private const string Vowels = "aeiou";

        public int ExecuteEnumerating(string input)
        {
            var count = 0;

            foreach (var ch in input.ToLower())
            {
                if (Vowels.Contains(ch))
                {
                    count++;
                }
            }

            return count;
        }

        public int ExecuteLinq(string input)
        {
            var lowered = input.ToLower();

            var count = lowered.Count(c => Vowels.Contains(c));

            return count;
        }

        public int ExecuteRegEx(string input)
        {
            var lowered = input.ToLower();
            var pattern = $"[{Vowels}]";
            var vowels = Regex.Matches(lowered, pattern);

            return vowels.Count;
        }
    }
}

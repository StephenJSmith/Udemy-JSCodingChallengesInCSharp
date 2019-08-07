using System.Linq;
using System.Text.RegularExpressions;

namespace CodingChallenge
{
    public class Anagrams
    {
        public bool IsAnagramsUsingDictionaries(string input1, string input2)
        {
            var cleanInput1 = CleanInput(input1);
            var cleanInput2 = CleanInput(input2);

            var dict1 = new CharacterCountDictionary(cleanInput1);
            var dict2 = new CharacterCountDictionary(cleanInput2);

            return dict1.IsAnagram(dict2.Counts);
        }

        public bool IsAnagramsSortingStrings(string input1, string input2)
        {
            var cleanInput1 = CleanInput(input1);
            var cleanInput2 = CleanInput(input2);

            var sorted1 = string.Concat(cleanInput1.OrderBy(c => c));
            var sorted2 = string.Concat(cleanInput2.OrderBy(c => c));

            return sorted1 == sorted2;
        }

        private string CleanInput(string input)
        {
            var rgx = new Regex("[^a-z0-9]");
//            var rgx = new Regex(@"[^\w]/g");
            var cleaned = rgx.Replace(input.ToLower(), "");

            return cleaned;
        }

    }
}

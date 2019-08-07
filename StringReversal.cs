using System.Linq;
using System.Text;

namespace CodingChallenge
{
    public class StringReversal
    {
        public string ExecuteWithStringBuilder(string input)
        {
            var sb = new StringBuilder();

            foreach (var character in input)
            {
                sb.Insert(0, character);
            }

            return sb.ToString();
        }

        public string ExecuteReverseArray(string input)
        {
            var chars = input.ToCharArray();

            var reversed = chars.Reverse();

            var output = string.Concat(reversed);

            return output;
        }

        public string ExecuteWithEnumeratedArray(string input)
        {
            var reversed = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var index = reversed.Length - (i + 1);
                reversed[index] = input[i];
            }

            var output = string.Concat(reversed);

            return output;
        }
    }
}

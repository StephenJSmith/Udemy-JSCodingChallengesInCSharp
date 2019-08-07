using System;

namespace CodingChallenge
{
    public class IntegerReversal
    {
        public int Execute(int input)
        {
            var sign = Math.Sign(input);
            var toString = input.ToString().Replace("-", "");
            var util = new StringReversal();
            var reversed = util.ExecuteWithStringBuilder(toString);

            if (Equals(!int.TryParse(reversed, out int toInt)))
            {
                throw  new ArgumentException($"Unable to parse {reversed} to an int");
            }

            var output = toInt * sign;

            return output;
        }
    }
}

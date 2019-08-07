namespace CodingChallenge
{
    public class MaxChars
    {
        public char Execute(string input)
        {
            var util = new CharacterCountDictionary(input);

            return util.MaxKvp.Key;
        }
    }
}

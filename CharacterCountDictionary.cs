using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge
{
    public class CharacterCountDictionary
    {
        private readonly string _input;
        private Dictionary<char, int> _charactersCount;

        public Dictionary<char, int> Counts => _charactersCount;
        public KeyValuePair<char, int> MaxKvp => 
            _charactersCount.OrderByDescending(m => m.Value)
                .FirstOrDefault();

        public CharacterCountDictionary(string input)
        {
            _input = input;
            CountCharacters();
        }

        private void CountCharacters()
        {
            _charactersCount = new Dictionary<char, int>();
            foreach (var character in _input)
            {
                if (_charactersCount.ContainsKey(character))
                {
                    _charactersCount[character]++;
                }
                else
                {
                    _charactersCount.Add(character, 1);
                }
            }
        }

        public bool IsAnagram(IDictionary<char, int> other)
        {
            if (_charactersCount.Count != other.Count)
            {
                return false;
            }

            foreach (var key in _charactersCount.Keys)
            {
                if (!other.ContainsKey(key)
                    || _charactersCount[key] != other[key])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

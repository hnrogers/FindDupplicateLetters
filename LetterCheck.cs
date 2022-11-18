using System;
using System.Linq;

namespace DuplicateLetters
{
    class Working
    {
        public int DuplicateCount(string example)
        {
            IDictionary<char, int> duplicates = new Dictionary<char, int>();

            for (int i = 0; i < example.Length; i++)
            {
                if (!duplicates.Keys.Contains(example[i]))
                {
                    duplicates.Add(example[i], example.Count(e => e == example[i]));
                }
            }
            
            return duplicates.Values.Count(val => val > 1);
        }
    }
}
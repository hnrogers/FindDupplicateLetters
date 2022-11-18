using System;
using System.Linq;

namespace DuplicateLetters
{
    class Primary
    {
        public static void Main()
        {
            Working work = new Working();

            Console.WriteLine(work.DuplicateCount("abcde"));
            Console.WriteLine(work.DuplicateCount("aabbcde"));
            Console.WriteLine(work.DuplicateCount("Indivisibilities"));
            Console.WriteLine(work.DuplicateCount("Aa"));
        }
    }

}

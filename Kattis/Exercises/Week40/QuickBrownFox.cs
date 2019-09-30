using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kattis.Exercises
{
    //https://open.kattis.com/problems/quickbrownfox
    public static class QuickBrownFox
    {
        public static void Main(string[] args)
        {
            List<char> letters = "abcdefghijklmnopqrstuvwxyz".ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var chars = letters.ToList();
                var term = Console.ReadLine();
                var missing = string.Empty;

                foreach (var c in term)
                {
                    var lower = char.ToLower(c);

                    if (chars.Contains(lower))
                        chars.Remove(lower);
                }

                if(chars.Count > 0)
                {
                    foreach (var c in chars)
                    {
                        missing += c;
                    }
                }

                Console.WriteLine(
                    chars.Count == 0 ? 
                    "pangram" :
                    "missing " + missing 
                    );
            }
        }
    }
}

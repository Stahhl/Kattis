using System;

namespace Kattis.Exercises
{
    //https://open.kattis.com/problems/drmmessages
    public static class DrmMessages
    {
        private static char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] divide1;
        private static char[] divide2;

        public static void Main(string[] args)
        {
            //Divide
            Divide();

            //Rotate
            Rotate();

            //Merge
            Merge();

            Console.WriteLine(divide1);
        }

        private static void Divide()
        {
            string input = Console.ReadLine();
            int half = input.Length / 2;

            divide1 = input.Substring(0, half).ToCharArray();
            divide2 = input.Substring(half, half).ToCharArray();
        }
        private static void Merge()
        {
            for (int i = 0; i < divide1.Length; i++)
            {
                divide1[i] = (char)(((divide1[i] + divide2[i]) % 'A') % 26 + 'A');
            }
        }
        private static void Rotate()
        {
            int charValue1 = 0;
            int charValue2 = 0;

            for (int i = 0; i < divide1.Length; i++)
            {
                charValue1 += Array.IndexOf(letters, divide1[i]);
                charValue2 += Array.IndexOf(letters, divide2[i]);
            }
            for (int i = 0; i < divide1.Length; i++)
            {
                divide1[i] = (char)(((divide1[i] % 'A') + charValue1) % 26 + 'A');
                divide2[i] = (char)(((divide2[i] % 'A') + charValue2) % 26 + 'A');
            }
        }
    }
}

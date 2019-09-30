using System;

namespace Kattis.Exercises
{
    //https://open.kattis.com/problems/fizzbuzz
    public static class FizzBuzz
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            int n = int.Parse(input[2]);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(
                    i % x == 0 && i % y == 0 ? "FizzBuzz" : //both
                    i % x == 0 ? "Fizz" : //one
                    i % y == 0 ? "Buzz" : //the other
                    i.ToString() //neither
                );
            }
        }
    }
}

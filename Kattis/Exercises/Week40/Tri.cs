using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis.Exercises
{
    //https://open.kattis.com/problems/tri
    public static class Tri
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            Console.WriteLine(EvaluateEquation(a, b, c));
        }

        private static string EvaluateEquation(int x, int y, int z)
        {
            //1
            //addition
            if (x + y == z)
                return $"{x}+{y}={z}";
            //subtraction
            if (x - y == z)
                return $"{x}-{y}={z}";
            // multiplication 
            if (x * y == z)
                return $"{x}*{y}={z}";
            //division
            if (x / y == z)
                return $"{x}/{y}={z}";

            //2
            //addition
            if (x == y + z)
                return $"{x}={y}+{z}";
            //subtraction
            if (x == y - z)
                return $"{x}={y}-{z}";
            // multiplication 
            if (x == y * z)
                return $"{x}={y}*{z}";
            //division
            if (x == y / z)
                return $"{x}={y}/{z}";

            return null;
        }
    }
}

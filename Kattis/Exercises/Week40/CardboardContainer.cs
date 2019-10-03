using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis.Exercises
{
    //https://open.kattis.com/problems/cardboardcontainer
    public static class CardboardContainer
    {
        //Surface area of rectangle:
        //A = 2(wh + lw + lh)
        //where w = width, l = length, h = height

        public static void Main(string[] args)
        {
            int numberOfCubes = int.Parse(Console.ReadLine());

            int height = 1;
            int width = 1;
            int length = 1;

            if (numberOfCubes > 1)
            {
                for (int i = 1; i <= numberOfCubes; i++)
                {
                    int a1 = 2 * ((width * height) + ((length + 1) * width) + ((length + 1) * height));
                    int a2 = 2 * (((width + 1) * height) + (length * (width + 1)) + (length * height));
                    int a3 = 2 * ((width * (height + 1)) + (length * width) + (length * (height + 1)));

                    if (a1 <= a2 && a1 <= a3)
                        length += 1;
                    if (a2 < a1 && a2 <= a3)
                        width += 1;
                    if (a3 < a1 && a3 < a2)
                        height += 1;
                }
            }

            //int volume = height * width * length;
            int area = 2 * ((width * height) + (length * width) + (length * height));
            Console.WriteLine(area.ToString());
        }

        private static int GetMin(int a1, int a2, int a3)
        {
            int min = Math.Min(a1, a2);

            return Math.Min(min, a3);
        }
    }
}

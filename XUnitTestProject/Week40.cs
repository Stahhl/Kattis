using System;
using Xunit;
using Kattis.Exercises;
using System.IO;
using System.Collections.Generic;

namespace XUnitTestProject
{
    public class Week40
    {
        [Fact]
        public void CardboardContainerTest()
        {
            var tests = new Dictionary<string, string>();

            tests["1"] = "6";
            tests["2"] = "10";
            tests["3"] = "14";
            tests["4"] = "16";
            //tests["5913"] = "2790";

            foreach (var item in tests)
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    using (StringReader sr = new StringReader(
                        string.Format(
                            item.Key)))
                    {
                        Console.SetIn(sr);

                        CardboardContainer.Main(null);

                        string expected = item.Value + Environment.NewLine;

                        Assert.Equal(expected, sw.ToString());
                    }
                }
            }
        }
        [Fact]
        public void TriTest()
        {
            var tests = new Dictionary<string, string>();

            //addition
            tests["5 3 8"] = "5+3=8";
            //subtraction
            tests["5 3 2"] = "5-3=2";
            //multiplication
            tests["5 3 15"] = "5*3=15";
            //division
            tests["9 3 3"] = "9/3=3";


            foreach (var item in tests)
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    using (StringReader sr = new StringReader(
                        string.Format(
                            item.Key)))
                    {
                        Console.SetIn(sr);

                        Tri.Main(null);

                        string expected = item.Value + Environment.NewLine;

                        Assert.Equal(expected, sw.ToString());
                    }
                }
            }
        }
        [Fact]
        public void DrmMessagesTest()
        {
            using(StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(
                    string.Format(
                        "EWPGAJRB")))
                {
                    Console.SetIn(sr);

                    DrmMessages.Main(null);

                    string expected = "ABCD" + Environment.NewLine;

                    Assert.Equal(expected, sw.ToString());
                }
            }
        }
        [Fact]
        public void QuickBrownFoxTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(
                    string.Format(
                        "3{0}" +
                        "The quick brown fox jumps over the lazy dog.{0}" +
                        "ZYXW, vu TSR Ponm lkj ihgfd CBA.{0}" +
                        ".,?!'\" 92384 abcde FGHIJ"
                        , Environment.NewLine)))
                {

                    Console.SetIn(sr);

                    QuickBrownFox.Main(null);

                    string expected = string.Format(
                        "pangram{0}" +
                        "missing eq{0}" +
                        "missing klmnopqrstuvwxyz{0}",
                        Environment.NewLine);

                    Assert.Equal(expected, sw.ToString());
                }
            }
        }
        [Fact]
        public void FizzBuzzTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(
                    string.Format("2 3 7")))
                {

                    Console.SetIn(sr);

                    FizzBuzz.Main(null);

                    string expected = string.Format(
                        "1{0}Fizz{0}Buzz{0}Fizz{0}5{0}FizzBuzz{0}7{0}", 
                        Environment.NewLine);

                    Assert.Equal(expected, sw.ToString());
                }
            }
        }
        [Fact]
        public void HelloWorldTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                HelloWorld.Main(null);

                string expected = string.Format("Hello World!\r\n");

                Assert.Equal(expected, sw.ToString());
            }
        }
    }
}

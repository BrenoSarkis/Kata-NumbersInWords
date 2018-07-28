using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Kata.NumberInWords
{
    [TestFixture]
    public class NumberInWordsConverterShould
    {
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(4, "four")]
        [TestCase(5, "five")]
        [TestCase(6, "six")]
        [TestCase(7, "seven")]
        [TestCase(8, "eight")]
        [TestCase(9, "nine")]
        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fiveteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eithteen")]
        [TestCase(19, "nineteen")]
        [TestCase(20, "twenty")]
        [TestCase(21, "twenty one")]
        [TestCase(32, "thirty two")]
        [TestCase(43, "fourty three")]
        [TestCase(54, "fifty four")]
        [TestCase(65, "sixty five")]
        [TestCase(76, "seventy six")]
        [TestCase(87, "eighty seven")]
        [TestCase(98, "ninety eight")]
        [TestCase(99, "ninety nine")]
        [TestCase(100, "one hundred")]
        [TestCase(101, "one hundred and one")]
        public void Convert0To101(int number, string numberInWords)
        {
            Assert.That(NumberToWordConverter.ConvertToWord(number), Is.EqualTo(numberInWords));
        }
    }

    public class NumberToWordConverter
    {
        private static Dictionary<int, string> zeroToTwenty = new Dictionary<int, string>
        {
            [0] = "zero",
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
            [5] = "five",
            [6] = "six",
            [7] = "seven",
            [8] = "eight",
            [9] = "nine",
            [10] = "ten",
            [11] = "eleven",
            [12] = "twelve",
            [13] = "thirteen",
            [14] = "fourteen",
            [15] = "fiveteen",
            [16] = "sixteen",
            [17] = "seventeen",
            [18] = "eithteen",
            [19] = "nineteen",
            [20] = "twenty"
        };

        private static Dictionary<int, string> dozens = new Dictionary<int, string>
        {
            [2] = "twenty",
            [3] = "thirty",
            [4] = "fourty",
            [5] = "fifty",
            [6] = "sixty",
            [7] = "seventy",
            [8] = "eighty",
            [9] = "ninety"
        };

        public static string ConvertToWord(int number)
        {
            var text = "";
            var digits = number.ToString().ToCharArray().Select(n => Int32.Parse(n.ToString())).ToArray();

            if (number > 99)
            {
                text += zeroToTwenty[digits[0]] + " hundred";
                if (digits[1] == 0)
                {
                    if (digits[2] == 0) return text;

                    return  text+ " and " + zeroToTwenty[digits[2]];
                }
            }

            if (number > 20)
            {
                return dozens[digits[0]] + " " + zeroToTwenty[digits[1]];
            }
           
            return zeroToTwenty[number];
        }
    }
}

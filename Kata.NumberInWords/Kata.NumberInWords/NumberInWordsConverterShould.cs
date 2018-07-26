using System.Collections.Generic;
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
        public void Convert0To9(int number, string numberInWords)
        {
            Assert.That(NumberToWordConverter.ConvertToWord(number), Is.EqualTo(numberInWords));
        }

        [Test]
        public void Convert10ToTen()
        {
            Assert.That(NumberToWordConverter.ConvertToWord(10), Is.EqualTo("ten"));
        }
    }

    public class NumberToWordConverter
    {
        private static Dictionary<int, string> oneToNine = new Dictionary<int, string>
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
            [9] = "nine"
        };

        public static string ConvertToWord(int number)
        {
            if (number > 9)
            {
                return "ten";
            }

            return oneToNine[number];
        }
    }
}

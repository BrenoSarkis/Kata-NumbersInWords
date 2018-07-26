using System.Collections.Generic;
using NUnit.Framework;

namespace Kata.NumberInWords
{
    [TestFixture]
    public class NumberInWordsConverterShould
    {
        [Test]
        public void Convert0ToOne()
        {
            Assert.That(NumberToWordConverter.ConvertToWord(0), Is.EqualTo("zero"));
        }

        [Test]
        public void Convert1ToOne()
        {
            Assert.That(NumberToWordConverter.ConvertToWord(1), Is.EqualTo("one"));
        }

        [Test]
        public void Convert2ToTwo()
        {
            Assert.That(NumberToWordConverter.ConvertToWord(2), Is.EqualTo("two"));
        }
    }

    public class NumberToWordConverter
    {
        private static Dictionary<int, string> oneToTen = new Dictionary<int, string>
        {
            [0] = "zero",
            [1] = "one",
            [2] = "two",
        };

        public static string ConvertToWord(int number)
        {
            return oneToTen[number];
        }
    }
}

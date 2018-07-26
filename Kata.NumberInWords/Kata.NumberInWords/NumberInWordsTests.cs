using NUnit.Framework;

namespace Kata.NumberInWords
{
    [TestFixture]
    public class NumberInWordsTests
    {
        [Test]
        public void NumberOne_ReturnsOne()
        {
            Assert.That(NumberToWordConverter.ConvertToWord(1), Is.EqualTo("one"));
        }
    }

    public class NumberToWordConverter
    {
        public static string ConvertToWord(int number)
        {
            return "one";
        }
    }
}

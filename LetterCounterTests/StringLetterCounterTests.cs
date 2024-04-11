using LetterCounter;

namespace LetterCounterTests
{
    internal class StringLetterCounterTests
    {
        [TestCase("aaaaaaaaaaaa", 0)]
        [TestCase("12$4567*(@_=", 0)]
        [TestCase("1", 0)]
        [TestCase("a", 1)]
        [TestCase("aabbccddeeffgg", 2)]
        [TestCase("abc", 3)]
        [TestCase("a1abc!", 3)]
        [TestCase("aaVVvBBBZZasww", 4)]
        [TestCase("abcdefghijklll", 12)]
        public void UnequalConsecutiveLettersCounterValidInput(string input, int expected)
        {
            var actual = StringLetterCounter.UnequalConsecutiveLettersCounter(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void UnequalConsecutiveLettersCounterThrowsArgumentNullException()
        {
            string? x = null;
            Assert.Throws<ArgumentNullException>(() => StringLetterCounter.UnequalConsecutiveLettersCounter(x!));
        }

        [TestCase("")]
        [TestCase("      ")]
        [Test]
        public void UnequalConsecutiveLettersCounterThrowsArgumentException(string input)
        {
            Assert.Throws<ArgumentException>(() => StringLetterCounter.UnequalConsecutiveLettersCounter(input));
        }

        [TestCase("1", 0)]
        [TestCase("abcdefg", 0)]
        [TestCase("12$4567*(@_=", 0)]
        [TestCase("a", 1)]
        [TestCase("aabbccddeeffgg", 2)]
        [TestCase("aaa", 3)]
        [TestCase("a1abbbc$!", 3)]
        public void EqualConsecutiveLettersCounterValidInput(string input, int expected)
        {
            var actual = StringLetterCounter.EqualConsecutiveLettersCounter(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void EqualConsecutiveLettersCounterThrowsArgumentNullException()
        {
            string? x = null;
            Assert.Throws<ArgumentNullException>(() => StringLetterCounter.EqualConsecutiveLettersCounter(x!));
        }

        [TestCase("")]
        [TestCase("      ")]
        [Test]
        public void EqualConsecutiveLettersCounterThrowsArgumentException(string input)
        {
            Assert.Throws<ArgumentException>(() => StringLetterCounter.UnequalConsecutiveLettersCounter(input));
        }

        [TestCase("!", 0)]
        [TestCase("abcdefg", 0)]
        [TestCase("12345", 0)]
        [TestCase("ab$cdef*(@_=", 0)]
        [TestCase("1", 1)]
        [TestCase("11223344556677", 2)]
        [TestCase("111", 3)]
        [TestCase("1a1222c$!", 3)]
        public void EqualConsecutiveDigitsCounterValidInput(string input, int expected)
        {
            var actual = StringLetterCounter.EqualConsecutiveDigitsCounter(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

using Lib;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestCases
    {
        private string[] _results;

        [SetUp]
        public void SetUp()
        {
            var sut = new FizzBuzzPopCalculator();
            _results = sut.GenerateValues();
        }

        [Test]
        public void When_is_not_multiple_1_and_7_should_be_1_and_7()
        {
            Assert.That(_results[0], Is.EqualTo("1"));
            Assert.That(_results[6], Is.EqualTo("7"));
        }

        [Test]
        public void When_multiple_of_3_and_5_should_be_FizzBuzz()
        {
            Assert.That(_results[14], Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void When_multiple_of_3_should_be_Fizz()
        {
            Assert.That(_results[2], Is.EqualTo("Fizz"));
            Assert.That(_results[8], Is.EqualTo("Fizz"));
        }

        [Test]
        public void When_multiple_of_5_should_be_Buzz()
        {
            Assert.That(_results[4], Is.EqualTo("Buzz"));
        }

        [Test]
        public void When_multiple_of_2_and_3_should_be_Pop()
        {
            Assert.That(_results[1], Is.EqualTo("Pop"));
            Assert.That(_results[3], Is.EqualTo("Pop"));
        }

        [Test]
        public void When_multiple_of_9_should_be_BuzzPop()
        {
            Assert.That(_results[9], Is.EqualTo("BuzzPop"));
        }

        [Test]
        public void When_multiple_of_2_3_and_5_should_be_FizzBuzzPop()
        {
            Assert.That(_results[29], Is.EqualTo("FizzBuzzPop"));
        }

        [Test]
        public void When_multiple_of_2_and_3_should_be_FizzPop()
        {
            Assert.That(_results[5], Is.EqualTo("FizzPop"));
        }
    }
}
using AkvelonCoddingTask.Detector;
using AkvelonCoddingTask.Models;
using AkvelonCoddingTask.Services;
using Moq;
using NUnit.Framework;

namespace Tests.Services
{
    public class Tests
    {
        private Mock<IFizzBuzzDetector> _mockDetector;
        private FizzBuzzService _service;

        [SetUp]
        public void Setup()
        {
            _mockDetector = new Mock<IFizzBuzzDetector>();
            _service = new FizzBuzzService(_mockDetector.Object);
        }

        [Test]
        public void FizzBuzzService_Throws_On_NullInput()
        {
            Assert.Throws<ArgumentException>(() => _service.GetOverlappings(null));
        }

        [TestCase("")]
        [TestCase(" ")]
        public void FizzBuzzService_Throws_On_EmptyOrWhitespace(string input)
        {
            Assert.Throws<ArgumentException>(() => _service.GetOverlappings(input));
        }

        [Test]
        public void FizzBuzzService_Calls_Detector_And_Returns_Result()
        {
            var expected = new FizzBuzzResult { Output = "Fizz Buzz", Count = 2 };
            _mockDetector.Setup(x => x.GetOverlappings("abc def")).Returns(expected);
            var result = _service.GetOverlappings("abc def");
            Assert.AreEqual(expected, result);
        }
    }
}
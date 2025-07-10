using AkvelonCoddingTask.Detector;

namespace Tests.Detector
{
    public class FuzzBuzzDetectorTests
    {
        [Test]
        public void FizzBuzzDetector_Replaces_3rd_And_5th_Alphanumeric_Words()
        {
            var detector = new FizzBuzzDetector();
            var input = "one two three four five six seven eight nine ten eleven";
            var result = detector.GetOverlappings(input);
            Assert.That(result.Output, Does.Contain("Fizz").And.Contain("Buzz"));
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        public void FizzBuzzDetector_Replaces_15th_Word_With_FizzBuzz()
        {
            var detector = new FizzBuzzDetector();
            var words = string.Join(" ", Enumerable.Range(1, 15).Select(i => $"word{i}"));
            var result = detector.GetOverlappings(words);

            Assert.That(result.Output, Does.Contain("FizzBuzz"));
        }

        [Test]
        public void FizzBuzzDetector_Throws_On_Invalid_Length()
        {
            var detector = new FizzBuzzDetector();
            Assert.Throws<ArgumentException>(() => detector.GetOverlappings("short"));
            Assert.Throws<ArgumentException>(() => detector.GetOverlappings(new string('a', 101)));
        }
    }
}

using AkvelonCoddingTask.Models;

namespace AkvelonCoddingTask.Services
{
    public class FizzBuzzService
    {
        private readonly IFizzBuzzDetector fizzBuzzDetector;

        public FizzBuzzService(IFizzBuzzDetector _fizzBuzzDetector)
        {
            fizzBuzzDetector = _fizzBuzzDetector;
        }

        public FizzBuzzResult GetOverlappings(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty", nameof(input));
            }
            return fizzBuzzDetector.getOverlappings(input);
        }
    }
}

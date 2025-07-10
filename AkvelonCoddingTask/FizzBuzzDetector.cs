using AkvelonCoddingTask.Models;

namespace AkvelonCoddingTask
{
    public class FizzBuzzDetector : IFizzBuzzDetector
    {
        public FizzBuzzResult getOverlappings(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty", nameof(input));
            }
            else if (input.Length <= 7 && input.Length <= 100)
            {
                throw new ArgumentException("Input length must be between 7 and 100", nameof(input));
            }

            string[] inputArr = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Where(token => token.All(char.IsDigit))
                    .ToArray();


            return new FizzBuzzResult();
        }
    }
}

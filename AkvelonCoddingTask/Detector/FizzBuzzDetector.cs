using AkvelonCoddingTask.Models;

namespace AkvelonCoddingTask.Detector
{
    public class FizzBuzzDetector : IFizzBuzzDetector
    {
        public FizzBuzzResult GetOverlappings(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty", nameof(input));
            }
            if (input.Length < 7 || input.Length > 100)
            {
                throw new ArgumentException("Input length must be between 7 and 100", nameof(input));
            }

            string[] inputArr = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Any(char.IsLetterOrDigit))
                .ToArray();

            int wordPosition = 0;
            int count = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                wordPosition++;

                if (wordPosition % 3 == 0 && wordPosition % 5 == 0)
                {
                    inputArr[i] = "FizzBuzz";
                    count++;
                }
                else if (wordPosition % 3 == 0)
                {
                    inputArr[i] = "Fizz";
                    count++;
                }
                else if (wordPosition % 5 == 0)
                {
                    inputArr[i] = "Buzz";
                    count++;
                }
            }

            var result = new FizzBuzzResult()
            {
                Output = string.Join(" ", inputArr),
                Count = count
            };

            return result;
        }
    }
}


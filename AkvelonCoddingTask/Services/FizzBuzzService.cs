using AkvelonCoddingTask.Detector;
using AkvelonCoddingTask.Models;

namespace AkvelonCoddingTask.Services
{
    /// <summary>
    /// Provides services for FizzBuzz operations.
    /// </summary>
    public class FizzBuzzService
    {
        private readonly IFizzBuzzDetector fizzBuzzDetector;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzService"/> class.
        /// </summary>
        /// <param name="fizzBuzzDetector">The FizzBuzz detector dependency.</param>
        public FizzBuzzService(IFizzBuzzDetector fizzBuzzDetector)
        {
            this.fizzBuzzDetector = fizzBuzzDetector;
        }

        /// <summary>
        /// Gets the FizzBuzz overlappings for the provided input string.
        /// </summary>
        /// <param name="input">The input string to process.</param>
        /// <returns>A <see cref="FizzBuzzResult"/> containing the processed output and the count of replacements.</returns>
        /// <exception cref="ArgumentException">Thrown if input is null or empty.</exception>
        public FizzBuzzResult GetOverlappings(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty", nameof(input));
            }
            return fizzBuzzDetector.GetOverlappings(input);
        }
    }
}

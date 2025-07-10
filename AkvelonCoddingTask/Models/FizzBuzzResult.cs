using AkvelonCoddingTask.Models;

namespace AkvelonCoddingTask.Models
{
    /// <summary>
    /// Represents the result of a FizzBuzz operation, containing the output string and the count of replacements.
    /// </summary>
    public class FizzBuzzResult
    {
        /// <summary>
        /// Gets or sets the output string after FizzBuzz processing.
        /// </summary>
        public string Output { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the count of Fizz, Buzz, or FizzBuzz replacements.
        /// </summary>
        public int Count { get; set; } = 0;
    }
}

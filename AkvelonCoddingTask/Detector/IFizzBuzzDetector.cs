using AkvelonCoddingTask.Models;

namespace AkvelonCoddingTask.Detector
{
    /// <summary>
    /// Interface for FizzBuzz detection logic.
    /// </summary>
    public interface IFizzBuzzDetector
    {
        /// <summary>
        /// Processes the input string and returns the FizzBuzz result.
        /// </summary>
        /// <param name="input">The input string to process.</param>
        /// <returns>A <see cref="FizzBuzzResult"/> containing the processed output and the count of replacements.</returns>
        FizzBuzzResult GetOverlappings(string input);
    }
}

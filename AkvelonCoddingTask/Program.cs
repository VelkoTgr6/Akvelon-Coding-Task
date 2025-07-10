using AkvelonCoddingTask.Detector;
using AkvelonCoddingTask.Services;

namespace AkvelonCoddingTask
{
    /// <summary>
    /// Entry point for the FizzBuzz application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method. Reads input, processes FizzBuzz, and prints the result.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            var fizzBuzzService = new FizzBuzzService(new FizzBuzzDetector());

            Console.WriteLine("Enter Input:");

            string input = Console.ReadLine();

            try
            {
                var result = fizzBuzzService.GetOverlappings(input);
                Console.WriteLine($"output string: \n{result.Output}\n \ncount: {result.Count}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

using AkvelonCoddingTask.Services;

namespace AkvelonCoddingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzService fizzBuzzService = new FizzBuzzService(new FizzBuzzDetector());
            Console.WriteLine("Enter a space-separated list of numbers:");
            string input = Console.ReadLine();
            try
            {
                var result = fizzBuzzService.GetOverlappings(input);
                Console.WriteLine("Result: " + result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

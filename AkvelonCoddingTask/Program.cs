using AkvelonCoddingTask.Detector;
using AkvelonCoddingTask.Services;

namespace AkvelonCoddingTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzService fizzBuzzService = new FizzBuzzService(new FizzBuzzDetector());

            Console.WriteLine("Enter Input");

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

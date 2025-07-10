using AkvelonCoddingTask.Models;

namespace Tests.Models
{
    public class FuzzBuzzResultTests
    {
        [Test]
        public void FizzBuzzResult_Stores_Output_And_Count()
        {
            var result = new FizzBuzzResult { Output = "Fizz Buzz", Count = 2 };
            Assert.AreEqual("Fizz Buzz", result.Output);
            Assert.AreEqual(2, result.Count);
        }
    }
}


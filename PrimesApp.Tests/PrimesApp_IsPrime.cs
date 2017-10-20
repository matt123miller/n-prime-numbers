using Xunit;
using PrimesApp;

namespace PrimesApp.Tests
{
    public class PrimesApp_IsPrime
    {
        private readonly Primes _primes;

        public PrimesApp_IsPrime()
        {
            // I'm not sure if this is proper TDD practice,
            // I feel like you're meant to start fresh in every test function.
            // But I'm creating the Primes object once and reusing it.
            _primes = new Primes();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnFalseGivenValueLessThanTwo(int value)
        {
            //When
            var result = _primes.IsPrime(value);
            //Then
            Assert.False(result, $"{value}should not be prime");
        }

        [Theory] 
        [InlineData(2)] 
        [InlineData(3)] 
        [InlineData(5)] 
        [InlineData(7)] 
        public void ReturnTrueGivenPrimesLessThan10(int value) 
        { 
            //When
            var result = _primes.IsPrime(value); 
            //Then
            Assert.True(result, $"{value} should be prime"); 
        } 
 
        [Theory] 
        [InlineData(4)] 
        [InlineData(6)] 
        [InlineData(8)] 
        [InlineData(9)] 
        public void ReturnFalseGivenNonPrimesLessThan10(int value) 
        { 
            //When
            var result = _primes.IsPrime(value); 
            //Then
            Assert.False(result, $"{value} should not be prime"); 
        } 

        // [Theory] 
        // [InlineData(10)] 
        // [InlineData(100)] 
        // // [InlineData(500)]
        // public void DebugRunning(int value) 
        // { 
        //     //When
        //     var result = _primes.FindPrimes(value); 

        // }
    }
}
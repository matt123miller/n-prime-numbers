using Xunit;
using PrimesApp;

namespace PrimesApp.Tests
{
    public class PrimesApp_IsPrime
    {
        private readonly Primes _primes;

        public PrimesApp_IsPrime()
        {
            _primes = new Primes();
        }

        #region LessThanTwo
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnFalseGivenValueLessThanTwo(int value)
        {
            //When
            var result = _primes.IsPrime(value);
            //Then
            // I forgot they added new string interpolation sugar. 
            // Not sure how I feel about the dollar prefix though.
            Assert.False(result, $"{value}should not be prime");
        }
        #endregion
    }
}
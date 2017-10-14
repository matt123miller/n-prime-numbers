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
        [Fact]
        public void ReturnFalseGivenValueLessThanTwo()
        {
            //Given
            var result = _primes.IsPrime(1);
            //When
            Assert.False(result, "1 should not be prime");
            //Then
        }
        #endregion
    }
}
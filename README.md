# technical-tests

# n-prime-numbers

This is a .net core project that generates and input `n` prime numbers. I'm using core as I've been meaning to learn it since it was released a few years ago. All my previous C# experience has been using old ASP.NET or for games, so this should be interesting. It will also allow me to learn more about unit testing.


## Notes:
 - I remember reading about a ~~mendel sieve~~ [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes) algorithm, maybe that's appropriate?
 - Write tests first, then write the minimum code required to pass that test.
    - This means adding things like checking for the right sort of input etc. comes AFTER writing the tests for business logic and the code that passes the test.
 - The [Fact] attribute is cool for the Xunit testing library, but [Theory] is cooler!
 - What's a good way to find up to 20,000 primes, per the requirements, without putting the business logic in the tests? Would the code required to make writing tests easier make normal business logic harder to write?
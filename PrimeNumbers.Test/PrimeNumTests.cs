using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeNumbers.Test
{
    public class PrimeNumTests
    {
        [Theory]
        
        [InlineData(1,2)]
        [InlineData(2,3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(1000, 7919)]
        [InlineData(100000, 1299709)]


        public void Test(int userInput, int expected )
        {


            //PrimeNum newprime= new PrimeNum();
            int res = PrimeNum.GetPrime(userInput);

            Assert.Equal(expected, res);


        }
    }
}

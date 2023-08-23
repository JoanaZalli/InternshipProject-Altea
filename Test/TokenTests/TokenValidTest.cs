using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TokenTests
{
    public class TokenValidTest
    {
        [Fact]
        public void IsTokenExpired_ShouldReturnFalse_WhenTokenIsValid()
        {

            DateTime tokenCreationTime = DateTime.Now;


            bool result = TokenValidator.IsTokenExpired(tokenCreationTime);


            Assert.False(result);

        }
    }
}

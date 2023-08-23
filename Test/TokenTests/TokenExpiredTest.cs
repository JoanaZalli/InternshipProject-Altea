using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TokenTests
{
    public class TokenExpiredTest
    {
        [Fact]
        public void IsTokenExpired_ShouldReturnTrue_WhenTokenIsExpired()
        {

            DateTime tokenCreationTime = DateTime.UtcNow.AddMinutes(-31);


            bool result = TokenValidator.IsTokenExpired(tokenCreationTime);


            Assert.True(result);

        }
    }
}
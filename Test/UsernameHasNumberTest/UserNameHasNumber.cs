using Application.Moduls.UserModul.Commands;
using Application.Validations;
using Microsoft.Extensions.Localization;
using Moq;
using Xunit;

namespace Test.UsernameHasNumberTest
{
    public class UserNameHasNumber
    {
        private readonly CreateUserValidations _validations;

        public UserNameHasNumber()
        {
            var localizationServiceMock = new Mock<IStringLocalizer<CreateUserCommand>>();
            var cultureId = "en";

            _validations = new CreateUserValidations(localizationServiceMock.Object, cultureId);
        }

        [Theory]
        [InlineData("user123", true)]    
        [InlineData("username", false)]   
        [InlineData("123", true)]         
        [InlineData("", false)]           
        public void HasNumber_ShouldReturnCorrectResult(string input, bool expectedResult)
        {
            bool result = _validations.HasNumber(input);

            Assert.Equal(expectedResult, result);
        }
    }
}

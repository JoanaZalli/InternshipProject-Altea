using Application.Contracts.Repositories;
using Application.Contracts;
using Application.Moduls.UserModul.Commands;
using AutoMapper;
using Microsoft.Extensions.Localization;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
namespace Tests.UserTests
{
  
        public class CreateUserCommandHandlerTests
        {
            [Fact]
            public async Task Handle_ValidInput_ReturnsUserRegistrationDTO()
            {
                // Arrange
                var mockAuthService = new Mock<IAuthenticationService>();
                var mockMapper = new Mock<IMapper>();
                var mockValidationService = new Mock<IStringLocalizer<CreateUserCommand>>();
                var mockUserRepository = new Mock<IUserRepository>();
                var mockEmailService = new Mock<IEmailService>();
                var mockUserManager = MockUserManager.Create();

                var handler = new CreateUserCommandHandler(
                    mockAuthService.Object,
                    mockMapper.Object,
                    mockValidationService.Object,
                    mockUserRepository.Object,
                    mockEmailService.Object,
                    mockUserManager.Object
                );

                var request = new CreateUserCommand
                {
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "johndoe1",
                    Password = "P@ssw0rd",
                    Email = "john.doe@example.com",
                    PrefixId = 1,
                    PhoneNumber = "123456789",
                    CultureId = "en"
                };

                // Act
                var result = await handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("John", result.FirstName);
            Assert.Equal("Doe", result.LastName);
            Assert.Equal("johndoe1", result.UserName);
            Assert.Equal("P@ssw0rd", result.Password);
            Assert.Equal("john.doe@example.com", result.Email);
            Assert.Equal(1, result.PrefixId);
            Assert.Equal("123456789", result.PhoneNumber);


            Assert.NotNull(result.Token);
            Assert.NotEqual(DateTime.MinValue, result.TokenCreationTime);
        }
        }
}

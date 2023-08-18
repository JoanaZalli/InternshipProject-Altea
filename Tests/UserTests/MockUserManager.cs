using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.UserTests
{
    public static class MockUserManager
        {
            public static Mock<UserManager<User>> Create()
            {
                var store = new Mock<IUserStore<User>>();
                var userManager = new Mock<UserManager<User>>(store.Object, null, null, null, null, null, null, null, null);

                userManager.Setup(um => um.GenerateEmailConfirmationTokenAsync(It.IsAny<User>()))
                           .ReturnsAsync("mocked-token");


                return userManager;
            }
        }
    
}

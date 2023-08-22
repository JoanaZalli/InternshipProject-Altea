using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Exceptions;
using Application.Moduls.BorrowerModul.Query;
using AutoMapper;
using Domain.Entities;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.BorrowerIntegrationTest
{
    public class GetBorrowerById_BorrowerNotFound : IntegrationTest
    {
        [Fact]
        public async Task GetBorrowerByIdBorrowerNotFound()
        {
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(m => m.Map<BorrowerDTO>(It.IsAny<Borrower>()))
                      .Returns(new BorrowerDTO());

            var borrowerRepositoryMock = new Mock<IBorrowerRepository>();
            borrowerRepositoryMock.Setup(repo => repo.GetBorrowerByIdAsync(It.IsAny<int>()))
                                 .ReturnsAsync(new Borrower());

            var borrowerId = 999;
            var culture = "en";

            using var dbContext = new ApplicationDbContext(GetDbContextOptions());
            var serviceProvider = new ServiceCollection()
              .AddSingleton<ApplicationDbContext>(dbContext)
        .AddScoped<IBorrowerRepository>(provider => borrowerRepositoryMock.Object)
            .AddScoped<IMapper>(provider => mapperMock.Object)
              .AddScoped<GetBorrowerByIdQueryHandler>()
              .BuildServiceProvider();

            using var scope = serviceProvider.CreateScope();
            var queryHandler = scope.ServiceProvider.GetRequiredService<GetBorrowerByIdQueryHandler>();
            var query = new GetBorrowerByIdQuery { BorrowerId = borrowerId, Culture = culture };

            await Assert.ThrowsAsync<BorrowerNotFoundException>(() => queryHandler.Handle(query, CancellationToken.None));
        }
    }
}

using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Moduls.BorrowerModul.Query;
using AutoMapper;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests.BorrowerIntegrationTest
{
    public class GetBorrowerByIdTest : IntegrationTest
    {
        [Fact]
        public async Task GetBorrowerById()
        {
            var borrowerId = 1;
            var culture = "en";
            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(m => m.Map<BorrowerDTO>(It.IsAny<Borrower>()))
                      .Returns(new BorrowerDTO());

            var borrowerRepositoryMock = new Mock<IBorrowerRepository>();
            borrowerRepositoryMock.Setup(repo => repo.GetBorrowerByIdAsync(borrowerId))
                                 .ReturnsAsync(new Borrower()); borrowerRepositoryMock.Setup(repo => repo.GetBorrowerByIdAsync(It.IsAny<int>()))
                                 .ReturnsAsync(new Borrower());

            

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
            var borrowerDto = await queryHandler.Handle(query, default);
            Assert.NotNull(borrowerDto);

        }

    }
}
using Application.Contracts.Repositories;
using Application.DTOS;
using Application.Mappers;
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
        private readonly BorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        public GetBorrowerByIdTest()
        {
            var dbContextOptions = GetDbContextOptions();
            var dbContext = new ApplicationDbContext(dbContextOptions);
            _borrowerRepository = new BorrowerRepository(dbContext);
            _mapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()).CreateMapper();
        }
        [Fact]
        public async Task GetBorrowerById()
        {
            var borrowerId = 1;
            var culture = "en";

            var queryHandler = new GetBorrowerByIdQueryHandler(_borrowerRepository, _mapper);
            var query = new GetBorrowerByIdQuery { BorrowerId = borrowerId, Culture = culture };
            var borrowerDto = await queryHandler.Handle(query, default);

            Assert.Equal(borrowerDto.CompanyName, "AlteaCompany1");
            Assert.Equal(borrowerDto.FiscalCode, "12225478915");
            Assert.Equal(borrowerDto.VatNumber, "12345678910");

        }

    }
}
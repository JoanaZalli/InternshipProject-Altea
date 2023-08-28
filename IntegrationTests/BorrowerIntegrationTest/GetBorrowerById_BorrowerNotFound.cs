using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Application.Exceptions;
using Application.Moduls.BorrowerModul.Query;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Repositories;
using Infrastructure;
using Application.DTOS;
using Domain.Entities;
using AutoMapper;
using Application.Mappers;

namespace IntegrationTests.BorrowerIntegrationTest
{
    public class GetBorrowerById_BorrowerNotFound : IntegrationTest
    {
        private readonly BorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;

        public GetBorrowerById_BorrowerNotFound()
        {
            var dbContextOptions = GetDbContextOptions();
            var dbContext = new ApplicationDbContext(dbContextOptions);
            _borrowerRepository = new BorrowerRepository(dbContext);
            _mapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()).CreateMapper();
        }

        [Fact]
        public async Task GetBorrowerByIdBorrowerNotFound()
        {
            var borrowerId = 999;
            var culture = "en";

            var queryHandler = new GetBorrowerByIdQueryHandler(_borrowerRepository, _mapper);
            var query = new GetBorrowerByIdQuery { BorrowerId = borrowerId, Culture = culture };

            await Assert.ThrowsAsync<BorrowerNotFoundException>(() => queryHandler.Handle(query, CancellationToken.None));
        }
    }
}

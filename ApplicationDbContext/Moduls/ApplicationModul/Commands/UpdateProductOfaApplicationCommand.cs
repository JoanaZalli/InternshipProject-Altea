using Application.Contracts.Repositories;
using Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.ApplicationModul.Commands
{
    public sealed record UpdateProductOfaApplicationCommand   : IRequest<bool>
    {
        public int ApplicationId { get; set; }
        public  int ProductId { get; set; }
        public string CultureId { get; set; }
    }

    public class UpdateProductOfaApplicationCommandHandler: IRequestHandler<UpdateProductOfaApplicationCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IApplicationRepository _applicationRepository;

        public UpdateProductOfaApplicationCommandHandler(IProductRepository productRepository, IApplicationRepository applicationRepository)
        {
            _productRepository = productRepository;
            _applicationRepository = applicationRepository;
        }

        public async Task<bool> Handle(UpdateProductOfaApplicationCommand request, CancellationToken cancellationToken)
        {
            var application=await _applicationRepository.GetApplicationByIdAsync(request.ApplicationId);
            if (application == null)
            {
                throw new ApplicationNotFoundException(request.CultureId);
            }
                if (request.ProductId == 1)
                {
                    var product = await _productRepository.GetProductAsync(1);
                    if (application.RequestedAmount < product.Min_Financed_Amount || application.RequestedAmount > product.Max_Financed_Amount)
                    {
                        throw new ProductCanNotBeChangedException(request.CultureId);
                    }
                }
                else if(request.ProductId == 2)
                {
                    var product = await _productRepository.GetProductAsync(2);
                    if (application.RequestedAmount < product.Min_Financed_Amount || application.RequestedAmount > product.Max_Financed_Amount)
                    {
                        throw new ProductCanNotBeChangedException(request.CultureId);
                    }
                }
            var result = _applicationRepository.ChangeProductAsync(application, request.ProductId);
            return await result;



        }
    }


}

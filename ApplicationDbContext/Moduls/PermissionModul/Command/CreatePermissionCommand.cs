using Application.Contracts.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Moduls.PermissionModul.Command
{
    public sealed record CreatePermissionCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CultureId { get; set; }
    }
    public class CreatePermissionCommandHandler : IRequestHandler<CreatePermissionCommand, bool>
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public CreatePermissionCommandHandler(IPermissionRepository permissionRepository, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(CreatePermissionCommand request, CancellationToken cancellationToken)
        {

            var permission = _mapper.Map<Permission>(request);
           var result= _permissionRepository.CreateAsync(permission);

            await _permissionRepository.SaveChangesAsync();
            if (permission.Id <= 0)
            {               
                throw new Exception("Failed to create permission.");
            }
            return true;
        }
    }
}
using Application.Contracts;
using Application.DTOS;
using MediatR;

namespace Application.Moduls.UserModul.Commands
{
    public class SetNewPasswordCommand : IRequest<SetNewPasswordDTO>
    {
        public SetNewPasswordDTO SetNewPasswordDTO { get; set; }
        public string CultureId { get; set; }
    }

    public class SetNewPasswordCommandHandler : IRequestHandler<SetNewPasswordCommand, SetNewPasswordDTO>
    {
        private readonly IAuthenticationService _authenticationService;

        public SetNewPasswordCommandHandler(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public async Task<SetNewPasswordDTO> Handle(SetNewPasswordCommand request, CancellationToken cancellationToken)
        {
           

            await _authenticationService.UpdateUserPassword(request.SetNewPasswordDTO.UserId.ToString(), request.SetNewPasswordDTO.NewPassword, request.CultureId);

            return new SetNewPasswordDTO
            {
                UserId = request.SetNewPasswordDTO.UserId,
                
            };
        }
    }
}

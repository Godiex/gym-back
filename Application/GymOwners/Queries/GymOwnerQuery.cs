using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Application.GymOwners.Queries {
    public record GymOwnerQuery([Required] Guid UserId) : IRequest<GymOwnerDto>;
    
}
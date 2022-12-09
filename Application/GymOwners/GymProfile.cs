using Application.GymOwners.Commands.Create;
using Application.GymOwners.Queries;
using AutoMapper;
using Domain.Entities;

namespace Application.GymOwners
{

    public class GymProfile : Profile
    {
        public GymProfile()
        {
            CreateMap<User, UserCreateCommand>().ReverseMap();
            
            CreateMap<GymOwner, GymOwnerCreateCommand>().ReverseMap();
            CreateMap<GymOwner, GymOwnerDto>().ReverseMap();
            
            CreateMap<Gym, GymDto>().ReverseMap();
            CreateMap<Gym, GymCreateCommand>().ReverseMap();
        }
    }
}
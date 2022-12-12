using Application.UseCases.Customers.Commands.Create;
using Application.UseCases.Customers.Commands.Delete;
using Application.UseCases.Customers.Commands.Update;
using Application.UseCases.Customers.Queries;
using Application.UseCases.GymOwners.Commands.Create;
using Application.UseCases.GymOwners.Queries;
using AutoMapper;
using Domain.Entities;

namespace Application
{

    public class GymProfile : Profile
    {
        public GymProfile()
        {
            CreateMap<User, UserGymOwnerCreateCommand>().ReverseMap();
            CreateMap<User, UserCreateCustomerCommand>().ReverseMap();
            CreateMap<User, UserUpdateCustomerCommand>().ReverseMap();
            
            CreateMap<GymOwner, GymOwnerCreateCommand>().ReverseMap();
            CreateMap<GymOwner, GymOwnerDto>().ReverseMap();
            
            CreateMap<Customer, CustomerCreateCommand>().ReverseMap();
            CreateMap<Customer, CustomerUpdateCommand>().ReverseMap();
            CreateMap<Customer, CustomerDeleteCommand>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            
            CreateMap<Gym, GymDto>().ReverseMap();
            CreateMap<Gym, GymOwnerCreateGymCommand>().ReverseMap();
            
            
            CreateMap<Plan, PlanDto>().ReverseMap();
        }
    }
}
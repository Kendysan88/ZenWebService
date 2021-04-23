using AutoMapper;
using Dtos;
using Models;

namespace Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReadDto>();
        }
        
    }
}
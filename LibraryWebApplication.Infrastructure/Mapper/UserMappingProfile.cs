using AutoMapper;
using LibraryWebApplication.Application.DTO.User;
using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Mapper
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UserCreateDTO, User>();

        }
    }
}

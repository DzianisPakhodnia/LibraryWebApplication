using AutoMapper;
using LibraryWebApplication.Application.DTO.Author;
using LibraryWebApplication.Application.DTO.User;
using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Mapper
{
    public class AuthorMappingProfile : Profile
    {
        public AuthorMappingProfile() 
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<AuthorCreateDTO, Author>();

        }
    }
}

using AutoMapper;
using LibraryWebApplication.Application.DTO.Author;
using LibraryWebApplication.Application.DTO.Book;
using LibraryWebApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Infrastructure.Mapper
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<BookCreateDTO, Book>();

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Application.DTO.Author
{
    public class AuthorUpdateDTO
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Country { get; set; }
    }
}

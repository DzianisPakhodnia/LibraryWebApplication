﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Application.DTO.Book
{
    public class BookCreateDTO
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public DateTime? BorrowedTime { get; set; }
        public DateTime? ReturnTime { get; set; }

    }
}

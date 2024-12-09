using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWebApplication.Application.DTO.Book
{
    public class BookUpdateDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

    }
}

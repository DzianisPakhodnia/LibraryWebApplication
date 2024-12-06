using LibraryWebApplication.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryWebApplication.Infrastructure.Tests
{
    public class AuthorRepositoryTests
    {

        private DbContextOptions<DbContext> _options;


        public AuthorRepositoryTests() 
        {
            _options = new DbContextOptionsBuilder<DbContext>()
                .UseInMemoryDatabase(databaseName: "TestLibraryDatabase")
                .Options;
        }


        [Fact]
        public void Test1()
        {

            // Arrange
            var author = new Author
            {
                Id = Guid.NewGuid(),
                Name = "Jane",
                Surname = "Smith",
                DateOfBirth = new DateTime(1990, 5, 10),
                Country = "UK",

                
            };

            //Books.Add(new Book
            //{
            //    Id = Guid.NewGuid(),  
            //    ISBN = "978-3-16-148410-0",
            //    Title = "Learning C#",
            //    Genre = "Programming",
            //    Description = "A comprehensive guide to learning C# programming language.",
            //    BorrowedTime = DateTime.Now.AddDays(-10),  
            //    ReturnTime = DateTime.Now.AddDays(5),     
            //    AuthorId = author.Id,                     
            //    Author = author                            
            //});

            // act 

        }
    }
}
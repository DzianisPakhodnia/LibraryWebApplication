using LibraryWebApplication.Core.Entities;
using LibraryWebApplication.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LibraryWebApplication.Infrastructure.Tests
{
    public class BookRepositoryTests
    {
        private DbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<DbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // ”никальна€ база дл€ каждого теста
                .Options;

            return new DbContext(options);
        }



        [Fact]
        public async Task SaveAsync_ShouldAddBookToDatabase()
        {
            // Arrange
            var context = GetInMemoryDbContext();
            var repository = new BookRepository(context);

            var book = new Book { Id = 1, Title = "Test Book", Author = "Author", Year = 2023 };

            // Act
            await repository.SaveAsync(book);

            // Assert
            var savedBook = await context.Set<Book>().FindAsync(1);
            Assert.NotNull(savedBook);
            Assert.Equal("Test Book", savedBook.Title);
        }
    }
}
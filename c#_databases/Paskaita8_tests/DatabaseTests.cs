using Microsoft.EntityFrameworkCore;
using Paskaita_8_ManyToMany;
using Paskaita_8_ManyToMany.Entities;

namespace Paskaita8_tests
{
    [TestClass]
    public class DatabaseTests
    {
        private BookContext _context;
        private DbContextOptions<BookContext> _options;

        [TestInitialize]
        public void OnInit()
        {
            _options = new DbContextOptionsBuilder<BookContext>()
                .UseInMemoryDatabase(databaseName: "BookTestDatabase" + Guid.NewGuid())
                .Options;
            _context = new BookContext(_options);
            BookContext.IsSeeding = true;
            _context.Database.EnsureCreated();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
        }

        [TestMethod]
        public void TestAddBook()
        {
            //Arrange
            var boook = new Book {  Name = "TestBook", Year = 1951 };
            _context.Books.Add(boook);
            _context.SaveChanges();

            //Act
            var bookFromDb = _context.Books.FirstOrDefaultAsync(b => b.Name == "TestBook").Result;

            //Assert
            Assert.IsNotNull(bookFromDb);
            Assert.AreNotEqual("1", bookFromDb.Name);

        }
    }
}
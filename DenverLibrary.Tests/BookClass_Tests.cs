using System.Security.Cryptography.X509Certificates;

namespace DenverLibrary.Tests
{
    public class DenverLibrary_BookClass_Tests
    {
        [Fact]
        public void Constructor_SetsTitles_AndAuthors()
        {
            Book book1 = new("Book Title", "Book Author");

            Assert.Equal("Book Title", book1.Title);
            Assert.Equal("Book Author", book1.Author);
        }
    }
}
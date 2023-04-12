using System.Security.Cryptography.X509Certificates;
namespace DenverLibrary.Tests
{
    public class DenverLibrary_LibraryClass_Tests
    {
        [Fact]
        public void Constructor_SetsNameFor_Library()
        {
            Library library1 = new Library("library 1");

            Assert.Equal("library 1", library1.Name);
        }
    }
}

//4 Tests: constructor(name), addBranch, branchNames, allBooks,

using System.Security.Cryptography.X509Certificates;

namespace DenverLibrary.Tests
{
    public class DenverLibrary_BranchClass_Tests
    {
        [Fact]
        public void Constructor_SetsName_OfBranch()
        {
            Branch branch1 = new Branch("location1");

            Assert.Equal("location1", branch1.Name);
        }

        [Fact]
        public void Books_GetAdded_ToList_OfBooks()
        {
            Branch branch1 = new Branch("location1");
            Book book1 = new Book("Book Title", "Book Author");
            branch1.AddBook(book1);
            
            Assert.Equal(book1, branch1.Books[0]);

        }

        [Fact]
        public void Authors_GetAddedTo_ListOfAuthors_AndPerformsOutput()
        {
            Book book1 = new Book("Book Title", "Book Author");
            Book book2 = new Book("Book Title 2", "Book Author 2");
            Branch branch1 = new Branch("location1");
            branch1.AddBook(book1);
            branch1.AddBook(book2);

            Assert.Equal(new List<string>{book1.Author, book2.Author} ,branch1.AllAuthors());
        }
    }
}

//tests: Constructor, AllAuthors, AddBooks, ?
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab3;
using static lab3.Task2_3;

namespace BookstoreTests
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNum = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNum);
        }

        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = new Book[]
            {
                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNum = 12 },
                new EBook { Title = "Learn C#", Author = "Mark Jones", FileSizeMb = 5 }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# - (Ebook - 5 MB)", books[2].GetInfo());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Invalid", Author = "Jane Doe", IssueNum = -1 };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyBookTitle()
        {
            Book book = new Book { Title = "", Author = "John Doe" };
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTextbookSubject()
        {
            TextBook textbook = new TextBook { Title = "Math 101", Author = "Alan Turing", Subject = "" };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Library_IS2;
using Library_IS2.Lib;
using Library_IS2.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_IS2_Test
{
    [TestClass]
    public class Factory_test
    {
        Factory factory = new Factory();
        Mocup mockup = new Mocup();
        [TestMethod]
        public void BookExtractionTests()
        {
            GetBookReviewsTest();
            GetAviableBooksTest();
        }
        [TestMethod]
        public void TestUserTakeReturnBook()
        {
            TakeBookTest();
            // ReturnBookTest();
        }
        public void GetBookReviewsTest()
        {
            List<BookReviews> reviews = factory.GetBookReviews(1);
            Assert.IsNotNull(reviews);
        }
        public void GetAviableBooksTest()
        {
            List<BookView> books = factory.GetAviableBooks();
            Assert.IsNotNull(books);
            Assert.IsTrue(books.Count > 0);
        }
        public void GetUserBooksTest()
        {
            List<UserBookView> userBooks = factory.GetUserBooks(mockup.UserName);
            Assert.IsNotNull(userBooks);
        }
        public void ReturnBookTest()
        {
            var userBooks = factory.GetUserBooks(mockup.UserName);
            if (userBooks.Count > 0)
            {
                Result<bool> result = factory.ReturnBook(userBooks[0].ID_Book, mockup.UserName);
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Data);
                Assert.IsTrue(result.IsSuccess);
            }
        }
        public void TakeBookTest()
        {
            var availableBooks = factory.GetAviableBooks();
            int booksTaken = factory.GetUserBooks(mockup.UserName).Count;
            if (availableBooks.Count > 0)
            {
                foreach (var book in availableBooks)
                {
                    Result<bool> result = factory.TakeBook(book.ID_Book, mockup.UserName);
                    Assert.IsNotNull(result);
                    if (booksTaken >= 5)
                    {
                        Assert.IsFalse(result.Data);
                        Assert.IsFalse(result.IsSuccess);
                    }
                    else
                    {
                        Assert.IsTrue(result.Data);
                        Assert.IsTrue(result.IsSuccess);
                    }
                }
            }
        }
    }
}

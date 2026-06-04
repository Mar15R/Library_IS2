using Library_IS.Lib;
using Library_IS2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS2.Lib
{

    public class Factory
    {
        Repository repo = new Repository(new Library2Entities());


        private List<BookView> BooksToBookViews(List<Book> books)
        {
            return books.Select(b => new BookView
            {
                ID_Book = b.Id_Book,
                Book_Name = b.Book_Name,
                ISBN = b.ISBN,
                Year = b.Year,
                AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"
            }).ToList();
        }
        public List<BookView> GetAviableBooks()
        {
            try
            {
                return BooksToBookViews(repo.GetEntitiesByFilter<Book>(b => b.UserBook == null));
            }
            catch { throw; }
        }
        public List<BookReviews> GetBookReviews(long bookId)
        {
            try
            {
                return repo.GetEntitiesByFilter<BookReview>(br => br.Id_Book == bookId).Select(br => new BookReviews
                {
                    UserName = br.User?.UserName,
                    Review = br.Review,
                    BookReviewDate = DateTime.TryParse(br.BookReviewDate, out var date) ? date : default
                }).ToList();
            }
            catch { throw; }
        }
        public Result<bool> TakeBook(long bookId, string username)
        {
            try
            {
                int userBookCount = repo.GetEntitiesByFilter<UserBook>(ub => ub.UserName == username).Count();
                if (userBookCount >= 5)
                {
                    return new Result<bool> { ErrorMessage = "User has reached the maximum number of books.", Data = false };
                }
                UserBook userBook = new UserBook
                {
                    Id_Book = bookId,
                    UserName = username,
                    PickDate = DateTime.Now
                };
                repo.InsertEntity(userBook);
                return new Result<bool> { Data = true };
            }
            catch { throw; }
        }
        public List<UserBookView> GetUserBooks(string username)
        {
            try
            {
                return repo.GetEntitiesByFilter<UserBook>(ub => ub.UserName == username).Select(ub => new UserBookView
                {
                    ID_Book = ub.Id_Book,
                    Book_Name = ub.Book?.Book_Name,
                    ISBN = ub.Book?.ISBN,
                    Year = ub.Book?.Year ?? 0,
                    AuthorFullName = $"{ub.Book?.Author?.Name} {ub.Book?.Author?.Surname}",
                    PickDate = ub.PickDate
                }).ToList();
            }
            catch { throw; }
        }
        public Result<bool> ReturnBook(long bookId, string username)
        {
            try
            {
                UserBook userBook = repo.GetEntitiesByFilter<UserBook>(ub => ub.UserName == username && ub.Id_Book == bookId).FirstOrDefault();
                if (userBook == null)
                {
                    return new Result<bool> { ErrorMessage = "UserBook not found.", Data = false }; 
                }
                return new Result<bool> { Data = repo.DeleteEntityById<UserBook>(userBook.Id_Book) };
            }
            catch { throw; }
        }
        public Result<bool> AddReview(long bookId, string username, string review)
        {
            try
            {
                BookReview bookReview = new BookReview
                {
                    Id_Book = bookId,
                    UserName = username,
                    Review = review,
                    BookReviewDate = DateTime.Now.ToString("yyyy-MM-dd")
                };
                repo.InsertEntity(bookReview);
                return new Result<bool> { Data = true };
            }
            catch { throw; }
        }
    }
}

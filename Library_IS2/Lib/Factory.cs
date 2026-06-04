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
                    ReviewDate = br.ReviewDate
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
        public List<UnreturnedBookView> SearchUnreturnedBooks(int days)
        {

            try
            {
                DateTime dateToReturn = DateTime.Now.AddDays(-days);
                List<UserBook> unreturnedBooks = repo.GetEntitiesByFilter<UserBook>(ub => ub.PickDate <= dateToReturn).ToList();
                return GetUnreturnedBooks(unreturnedBooks);

                //01.06.2006 <= 02.06.2026 ja 1 diena true
                //01.06.2006 <= 29.05.2026 un 5 dienas false

            }
            catch { throw; }
        }
        public List<UnreturnedBookView> GetUnreturnedBooks(List<UserBook> unreturnedBooks)
        {

            try
            {
                var result = unreturnedBooks.Select(ub => new UnreturnedBookView
                {
                    Id_Book = ub.Id_Book,
                    BookName = ub.Book?.Book_Name,
                    Email = ub.User?.Email,
                    DaysOverdue = (DateTime.Now - (ub.PickDate.AddDays(GlobalSettings.Instance.DaysToReturn))).Days,
                    UserName = ub.UserName,
                    PickDate = ub.PickDate,
                    Reminder = ub.Reminder,
                    Status = ub.User.IsActive == true ? "Active" : "Inactive"
                }).ToList();
                return result;
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
                    ReviewDate = DateTime.Now
                };
                repo.InsertEntity(bookReview);
                return new Result<bool> { Data = true };
            }
            catch { throw; }
        }

        public bool UserStatusChange(string username, bool isActive)
        {
            try
            {
                User user = repo.GetEntitiesByFilter<User>(u => u.UserName == username).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                user.IsActive = isActive;
                repo.UpdateEntity(user);
                return true;
            }
            catch { throw; }
        }
    }
}

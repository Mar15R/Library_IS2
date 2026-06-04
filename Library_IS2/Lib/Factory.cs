using Library_IS2.Forms;
using Library_IS2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public bool CreateUser(User user)
        {
            try
            {
                repo.InsertEntity(user);
                return true;
            }
            catch { throw; }
        }

        public bool UserNameExists(string userName)
        {
            try
            {
                var user = repo.GetEntityById<User>(userName);
                return user != null;
            }
            catch { throw; }
        }

        public List<BookView> GetAvailableBooks()
        {
            try
            {
                return BooksToBookViews(repo.GetEntitiesByFilter<Book>(b => b.UserBook == null));
                //return repo.GetEntitiesByFilter<Book>(b => b.UserBook == null).Select(b => new BookView
                //{
                //    ID_Book = b.Id_Book,
                //    Book_Name = b.Book_Name,  
                //    ISBN = b.ISBN,
                //    Year = b.Year,
                //    AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"

                //}).ToList();
            }
            catch { throw; }

        }

        public List<BookView> GetBooksByUserID(string username)
        {
            try
            {
                return BooksToBookViews(repo.GetEntitiesByFilter<Book>(b => b.UserBook != null && b.UserBook.UserName == username));
                //return repo.GetEntitiesByFilter<Book>(b => b.UserBook != null && b.UserBook.UserName == username).Select(b => new BookView
                //{
                //    ID_Book = b.Id_Book,
                //    Book_Name = b.Book_Name,
                //    ISBN = b.ISBN,
                //    Year = b.Year,
                //    AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"

                //}).ToList();
            }
            catch { throw; }

        }

        public bool ReturnBook(long bookId)
        {
            try
            {
                return repo.DeleteEntityById<UserBook>(bookId);
            }
            catch { throw; }
        }

        public Result<bool> TakeBook(long bookId, string username)
        {
            try
            {
                int UserBookCount = repo.GetEntitiesByFilter<UserBook>(ub => ub.UserName == username).Count();
                if (UserBookCount >= 5)
                {
                    return new Result<bool> { ErrorMessage = "You have reached the maximum limit of 5 books. Please return a book before taking a new one." };
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

        public List<BookView> GetAllBooks()
        {
            try
            {
                return BooksToBookViews(repo.GetEntities<Book>());
                //return repo.GetEntities<Book>().Select(b => new BookView
                //{
                //    ID_Book = b.Id_Book,
                //    Book_Name = b.Book_Name,
                //    ISBN = b.ISBN,
                //    Year = b.Year,
                //    AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"
                //}).ToList();
            }
            catch { throw; }
        }

        public bool DeleteBook(long bookId)
        {
            try
            {
                return repo.DeleteEntityById<Book>(bookId);
            }
            catch { throw; }
        }

        public List<AuthorView> GetAllAuthors()
        {
            try
            {
                return repo.GetEntities<Author>().Select(a => new AuthorView
                {
                    ID_Author = a.ID_Author,
                    FullName = $"{a.Name} {a.Surname}"
                }).ToList();
            }
            catch { throw; }
        }

        public bool AddBook(Book book)
        {
            try
            {
                repo.InsertEntity(book);
                return true;
            }
            catch { throw; }
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                var existingBook = repo.GetEntityById<Book>(book.Id_Book);
                if (existingBook == null)
                {
                    return false;
                }
                existingBook.Book_Name = book.Book_Name;
                existingBook.ISBN = book.ISBN;
                existingBook.Year = book.Year;
                existingBook.ID_Author = book.ID_Author;
                repo.UpdateEntity(existingBook);
                return true;
            }
            catch { throw; }
        }

        public Book GetBookById(long bookId)
        {
            try
            {
                return repo.GetEntityById<Book>(bookId);
            }
            catch { throw; }
        }
        public long AddAuthor(Author author)
        {
            try
            {
                return repo.InsertEntity(author).ID_Author;
            }
            catch { throw; }
        }
        public List<UserView> GetAllUsers()
        {
            try
            {
                return repo.GetEntities<User>().Select(u => new UserView
                {
                    Name = u.Name,
                    Surname = u.Surname,
                    Email = u.Email,
                    Phone = u.Phone,
                    Role = u.Role,
                    Password = u.Password,
                    UserName = u.UserName
                }).ToList();
            }
            catch { throw; }
        }
        public bool UpdateUser(User user)
        {
            try
            {
                User existingUser = repo.GetEntityById<User>(user.UserName);
                if (existingUser == null)
                {
                    return false;
                }
                existingUser.Name = user.Name;
                existingUser.Surname = user.Surname;
                existingUser.Email = user.Email;
                existingUser.Phone = user.Phone;
                existingUser.Role = user.Role;
                existingUser.Password = user.Password;
                repo.UpdateEntity(existingUser);
                return true;
            }
            catch { throw; }
        }
        public bool DeleteUser(string userName)
        {
            try
            {
                return repo.DeleteEntityById<User>(userName);
            }
            catch { throw; }
        }
        public User GetUserByUserName(string userName)
        {
            try
            {
                return repo.GetEntityById<User>(userName);
            }
            catch { throw; }
        }

        public List<BookView> GetBooksByFilter(string bookname)
        {
            try
            {
                return BooksToBookViews(repo.GetEntitiesByFilter<Book>(b => b.Book_Name.Contains(bookname) && b.UserBook == null));

                //return repo.GetEntitiesByFilter<Book>(b => b.Book_Name.Contains(bookname)).Select(b => new BookView
                //{
                //    ID_Book = b.Id_Book,
                //    Book_Name = b.Book_Name,
                //    ISBN = b.ISBN,
                //    Year = b.Year,
                //    AuthorFullName = $"{b.Author?.Name} {b.Author?.Surname}"
                //}).ToList();
            }

            catch { throw; }
        }

        public List<BookView> GetBooksByYear(int yearFrom, int yearTill)
        {
            try
            {
                return BooksToBookViews(repo.GetEntitiesByFilter<Book>(b => b.Year >= yearFrom && b.Year <= yearTill && b.UserBook == null));
            }
            catch { throw; }
        }

        public List<BookReviewView> GetBookReviewsByFilter(int bookId)
        {
            try
            {
                return repo.GetEntitiesByFilter<BookReview>(br => br.Id_Book == bookId).Select(br => new BookReviewView
                {
                    Id_BookReview = br.Id_BookReview,
                    Id_Book = br.Id_Book,
                    UserName = br.UserName,
                    Review = br.Review,
                    BookReviewDate = DateTime.TryParse(br.BookReviewDate, out var date) ? date : default
                }).ToList();
            }
            catch { throw; }
        }
        public List<UserBookView> GetUserTakenBooks(string username)
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
                    Username = ub.UserName,
                    PickDate = ub.PickDate
                }).ToList();
            }
            catch { throw; }
        }
        public bool SubmitReview(BookReviewView bookReview)
        {
            repo.InsertEntity(new BookReview
            {
                Id_Book = bookReview.Id_Book,
                UserName = bookReview.UserName,
                Review = bookReview.Review,
                BookReviewDate = bookReview.BookReviewDate.ToString("yyyy-MM-dd")
            });

            return true;
        }
    }
}

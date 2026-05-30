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
        public List<BookReviews> GetBookReviews(int bookId)
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS2.Views
{
    public class BookReviewView
    {   public long Id_BookReview { get; set; }
        public long Id_Book { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
        public DateTime BookReviewDate { get; set; }
    }
}

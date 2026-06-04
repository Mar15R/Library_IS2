using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS2.Views
{
    public class UserBookView
    {        
        public long ID_Book { get; set; }
        public string Book_Name { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public string AuthorFullName { get; set; }
        public DateTime PickDate { get; set; }
    }
}

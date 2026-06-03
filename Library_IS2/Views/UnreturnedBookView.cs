using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library_IS2.Views
{
    public class UnreturnedBookView
    {
        public long Id_Book { get; set; }
        public string BookName { get; set; }
        public string UserName { get; set; }
        public DateTime PickDate { get; set; }        
        public string Email { get; set; }
        public int DaysOverdue { get; set; }
        
           
        

    }
}

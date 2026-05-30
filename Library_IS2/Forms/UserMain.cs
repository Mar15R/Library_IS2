using Library_IS.Lib;
using Library_IS2.Lib;
using Library_IS2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS2.Forms
{
    public partial class UserMain : Form
    {
        Factory factory = new Factory();
        Helper helper = new Helper();

        public UserMain()
        {
            InitializeComponent();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            //tp_BookOwerview.Controls.Add();
            lsb_Books.DataSource = factory.GetAviableBooks();
            lsb_Books.DisplayMember = "Book_Name";
            lsb_Books.ValueMember = "ID_Book";

        }

        private void lsb_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBook =(BookView)lsb_Books.SelectedItem;
            if (selectedBook != null)
            {                
                lbl_BookName.Text = selectedBook.Book_Name;
                lbl_Author.Text = selectedBook.AuthorFullName;
                lbl_Year.Text = selectedBook.Year.ToString();
                lbl_ISBN.Text = selectedBook.ISBN;

                gv_Reviews.DataSource = factory.GetBookReviews((int)selectedBook.ID_Book);
                helper.ReloadGrid(gv_Reviews, factory.GetBookReviews((int)selectedBook.ID_Book), null, null);
            }

        }
        
    }
}

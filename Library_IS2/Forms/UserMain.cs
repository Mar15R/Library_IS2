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
        private User _user;
        Factory factory = new Factory();
        Helper helper = new Helper();
        List<GridAction> gridActionsR = new List<GridAction>
            {
                new GridAction { Name = "btnReturn", Text = "Return" }
            };

        public UserMain()
        {
            _user = GlobalSettings.Instance.user;
            InitializeComponent();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
           
            //tp_BookOwerview.Controls.Add();
            ReloadBooks();

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

                gv_Reviews.DataSource = factory.GetBookReviews((long)selectedBook.ID_Book);
                helper.ReloadGrid(gv_Reviews, factory.GetBookReviews((long)selectedBook.ID_Book), null, null);
            }

        } 
        private void ReloadBooks()
        {
            lsb_Books.DataSource = factory.GetAviableBooks();
            lsb_Books.DisplayMember = "Book_Name";
            lsb_Books.ValueMember = "ID_Book";

            helper.ReloadGrid(gv_UserBooks, factory.GetUserBooks(_user.UserName), null, gridActionsR);
        }   

        private void btn_TakeBook_Click(object sender, EventArgs e)
        {
            long bookId = (long)lsb_Books.SelectedValue;
            Result<bool> result = factory.TakeBook(bookId, _user.UserName);
            if (result.IsSuccess)
            {
               ReloadBooks();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gv_UserBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                UserBookView selectedUserBook = (UserBookView)gv_UserBooks.Rows[e.RowIndex].DataBoundItem;
                if (gv_UserBooks.Columns[e.ColumnIndex].Name == "btnReturn")
                {
                    Result<bool> result = factory.ReturnBook(selectedUserBook.ID_Book, _user.UserName);
                    if (result.IsSuccess)
                    {                        
                        using (ReviewForm popup = new ReviewForm(selectedUserBook.ID_Book, _user.UserName))
                        {
                            popup.StartPosition = FormStartPosition.CenterParent;
                            popup.ShowDialog();
                            if (popup.DialogResult == DialogResult.OK)
                            {
                                //ReloadBooks();
                            }
                            ReloadBooks();
                        }
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

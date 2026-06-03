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
        List<GridAction> gridActionsR = new List<GridAction>
            {
                new GridAction { Name = "btnReturn", Text = "Return" }//,
                //new GridAction { Name = "btnUpdate", Text = "Update" }
            };

        private void UserMain_Load(object sender, EventArgs e)
        {
            //tp_BookReviewPanel.Controls.Add();

            ReloadBookList();
            gv_UserTakenBooks.DataSource = factory.GetUserTakenBooks(_user.UserName);
             helper.ReloadGrid(gv_UserTakenBooks, factory.GetUserTakenBooks(_user.UserName), new List<int> { 0 }, gridActionsR);

        }

        private void lsb_BooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBook = (BookView)lsb_BooksList.SelectedItem;
            if (selectedBook != null) { 
            lb_BookName.Text = selectedBook.Book_Name;
            lb_ISBN.Text = selectedBook.ISBN;

                gv_BookReviews.DataSource = factory.GetBookReviewsByFilter((int)selectedBook.ID_Book);
                helper.ReloadGrid(gv_BookReviews, factory.GetBookReviewsByFilter((int)selectedBook.ID_Book), new List<int> { 0 }, false, false);

            }
        }

        private void btn_TakeBook_Click(object sender, EventArgs e)
        {
            long bookId = (long)lsb_BooksList.SelectedValue;
            Result<bool> result = factory.TakeBook(bookId, _user.UserName);
            if (result.IsSuccess)
            {
                ReloadBookList();
                ReloadTakenBooks();
            }
            else
            {
                lbl_Error.Text = result.ErrorMessage;
            }
        }

        public void ReloadBookList()
        {
            lsb_BooksList.DataSource = factory.GetAvailableBooks();
            lsb_BooksList.DisplayMember = "Book_Name";
            lsb_BooksList.ValueMember = "id_Book";
        }

        private void UserMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gv_UserTakenBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UserBookView userBook = (UserBookView)gv_UserTakenBooks.Rows[e.RowIndex].DataBoundItem;
                    if (e.ColumnIndex == gv_UserTakenBooks.Columns["btnReturn"].Index)
                    {
                        if (factory.ReturnBook(userBook.ID_Book))
                        {
                            ReloadBookList();
                            ReloadTakenBooks();
                        }
                        else
                        {
                            MessageBox.Show("Problems with returning of the book...");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        public void ReloadTakenBooks()
        {
            gv_UserTakenBooks.DataSource = factory.GetUserTakenBooks(_user.UserName);
        }

        private void btn_AddReview_Click(object sender, EventArgs e)
        {
            UserBookView selectedTaken = null;
            if (gv_UserTakenBooks.CurrentRow != null)
            {
                selectedTaken = gv_UserTakenBooks.CurrentRow.DataBoundItem as UserBookView;
            }

            if (selectedTaken == null)
            {
                lbl_Error.Text = "Please select a taken book from your list to add a review.";
                return;
            }

            long bookId = selectedTaken.ID_Book;
            using (AddReviewForm popup = new AddReviewForm(bookId, _user.UserName))
            {
                popup.StartPosition = FormStartPosition.CenterParent;
                popup.ShowDialog();
                if (popup.DialogResult == DialogResult.OK)
                {
                    ReloadReviewGrid();
                }

            }

        }
        private void ReloadReviewGrid()
        {
            // Pull selected book ID from the taken-books grid
            UserBookView selectedTaken = null;
            if (gv_UserTakenBooks.CurrentRow != null)
            {
                selectedTaken = gv_UserTakenBooks.CurrentRow.DataBoundItem as UserBookView;
            }

            if (selectedTaken != null)
            {
                gv_BookReviews.DataSource = factory.GetBookReviewsByFilter((int)selectedTaken.ID_Book);
            }
            else
            {
                gv_BookReviews.DataSource = null;
            }
        }

        private void UserMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
// https://github.com/Mar15R/Library_IS2/tree/T001_JS

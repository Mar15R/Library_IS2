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
    public partial class AddReviewForm : Form
    {
        long _bookId;
        string _username;
        Factory factory = new Factory();
        public AddReviewForm(long bookId, string username)
        {
            _bookId = bookId;
            _username = username;
            InitializeComponent();
        }

        private void btn_SubmitReview_Click(object sender, EventArgs e)
        {
            string reviewText = rtb_Review.Text;
            DateTime reviewDate = DateTime.Now;
            string username = _username;
            long bookId = _bookId;

            BookReviewView bookReview = new BookReviewView
            {
                Id_Book = bookId,
                UserName = username,
                Review = reviewText,
                BookReviewDate = reviewDate
            };

            factory.SubmitReview(bookReview);

            MessageBox.Show("Review submitted successfully!");
            this.Close();
        }
    }
}

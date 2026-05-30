using Library_IS2.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_IS2.Forms
{
    public partial class ReviewForm : Form
    {
            private long bookId;
            private string username;
        Factory factory = new Factory();
        public ReviewForm(long bookId, string username)
        {
            this.bookId = bookId;
            this.username = username;
            InitializeComponent();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_SubmitRewiew_Click(object sender, EventArgs e)
        {
                if (rtxt_Review.Text != "")
                {
                    
                    factory.AddReview(bookId, username, rtxt_Review.Text.Trim());
                   
                }
                
            this.Close();
        }
    }
}

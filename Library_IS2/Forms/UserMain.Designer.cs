namespace Library_IS2.Forms
{
    partial class UserMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsb_Books = new System.Windows.Forms.ListBox();
            this.gv_Reviews = new System.Windows.Forms.DataGridView();
            this.tp_BookOwerview = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TakeBook = new System.Windows.Forms.Button();
            this.gv_UserBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Reviews)).BeginInit();
            this.tp_BookOwerview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lsb_Books
            // 
            this.lsb_Books.FormattingEnabled = true;
            this.lsb_Books.Location = new System.Drawing.Point(24, 12);
            this.lsb_Books.Name = "lsb_Books";
            this.lsb_Books.Size = new System.Drawing.Size(300, 342);
            this.lsb_Books.TabIndex = 0;
            this.lsb_Books.SelectedIndexChanged += new System.EventHandler(this.lsb_Books_SelectedIndexChanged);
            // 
            // gv_Reviews
            // 
            this.gv_Reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Reviews.Location = new System.Drawing.Point(350, 202);
            this.gv_Reviews.Name = "gv_Reviews";
            this.gv_Reviews.Size = new System.Drawing.Size(710, 126);
            this.gv_Reviews.TabIndex = 1;
            // 
            // tp_BookOwerview
            // 
            this.tp_BookOwerview.ColumnCount = 2;
            this.tp_BookOwerview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tp_BookOwerview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tp_BookOwerview.Controls.Add(this.label4, 0, 3);
            this.tp_BookOwerview.Controls.Add(this.label3, 0, 2);
            this.tp_BookOwerview.Controls.Add(this.lbl_BookName, 1, 0);
            this.tp_BookOwerview.Controls.Add(this.lbl_Author, 1, 1);
            this.tp_BookOwerview.Controls.Add(this.lbl_Year, 1, 2);
            this.tp_BookOwerview.Controls.Add(this.lbl_ISBN, 1, 3);
            this.tp_BookOwerview.Controls.Add(this.label1, 0, 0);
            this.tp_BookOwerview.Controls.Add(this.label2, 0, 1);
            this.tp_BookOwerview.Location = new System.Drawing.Point(470, 22);
            this.tp_BookOwerview.Name = "tp_BookOwerview";
            this.tp_BookOwerview.RowCount = 4;
            this.tp_BookOwerview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tp_BookOwerview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tp_BookOwerview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tp_BookOwerview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tp_BookOwerview.Size = new System.Drawing.Size(361, 160);
            this.tp_BookOwerview.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Location = new System.Drawing.Point(82, 0);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(34, 13);
            this.lbl_BookName.TabIndex = 2;
            this.lbl_BookName.Text = "         ";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(82, 43);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(34, 13);
            this.lbl_Author.TabIndex = 3;
            this.lbl_Author.Text = "         ";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(82, 86);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(34, 13);
            this.lbl_Year.TabIndex = 4;
            this.lbl_Year.Text = "         ";
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(82, 124);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(34, 13);
            this.lbl_ISBN.TabIndex = 5;
            this.lbl_ISBN.Text = "         ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor";
            // 
            // btn_TakeBook
            // 
            this.btn_TakeBook.Location = new System.Drawing.Point(350, 334);
            this.btn_TakeBook.Name = "btn_TakeBook";
            this.btn_TakeBook.Size = new System.Drawing.Size(710, 23);
            this.btn_TakeBook.TabIndex = 3;
            this.btn_TakeBook.Text = "Take the book";
            this.btn_TakeBook.UseVisualStyleBackColor = true;
            this.btn_TakeBook.Click += new System.EventHandler(this.btn_TakeBook_Click);
            // 
            // gv_UserBooks
            // 
            this.gv_UserBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_UserBooks.Location = new System.Drawing.Point(24, 381);
            this.gv_UserBooks.Name = "gv_UserBooks";
            this.gv_UserBooks.Size = new System.Drawing.Size(1036, 126);
            this.gv_UserBooks.TabIndex = 4;
            this.gv_UserBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_UserBooks_CellContentClick);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 538);
            this.Controls.Add(this.gv_UserBooks);
            this.Controls.Add(this.btn_TakeBook);
            this.Controls.Add(this.tp_BookOwerview);
            this.Controls.Add(this.gv_Reviews);
            this.Controls.Add(this.lsb_Books);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMain_FormClosed);
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Reviews)).EndInit();
            this.tp_BookOwerview.ResumeLayout(false);
            this.tp_BookOwerview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_Books;
        private System.Windows.Forms.DataGridView gv_Reviews;
        private System.Windows.Forms.TableLayoutPanel tp_BookOwerview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_ISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TakeBook;
        private System.Windows.Forms.DataGridView gv_UserBooks;
    }
}
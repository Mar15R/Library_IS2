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
            this.lsb_BooksList = new System.Windows.Forms.ListBox();
            this.gv_BookReviews = new System.Windows.Forms.DataGridView();
            this.tp_BookReviewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lb_ISBN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_BookName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TakeBook = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.gv_UserTakenBooks = new System.Windows.Forms.DataGridView();
            this.btn_AddReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_BookReviews)).BeginInit();
            this.tp_BookReviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserTakenBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lsb_BooksList
            // 
            this.lsb_BooksList.FormattingEnabled = true;
            this.lsb_BooksList.ItemHeight = 16;
            this.lsb_BooksList.Location = new System.Drawing.Point(18, 17);
            this.lsb_BooksList.Name = "lsb_BooksList";
            this.lsb_BooksList.Size = new System.Drawing.Size(242, 276);
            this.lsb_BooksList.TabIndex = 0;
            this.lsb_BooksList.SelectedIndexChanged += new System.EventHandler(this.lsb_BooksList_SelectedIndexChanged);
            // 
            // gv_BookReviews
            // 
            this.gv_BookReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_BookReviews.Location = new System.Drawing.Point(275, 160);
            this.gv_BookReviews.Name = "gv_BookReviews";
            this.gv_BookReviews.RowHeadersWidth = 51;
            this.gv_BookReviews.RowTemplate.Height = 24;
            this.gv_BookReviews.Size = new System.Drawing.Size(775, 130);
            this.gv_BookReviews.TabIndex = 1;
            // 
            // tp_BookReviewPanel
            // 
            this.tp_BookReviewPanel.ColumnCount = 2;
            this.tp_BookReviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tp_BookReviewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tp_BookReviewPanel.Controls.Add(this.lb_ISBN, 1, 1);
            this.tp_BookReviewPanel.Controls.Add(this.label3, 0, 1);
            this.tp_BookReviewPanel.Controls.Add(this.lb_BookName, 1, 0);
            this.tp_BookReviewPanel.Controls.Add(this.label1, 0, 0);
            this.tp_BookReviewPanel.Location = new System.Drawing.Point(298, 22);
            this.tp_BookReviewPanel.Name = "tp_BookReviewPanel";
            this.tp_BookReviewPanel.RowCount = 2;
            this.tp_BookReviewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tp_BookReviewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tp_BookReviewPanel.Size = new System.Drawing.Size(752, 94);
            this.tp_BookReviewPanel.TabIndex = 2;
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(379, 47);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(97, 16);
            this.lb_ISBN.TabIndex = 3;
            this.lb_ISBN.Text = "                              ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN";
            // 
            // lb_BookName
            // 
            this.lb_BookName.AutoSize = true;
            this.lb_BookName.Location = new System.Drawing.Point(379, 0);
            this.lb_BookName.Name = "lb_BookName";
            this.lb_BookName.Size = new System.Drawing.Size(76, 16);
            this.lb_BookName.TabIndex = 1;
            this.lb_BookName.Text = "                       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // btn_TakeBook
            // 
            this.btn_TakeBook.Location = new System.Drawing.Point(275, 296);
            this.btn_TakeBook.Name = "btn_TakeBook";
            this.btn_TakeBook.Size = new System.Drawing.Size(775, 28);
            this.btn_TakeBook.TabIndex = 3;
            this.btn_TakeBook.Text = "Take Book";
            this.btn_TakeBook.UseVisualStyleBackColor = true;
            this.btn_TakeBook.Click += new System.EventHandler(this.btn_TakeBook_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(272, 442);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(127, 16);
            this.lbl_Error.TabIndex = 4;
            this.lbl_Error.Text = "                                        ";
            // 
            // gv_UserTakenBooks
            // 
            this.gv_UserTakenBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_UserTakenBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_UserTakenBooks.Location = new System.Drawing.Point(18, 330);
            this.gv_UserTakenBooks.Name = "gv_UserTakenBooks";
            this.gv_UserTakenBooks.RowHeadersWidth = 51;
            this.gv_UserTakenBooks.RowTemplate.Height = 24;
            this.gv_UserTakenBooks.Size = new System.Drawing.Size(1032, 218);
            this.gv_UserTakenBooks.TabIndex = 5;
            this.gv_UserTakenBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_UserTakenBooks_CellContentClick);
            // 
            // btn_AddReview
            // 
            this.btn_AddReview.Location = new System.Drawing.Point(18, 554);
            this.btn_AddReview.Name = "btn_AddReview";
            this.btn_AddReview.Size = new System.Drawing.Size(1032, 28);
            this.btn_AddReview.TabIndex = 6;
            this.btn_AddReview.Text = "Add Review";
            this.btn_AddReview.UseVisualStyleBackColor = true;
            this.btn_AddReview.Click += new System.EventHandler(this.btn_AddReview_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 594);
            this.Controls.Add(this.btn_AddReview);
            this.Controls.Add(this.gv_UserTakenBooks);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_TakeBook);
            this.Controls.Add(this.tp_BookReviewPanel);
            this.Controls.Add(this.gv_BookReviews);
            this.Controls.Add(this.lsb_BooksList);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserMain_FormClosed);
            this.Load += new System.EventHandler(this.UserMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_BookReviews)).EndInit();
            this.tp_BookReviewPanel.ResumeLayout(false);
            this.tp_BookReviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UserTakenBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_BooksList;
        private System.Windows.Forms.DataGridView gv_BookReviews;
        private System.Windows.Forms.TableLayoutPanel tp_BookReviewPanel;
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_BookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TakeBook;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.DataGridView gv_UserTakenBooks;
        private System.Windows.Forms.Button btn_AddReview;
    }
}
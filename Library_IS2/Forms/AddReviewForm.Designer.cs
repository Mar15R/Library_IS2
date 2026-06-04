namespace Library_IS2.Forms
{
    partial class AddReviewForm
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
            this.lb_BookName = new System.Windows.Forms.Label();
            this.btn_SubmitReview = new System.Windows.Forms.Button();
            this.rtb_Review = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lb_BookName
            // 
            this.lb_BookName.AutoSize = true;
            this.lb_BookName.Location = new System.Drawing.Point(154, 45);
            this.lb_BookName.Name = "lb_BookName";
            this.lb_BookName.Size = new System.Drawing.Size(248, 16);
            this.lb_BookName.TabIndex = 1;
            this.lb_BookName.Text = "Please provide review for selected book";
            // 
            // btn_SubmitReview
            // 
            this.btn_SubmitReview.Location = new System.Drawing.Point(43, 333);
            this.btn_SubmitReview.Name = "btn_SubmitReview";
            this.btn_SubmitReview.Size = new System.Drawing.Size(466, 30);
            this.btn_SubmitReview.TabIndex = 2;
            this.btn_SubmitReview.Text = "Submit Review";
            this.btn_SubmitReview.UseVisualStyleBackColor = true;
            this.btn_SubmitReview.Click += new System.EventHandler(this.btn_SubmitReview_Click);
            // 
            // rtb_Review
            // 
            this.rtb_Review.Location = new System.Drawing.Point(43, 84);
            this.rtb_Review.Name = "rtb_Review";
            this.rtb_Review.Size = new System.Drawing.Size(465, 224);
            this.rtb_Review.TabIndex = 3;
            this.rtb_Review.Text = "";
            // 
            // AddReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 401);
            this.Controls.Add(this.rtb_Review);
            this.Controls.Add(this.btn_SubmitReview);
            this.Controls.Add(this.lb_BookName);
            this.Name = "AddReviewForm";
            this.Text = "AddReviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_BookName;
        private System.Windows.Forms.Button btn_SubmitReview;
        private System.Windows.Forms.RichTextBox rtb_Review;
    }
}
namespace Library_IS2.Forms
{
    partial class ReviewForm
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
            this.rtxt_Review = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SubmitRewiew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_Review
            // 
            this.rtxt_Review.Location = new System.Drawing.Point(85, 60);
            this.rtxt_Review.Name = "rtxt_Review";
            this.rtxt_Review.Size = new System.Drawing.Size(356, 184);
            this.rtxt_Review.TabIndex = 0;
            this.rtxt_Review.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izveido atsauksmi";
            // 
            // btn_SubmitRewiew
            // 
            this.btn_SubmitRewiew.Location = new System.Drawing.Point(85, 275);
            this.btn_SubmitRewiew.Name = "btn_SubmitRewiew";
            this.btn_SubmitRewiew.Size = new System.Drawing.Size(356, 23);
            this.btn_SubmitRewiew.TabIndex = 2;
            this.btn_SubmitRewiew.Text = "Iesniegt atsauksmi";
            this.btn_SubmitRewiew.UseVisualStyleBackColor = true;
            this.btn_SubmitRewiew.Click += new System.EventHandler(this.btn_SubmitRewiew_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 421);
            this.Controls.Add(this.btn_SubmitRewiew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_Review);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_Review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SubmitRewiew;
    }
}
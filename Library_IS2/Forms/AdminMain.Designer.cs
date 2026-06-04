namespace Library_IS2.Forms
{
    partial class AdminMain
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
            this.gv_UnreturnedBooks = new System.Windows.Forms.DataGridView();
            this.lb_ErrorDeactivate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_UnreturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_UnreturnedBooks
            // 
            this.gv_UnreturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_UnreturnedBooks.Location = new System.Drawing.Point(84, 33);
            this.gv_UnreturnedBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_UnreturnedBooks.Name = "gv_UnreturnedBooks";
            this.gv_UnreturnedBooks.RowHeadersWidth = 51;
            this.gv_UnreturnedBooks.Size = new System.Drawing.Size(883, 203);
            this.gv_UnreturnedBooks.TabIndex = 0;
            this.gv_UnreturnedBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_UnreturnedBooks_CellContentClick);
            // 
            // lb_ErrorDeactivate
            // 
            this.lb_ErrorDeactivate.AutoSize = true;
            this.lb_ErrorDeactivate.Location = new System.Drawing.Point(87, 254);
            this.lb_ErrorDeactivate.Name = "lb_ErrorDeactivate";
            this.lb_ErrorDeactivate.Size = new System.Drawing.Size(109, 16);
            this.lb_ErrorDeactivate.TabIndex = 1;
            this.lb_ErrorDeactivate.Text = "                                  ";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lb_ErrorDeactivate);
            this.Controls.Add(this.gv_UnreturnedBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMain_FormClosed);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_UnreturnedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_UnreturnedBooks;
        private System.Windows.Forms.Label lb_ErrorDeactivate;
    }
}
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
    public partial class AdminMain : Form
    {
        Factory factory = new Factory();
        Helper helper = new Helper();

        List<GridAction> gridActionsD = new List<GridAction>
            {
                new GridAction { Name = "btnDeactivateUser", Text = "Deactivate User" }
            };

        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            helper.ReloadGrid(gv_UnreturnedBooks, factory.SearchUnreturnedBooks(GlobalSettings.Instance.DaysToReturn), new List<int> { 0 }, gridActionsD);

        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gv_UnreturnedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lb_ErrorDeactivate.Text = String.Empty;
                UnreturnedBookView unreturnedBookView = (UnreturnedBookView)gv_UnreturnedBooks.Rows[e.RowIndex].DataBoundItem;
                if (gv_UnreturnedBooks.Columns[e.ColumnIndex].Name == "btnDeactivateUser")
                {
                    bool result = factory.DeactivateUser(unreturnedBookView.UserName);
                    if (result)
                    {
                        lb_ErrorDeactivate.Text = "User deactivated successfully.";
                    }
                    else
                    {
                        lb_ErrorDeactivate.Text = "Failed to deactivate user.";
                    }
                }
            }
            catch { }
        }
    }
}

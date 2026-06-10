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

        List<GridAction> gridActions = new List<GridAction>
            {
                new GridAction { Name = "btnDeactivateUser", Text = "Deactivate User" },
                new GridAction { Name = "btnActivateUser", Text = "Activate User" }
            };


        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            UnreturnedBooksGridReload();

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

                var buttonName = gv_UnreturnedBooks.Columns[e.ColumnIndex].Name;

                switch (buttonName)
                {
                    case "btnDeactivateUser":
                        bool result = factory.UserStatusChange(unreturnedBookView.UserName, false);
                        if (!result)
                        {
                            lb_ErrorDeactivate.Text = "Error deactivating user.";
                        }
                        break;
                    case "btnActivateUser":
                        bool resultActivate = factory.UserStatusChange(unreturnedBookView.UserName, true);
                        if (!resultActivate)
                        {
                            lb_ErrorDeactivate.Text = "Error activating user.";
                        }
                        break;
                }

                //if (gv_UnreturnedBooks.Columns[e.ColumnIndex].Name == "btnDeactivateUser")
                //{
                //    bool result = factory.UserStatusChange(unreturnedBookView.UserName, false);
                    
                //}

                //if (gv_UnreturnedBooks.Columns[e.ColumnIndex].Name == "btnActivateUser")
                //{
                //    bool result = factory.UserStatusChange(unreturnedBookView.UserName, true);
                //}

                UnreturnedBooksGridReload();
            }
            catch (Exception ex)
            {
                lb_ErrorDeactivate.Text = $"An error occurred: {ex.Message}";
            }
        }

        private void UnreturnedBooksGridReload()
        {
            helper.ReloadGrid(gv_UnreturnedBooks, factory.SearchUnreturnedBooks(GlobalSettings.Instance.DaysToReturn), new List<int> { 0 }, gridActions);

        }
    }
}

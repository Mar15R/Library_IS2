using Library_IS.Lib;
using Library_IS2.Lib;
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
            
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            helper.ReloadGrid(gv_UnreturnedBooks, factory.SearchUnreturnedBooks(5), new List<int> { 0 }, hasDeleteAction: false);

        }
    }
}

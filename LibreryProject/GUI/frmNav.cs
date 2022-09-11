using LibreryProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreryProject.GUI
{
    public partial class frmNav : Form
    {
        Permitions p;
        public frmNav()
        {
            InitializeComponent();
        }
        public frmNav(Permitions p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void frmNav_Load(object sender, EventArgs e)
        {

        }

        private void employee_Click(object sender, EventArgs e)
        {
            frmEmployeTable frm = new frmEmployeTable();
            frm.ShowDialog();
        }

        private void books_Click(object sender, EventArgs e)
        {
            frmBooksTable frm = new frmBooksTable();
            frm.ShowDialog();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            frmClientTable frm = new frmClientTable();
            frm.ShowDialog();
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            frmOneClient frm = new frmOneClient();
            frm.ShowDialog();
        }

        private void waitings_Click(object sender, EventArgs e)
        {
           //???????????
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreryProject.BLL;

namespace LibreryProject.GUI
{
    public partial class frmBrrowTable : Form
    {
        //הגדרת 2 אוביקטיים
        BorrowTable b;
        BorrowTable_T bTable;
        public frmBrrowTable()
        {
            InitializeComponent();
           b = new BorrowTable();
            bTable = new BorrowTable_T();
            refresh();
        }
        //dgvממלא את ה
        public void refresh()
        {
            dgvBrrow.DataSource = bTable.GetList().Select(x => new { x.Code_Borrow, x.GetClient().Name_Client, x.GetEmploies().Name_Employ, x.Date_Borrow }).ToList();
            changeHeaders();
        }

        private void changeHeaders()
        {
            dgvBrrow.Columns["Code_Borrow"].HeaderText = "קוד השאלה";
        }

        private void dgvBrrow_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

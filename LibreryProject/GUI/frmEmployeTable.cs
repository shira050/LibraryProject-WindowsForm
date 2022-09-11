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
    public partial class frmEmployeTable : Form
    {
        EmploiesTable_T eTable;
       
        public frmEmployeTable()
        {
            InitializeComponent();
            eTable = new EmploiesTable_T();
            dgvClient.DataSource = eTable.GetList().Select(x => new { x.Id_Employ, x.Name_Employ, x.Mail_Employ, x.Tel_Employ }).ToList();
            changeHeaders();
        }

        private void changeHeaders()
        {
            dgvClient.Columns["Id_Employ"].HeaderText = "ת.ז.";
            dgvClient.Columns["Name_Employ"].HeaderText = "שם";
            dgvClient.Columns["Mail_Employ"].HeaderText = "מייל";
            dgvClient.Columns["Tel_Employ"].HeaderText = "טלפון";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOneEmployee frm = new frmOneEmployee();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmEmployeTable frm = new frmEmployeTable();
            //frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frmEmployeTable frm = new frmEmployeTable();
            //frm.ShowDialog();
        }
    }
}

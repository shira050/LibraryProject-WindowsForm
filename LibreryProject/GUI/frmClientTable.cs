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
    public partial class frmClientTable : Form
    {
        ClientTable c;
        ClientTable_T cTable;
        public frmClientTable()
        {
            InitializeComponent();
            c = new ClientTable();
            cTable = new ClientTable_T();
            dgvClient.DataSource = cTable.GetList().Select(x => new { x.Id_Client, x.Name_Client, x.MailClient,x.TelClient }).ToList();
            changeHeaders();
        }

        private void changeHeaders()
        {
            dgvClient.Columns["Id_Client"].HeaderText = "ת.ז.";
            dgvClient.Columns["Name_Client"].HeaderText = "שם";
            dgvClient.Columns["MailClient"].HeaderText = "מייל";
            dgvClient.Columns["TelClient"].HeaderText = "טלפון";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOneClient frm = new frmOneClient();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c.Id_Client == 0)
                MessageBox.Show("לא נבחר לקוח");
            else
            {
                frmOneClient frm = new frmOneClient(c, eState.עדכון);
                frm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvClient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int code = Convert.ToInt32(dgvClient.SelectedRows[0].Cells[0].Value);
            c = cTable.GetList().FirstOrDefault(x => x.Id_Client == code);


        }
    }
}

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
    public partial class frmAuthorTable : Form
    {
     
        BLL.AuthorsTable_T aTable;
        BLL.AuthorsTable a;
        public frmAuthorTable()
        {
            InitializeComponent();
            aTable = new BLL.AuthorsTable_T();
            a = new BLL.AuthorsTable();
            rbadd.Checked = true;
            refresh();

        }

        private void frmAuthorTable_Load(object sender, EventArgs e)
        {

        }
        public void refresh()
        {
            aTable = new BLL.AuthorsTable_T();
            dgvAuthors.DataSource = null;
            dgvAuthors.DataSource = aTable.GetList().Select(x => new { x.Code_Author, x.Name_Author }).ToList();
            ChangeHeaders();
        }
        private void ChangeHeaders()
        {
            dgvAuthors.Columns["Code_Author"].HeaderText = "קוד סופר";
            dgvAuthors.Columns["Name_Author"].HeaderText = "שם סופר";
        }
        private void rbadd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadd.Checked == true)
            {
                gbMatzav.Text = "הוספה";
                txtname.Text = "";

            }
        }

        private void rbedkun_CheckedChanged(object sender, EventArgs e)
        {
            if (rbedkun.Checked == true)
            {
                gbMatzav.Text = "עדכון";
                txtname.Text = "";

            }
        }
       
        public bool Check()
        {
            bool ok = true;
            try
            {
                a.Name_Author = txtname.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ok = false;
            }
            return ok;
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (aTable.GetList().Any(x => x.Name_Author == txtname.Text) == true)
                MessageBox.Show("הסופר קיים");
            else
                if (Check())
            {
                if (rbadd.Checked == true)
                {
                    a.Code_Author = aTable.GetNewKey();
                    aTable.Add(a);
                    a = new BLL.AuthorsTable();
                    MessageBox.Show("הסופר נוסף בהצלחה");
                }
                if (rbedkun.Checked == true)
                {
                    aTable.Update(a);
                    MessageBox.Show("הסופר עודכן בהצלחה");
                }
                txtname.Text = "";
                refresh();
            }
          

        }
        private void dgvAuthors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (rbedkun.Checked == true)
            {
                int code = Convert.ToInt32(dgvAuthors.SelectedRows[0].Cells[0].Value);
                a = aTable.GetList().FirstOrDefault(x => x.Code_Author == code);
                txtname.Text = a.Name_Author;
            }
        }
       

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            dgvAuthors.DataSource = aTable.GetList().Where(x => x.Name_Author.Contains(txtfind.Text)).Select(x => new { x.Code_Author, x.Name_Author }).ToList();

        }

       
    }
}

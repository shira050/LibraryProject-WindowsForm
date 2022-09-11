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
    public partial class frmKindTable : Form
    {
        BLL.KindTable_T kTable;
        BLL.KindTable k;
        public frmKindTable()
        {
            InitializeComponent();
            kTable = new BLL.KindTable_T();
            k= new BLL.KindTable();
            rbadd.Checked = true;
            refresh();
        }

        private void frmKindTable_Load(object sender, EventArgs e)
        {

        }
        public void refresh()
        {
            dgvKind.DataSource = kTable.GetList().Select(x => new { x.Code_Kind, x.Name_kind }).ToList();
            ChangeHeaders();
        }
        private void ChangeHeaders()
        {
            dgvKind.Columns["Code_Kind"].HeaderText = "קוד סוג";
            dgvKind.Columns["Name_kind"].HeaderText = "שם סוג";
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
                k.Name_kind = txtname.Text;
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
            if (kTable.GetList().Any(x => x.Name_kind == txtname.Text) == true)
                MessageBox.Show("הסוג קיים");
            else
               if (Check())
            {
                if (rbadd.Checked == true)
                {
                    k.Code_Kind = kTable.GetNewKey();
                    kTable.Add(k);
                    k = new BLL.KindTable();
                    MessageBox.Show("הסוג נוסף בהצלחה");
                }
                if (rbedkun.Checked == true)
                {
                    kTable.Update(k);
                    MessageBox.Show("הסוג עודכן בהצלחה");
                }
                txtname.Text = "";
                refresh();
            }

        }
        private void dgvAuthors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (rbedkun.Checked == true)
            {
                int code = Convert.ToInt32(dgvKind.SelectedRows[0].Cells[0].Value);
                k = kTable.GetList().FirstOrDefault(x => x.Code_Kind == code);
                txtname.Text = k.Name_kind;
            }
        }
      

        private void txtfind_TextChanged(object sender, EventArgs e)
        {
            dgvKind.DataSource = kTable.GetList().Where(x => x.Name_kind.Contains(txtfind.Text)).Select(x => new { x.Code_Kind, x.Name_kind }).ToList();

        }
    }
}

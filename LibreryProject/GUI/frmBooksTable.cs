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
    public partial class frmBooksTable : Form
    {
        BooksTable_T bTable;
        BooksTable b;
        public frmBooksTable()
        {
            InitializeComponent();
            bTable = new BooksTable_T();
            b = new BooksTable();
            dgvBook.DataSource = bTable.GetList().Select(x => new { x.code_Book, x.GetAuthor().Name_Author, x.GetKind().Name_kind, x.Name_Book }).ToList();
            changeHeaders();
        }

        private void changeHeaders()
        {
            dgvBook.Columns["code_Book"].HeaderText = "קוד ספר";
            dgvBook.Columns["Name_Author"].HeaderText = "שם";
            dgvBook.Columns["Name_Kind"].HeaderText = "קטגוריה";
            dgvBook.Columns["Name_Book"].HeaderText = "שם ספר";
        }

        private void frmBooksTable_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOneBook frm = new frmOneBook();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b.code_Book == 0)
                MessageBox.Show("לא נבחר ספר");
            else
            {
                frmOneBook frm = new frmOneBook(b, eState.עדכון);
                frm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (b.code_Book == 0)
                MessageBox.Show("לא נבחר ספר");
            else
            {
                frmOneBook frm = new frmOneBook(b, eState.הצגה);
                frm.ShowDialog();
            }
        }

        private void dgvClient_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                int code = Convert.ToInt32(dgvBook.SelectedRows[0].Cells[0].Value);
                b = bTable.GetList().FirstOrDefault(x => x.code_Book == code);
            

        }
    }
    }

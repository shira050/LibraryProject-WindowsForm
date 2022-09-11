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
    public partial class frmOneBook : Form
    {
        BooksTable b;
        BooksTable_T bTble;
        eState state;
        public frmOneBook()
        {
            InitializeComponent();
            b = new BooksTable();
            bTble = new BooksTable_T();
            state = eState.חדש;

            // הוספת המפתח הראשי - רק אם המפתח הראשי הוא מספור אוטומטי// 
            b.code_Book = bTble.GetNewKey();
            // הצגת הקוד החדש בטופס// 
            lblCode.Text = b.code_Book.ToString();

            KindTable_T bt = new KindTable_T();
            cmbCodeKind.DataSource = bt.GetList();
            AuthorsTable_T at = new AuthorsTable_T();
            cmbCodeAuthor.DataSource = at.GetList();


        }

        public frmOneBook(BooksTable b, eState s)
        {
            InitializeComponent();
            this.b = new BooksTable();
            bTble = new BooksTable_T();
            this.b = b;

            // מגיע לטופס רק כדי לראות את הפרטים// 
            if (s == eState.הצגה)
            {
                fillEnabled();
            }
          
            fillTextBox();
             KindTable_T bt = new KindTable_T();
            cmbCodeKind.DataSource = bt.GetList();
            AuthorsTable_T at = new AuthorsTable_T();
            cmbCodeAuthor.DataSource = at.GetList();
        }
        //  פעולה שמגדירה את כל הפקדים לללא אפשרות שינוי// 
        public void fillEnabled()
        {
            lblCode.Enabled = false;
            cmbCodeKind.Enabled = false;
            cmbCodeAuthor.Enabled = false;
            textBox1.Enabled = false;


        }
        //  פעולה שממלאת את הפקדים בטופס במצב של עדכון// 
        public void fillTextBox()
        {
            lblCode.Text = b.code_Book.ToString();
           
            textBox1.Text = b.Name_Book;

            List<string> k = new List<string>();
            foreach (KindTable item in cmbCodeKind.Items)
            {
                k.Add(((KindTable)item).Name_kind);
            }
            List<string> a = new List<string>();
            foreach (AuthorsTable item in cmbCodeAuthor.Items)
            {
                k.Add(((AuthorsTable)item).Name_Author);
            }
           // cmbCodeKind.SelectedIndex = k.IndexOf(b.GetKind().Name_kind);




        }
        //   פעולה שמעדכנת את הפקדים מהטופס לתוך המחלקה// 
        public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();

            try
            {
                b.Name_Book = textBox1.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                ok = false;
            }


            return ok;
        }

        

        private void frmOneBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Check() == true)

            {
                if (state == eState.חדש)
                {
                    try
                    {
                        bTble.Add(b);

                        MessageBox.Show("הספר נשמר בהצלחה");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("בעייה בשמירת הספר");
                    }
                }
                if (state == eState.עדכון)
                {
                    try
                    {
                        bTble.Update(b);
                        MessageBox.Show("הספר עודכן בהצלחה");

                        this.Close();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("בעייה בעדכון הספר");
                    }
                }


            }
        }
    }
}
        

       
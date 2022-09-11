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
    public partial class frmOneEmployee : Form
    {
        EmploiesTable e;
        EmploiesTable_T eTble;
        eState state;
        public frmOneEmployee()
        {
            InitializeComponent();
            e = new EmploiesTable();
            eTble = new EmploiesTable_T();
            state = eState.חדש;

            // הוספת המפתח הראשי - רק אם המפתח הראשי הוא מספור אוטומטי// 
            e.Id_Employ = eTble.GetNewKey();
            // הצגת הקוד החדש בטופס// 
            lblCode.Text = e.Id_Employ.ToString();
        }
        public frmOneEmployee(EmploiesTable em, eState s)
        {
            InitializeComponent();
            e = new EmploiesTable();
            eTble = new EmploiesTable_T();

            // מגיע לטופס רק כדי לראות את הפרטים// 
            if (s == eState.הצגה)
            {
                fillEnabled();
            }
        }
        //  פעולה שמגדירה את כל הפקדים לללא אפשרות שינוי// 
        public void fillEnabled()
        {
            lblCode.Enabled = false;

            textBox1.Enabled = false; 
            textBox2.Enabled = false;
            textBox3.Enabled = false;
         

        }
        //  פעולה שממלאת את הפקדים בטופס במצב של עדכון// 
        public void fillTextBox()
        {
            lblCode.Text = e.Id_Employ.ToString();
            textBox1.Text = e.Name_Employ;
            textBox2.Text = e.Mail_Employ;
            textBox3.Text = e.Tel_Employ;


        }
        //   פעולה שמעדכנת את הפקדים מהטופס לתוך המחלקה// 
        public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();

            try
            {
                e.Name_Employ = textBox1.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                ok = false;
            }


            try
            {
                e.Mail_Employ = textBox2.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                ok = false;
            }
            try
            {
                e.Tel_Employ = textBox3.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox3, ex.Message);
                ok = false;
            }


            return ok;
        }

       


private void frmOneEmployee_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
               e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (Check() == true)

            {
                if (state == eState.חדש)
                {
                    try
                    {
                        //????????????????????????????????????????????????? eTble.Add(e);

                        MessageBox.Show("העובד נשמר בהצלחה");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("בעייה בשמירת העובד");
                    }
                }
                if (state == eState.עדכון)
                {
                    try
                    {
                        //???????????????????????????????????????? eTble.Update(e);
                        MessageBox.Show("העובד עודכן בהצלחה");

                        this.Close();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("בעייה בעדכון העובד");
                    }
                }


            }
        }
    }
}

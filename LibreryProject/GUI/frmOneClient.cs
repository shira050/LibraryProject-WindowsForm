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
    public enum eState
    {
        חדש, עדכון, הצגה
    }

    public partial class frmOneClient : Form
    {
        ClientTable c;
        ClientTable_T cTble;
        eState state;
        public frmOneClient()
        {
            InitializeComponent();
            c = new ClientTable();
            cTble = new ClientTable_T();
            state = eState.חדש;
           
           // הוספת המפתח הראשי - רק אם המפתח הראשי הוא מספור אוטומטי// 
 c.Id_Client = cTble.GetNewKey();
            // הצגת הקוד החדש בטופס// 
            lblCode.Text = c.Id_Client.ToString();

        }

        
 public frmOneClient(ClientTable em, eState s)
        {
            InitializeComponent();
            c = new ClientTable();
            cTble = new ClientTable_T();
            c = em;
           
           
// מגיע לטופס רק כדי לראות את הפרטים// 
// מגיע לטופס רק כדי לראות את הפרטים// 
 if (s == eState.הצגה)
 {
              fillEnabled();
            }
            fillTextBox();
           


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
            lblCode.Text = c.Id_Client.ToString();
            textBox1.Text = c.Name_Client;
            textBox2.Text = c.MailClient;
            textBox3.Text = c.TelClient;
        }
     //   פעולה שמעדכנת את הפקדים מהטופס לתוך המחלקה// 
 public bool Check()
        {
            bool ok = true;
            errorProvider1.Clear();
         
            try
            {
                c.Name_Client = textBox1.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
                ok = false;
            }
            try
            {
                c.MailClient = textBox2.Text;
              
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                ok = false;
            }
            try
            {
                c.TelClient = textBox3.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox3, ex.Message);
                ok = false;
            }
          
            return ok;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Check() == true)

            {
                if (state == eState.חדש)
                {
                    try
                    {
                        cTble.Add(c);

                        MessageBox.Show("הלקוח נשמר בהצלחה");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("בעייה בשמירת הלקוח");
                    }
                }
                if (state == eState.עדכון)
                {
                    try
                    {
                        cTble.Update(c);
                        MessageBox.Show("הלקוח עודכן בהצלחה");

                        this.Close();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("בעייה בעדכון הלקוח");
                    }
                }
            }
        }

            private void frmOneClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '\b')
                e.Handled = true;
        }

       
        }
    }


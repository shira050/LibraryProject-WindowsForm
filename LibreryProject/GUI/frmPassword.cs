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
    public partial class frmPassword : Form
    {
        //מסוג מחלקת היחיד
        Permitions p;
        //מסוג מחלקת הרבים
        Permitions_T pTable;

        public frmPassword()
        {
            InitializeComponent();
            p = new Permitions();
            pTable = new Permitions_T();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {

        }

        private void picOpen1_Click(object sender, EventArgs e)
        {
            //תראה את הסיסמה
            txtpassword1.UseSystemPasswordChar = false;
            //תציג את העין הסגורה
            picClose1.Visible = true;
            //תסתיר את העין הפתוחה
            picOpen1.Visible = false;
        }

        private void picClose1_Click(object sender, EventArgs e)
        {
            //תסתיר את הסיסמה
            txtpassword1.UseSystemPasswordChar = true;
            //תציג את העין הפתוחה
            picOpen1.Visible = true;
            //תסתיר את העין הסגורה
            picClose1.Visible = false;

        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            if (pTable.GetList().FirstOrDefault(x => x.user_Name == txtname1.Text && x.Password_Client == txtpassword1.Text) != null)
            {
                p = pTable.GetList().FirstOrDefault(x => x.user_Name == txtname1.Text && x.Password_Client == txtpassword1.Text);
                frmNav n = new frmNav(p);
                n.ShowDialog();
            }
            else
                MessageBox.Show("השם משתמש או הסיסמה שגויים");
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            ////כדי לפתוח אפשרות של החלפת סיסמה חובה להכניס שם משתמש וסיסמה נכונים
            ////בתוך התנאי המחשב עובר על כל טבלת העובדים ומחפש את העובד הראשון שעונה לתנאי שכתבנו בתוך הסוגריים
            ////אם מוצא מביא את העובד
            ////null אם לא מחזיר 
            //p = pTable.GetList().FirstOrDefault(x => x.user_Name == txtname1.Text && x.Password_Client == txtpassword1.Text);
            //if (p != null)
            //{
            //    gbAddPass.Visible = true;
            //    btnAdd.Visible = false;
            //    gbAddPass.Visible = false;
            //}
            //else
            //    MessageBox.Show("שם המשתמש או הסיסמה שגויים");




            //ניגש לעובד ונשנה את הסיסמה
            //בודקת שהסיסמה תקינה לפי חוקי סיסמה
            if (validates.checkPassword(txtNewPassword.Text) == true)
                //בודקת שאימות סיסמה שווה לסיסמה
                if (txtNewPassword.Text != txtVarifyPass.Text)
                    MessageBox.Show("הסיסמאות לא תואמות");
                else
                {//שהכל תקין מעדכן את העובד שהסיסמה שונתה
                    p.Password_Client = txtNewPassword.Text;
                    pTable.Update(p);
                    MessageBox.Show("הסיסמה עודכנה בהצלחה");


                }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        
        p = pTable.GetList().FirstOrDefault(x => x.user_Name == txtname1.Text && x.Password_Client == txtpassword1.Text);
            if (p != null && p.Kind_Client == "מנהל")
            {
                gbAddPass.Visible = true;
                gbPassword.Visible = false;
            }
            else
                MessageBox.Show("הוספת עובד רק על ידי מנהל המערכת");
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            //הוספה של עובד חדש למערכת
            if (validates.checkPassword(txtPassword3.Text) == true)
            {
                //מספור אוטומטי
                p.Code = pTable.GetNewKey();
                p.user_Name = txtname2.Text;
                p.Password_Client = txtPassword3.Text;
                p.Kind_Client = cmbkind.Text;
                pTable.Add(p);
                MessageBox.Show("העובד נוסף בהצלחה");
                txtname2.Text = "";
                txtPassword3.Text = "";
                cmbkind.Text = "";
            }

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            gbAddPass.Visible = false;
            gbChangePass.Visible = false;
            gbPassword.Visible = true;
            btnAdd.Visible = false;
        }

        private void btnMennege_Click(object sender, EventArgs e)
        {
            gbAddPass.Visible = true;
            gbChangePass.Visible = false;
            gbPassword.Visible = true;
            btnAdd.Visible = true;
        }

        private void picOpen2_Click(object sender, EventArgs e)
        {
            //תראה את הסיסמה
            txtpassword2.UseSystemPasswordChar = false;
            //תציג את העין הסגורה
            picClose2.Visible = true;
            //תסתיר את העין הפתוחה
            picOpen2.Visible = false;
        }

        private void picClose2_Click(object sender, EventArgs e)
        {
            //תסתיר את הסיסמה
            txtpassword2.UseSystemPasswordChar = true;
            //תציג את העין הפתוחה
            picOpen2.Visible = true;
            //תסתיר את העין הסגורה
            picClose2.Visible = false;
        }

        private void picOpen3_Click(object sender, EventArgs e)
        {
            //תראה את הסיסמה
            txtNewPassword.UseSystemPasswordChar = false;
            //תציג את העין הסגורה
            picClose3.Visible = true;
            //תסתיר את העין הפתוחה
            picOpen3.Visible = false;
        }

        private void picOpen4_Click(object sender, EventArgs e)
        {
            //תראה את הסיסמה
            txtVarifyPass.UseSystemPasswordChar = false;
            //תציג את העין הסגורה
            picClose4.Visible = true;
            //תסתיר את העין הפתוחה
            picOpen4.Visible = false;
        }

        private void picClose4_Click(object sender, EventArgs e)
        {
            //תסתיר את הסיסמה
            txtVarifyPass.UseSystemPasswordChar = true;
            //תציג את העין הפתוחה
            picOpen4.Visible = true;
            //תסתיר את העין הסגורה
            picClose4.Visible = false;
        }

        private void picClose3_Click(object sender, EventArgs e)
        {
            //תסתיר את הסיסמה
            txtNewPassword.UseSystemPasswordChar = true;
            //תציג את העין הפתוחה
            picOpen3.Visible = true;
            //תסתיר את העין הסגורה
            picClose3.Visible = false;
        }

        private void picOpen5_Click(object sender, EventArgs e)
        {
            //תראה את הסיסמה
            txtPassword3.UseSystemPasswordChar = false;
            //תציג את העין הסגורה
            picClose5.Visible = true;
            //תסתיר את העין הפתוחה
            picOpen5.Visible = false;
        }

        private void picClose5_Click(object sender, EventArgs e)
        {
            //תסתיר את הסיסמה
            txtPassword3.UseSystemPasswordChar = true;
            //תציג את העין הפתוחה
            picOpen5.Visible = true;
            //תסתיר את העין הסגורה
            picClose5.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
           
            gbChangePass.Visible = true;
          
        }
    }
}



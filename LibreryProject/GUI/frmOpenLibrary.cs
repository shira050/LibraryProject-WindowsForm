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
    public partial class frmOpenLibrary : Form
    {
        public frmOpenLibrary()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            timer2.Stop();
            
           timer1.Stop();
            frmPassword frm = new frmPassword();
            frm.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value+5 < 100)
                progressBar1.Value += 5;
            else
                progressBar1.Value = 100;
        }
    }
}

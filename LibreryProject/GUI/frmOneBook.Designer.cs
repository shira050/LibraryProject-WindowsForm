namespace LibreryProject.GUI
{
    partial class frmOneBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelCodeKind = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCodeAuthor = new System.Windows.Forms.ComboBox();
            this.cmbCodeKind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 609);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 35;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 345);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(214, 26);
            this.textBox1.TabIndex = 34;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.White;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCode.Location = new System.Drawing.Point(220, 132);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCode.Size = new System.Drawing.Size(196, 39);
            this.lblCode.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "שם פרטי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "קוד ספר";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "ספר";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(446, 203);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(67, 20);
            this.labelAuthor.TabIndex = 37;
            this.labelAuthor.Text = "קוד סופר";
            // 
            // labelCodeKind
            // 
            this.labelCodeKind.AutoSize = true;
            this.labelCodeKind.Location = new System.Drawing.Point(446, 265);
            this.labelCodeKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodeKind.Name = "labelCodeKind";
            this.labelCodeKind.Size = new System.Drawing.Size(57, 20);
            this.labelCodeKind.TabIndex = 41;
            this.labelCodeKind.Text = "קוד סוג";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbCodeAuthor
            // 
            this.cmbCodeAuthor.FormattingEnabled = true;
            this.cmbCodeAuthor.Location = new System.Drawing.Point(220, 203);
            this.cmbCodeAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCodeAuthor.Name = "cmbCodeAuthor";
            this.cmbCodeAuthor.Size = new System.Drawing.Size(194, 28);
            this.cmbCodeAuthor.TabIndex = 43;
            // 
            // cmbCodeKind
            // 
            this.cmbCodeKind.FormattingEnabled = true;
            this.cmbCodeKind.Location = new System.Drawing.Point(220, 260);
            this.cmbCodeKind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCodeKind.Name = "cmbCodeKind";
            this.cmbCodeKind.Size = new System.Drawing.Size(194, 28);
            this.cmbCodeKind.TabIndex = 43;
            // 
            // frmOneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 692);
            this.Controls.Add(this.cmbCodeKind);
            this.Controls.Add(this.cmbCodeAuthor);
            this.Controls.Add(this.labelCodeKind);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOneBook";
            this.Text = "frmOneBook";
            this.Load += new System.EventHandler(this.frmOneBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelCodeKind;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbCodeKind;
        private System.Windows.Forms.ComboBox cmbCodeAuthor;
    }
}
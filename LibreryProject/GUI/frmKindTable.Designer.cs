namespace LibreryProject.GUI
{
    partial class frmKindTable
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
            this.gbMatzav = new System.Windows.Forms.GroupBox();
            this.btnok = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbedkun = new System.Windows.Forms.RadioButton();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKind = new System.Windows.Forms.DataGridView();
            this.gbMatzav.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKind)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMatzav
            // 
            this.gbMatzav.BackColor = System.Drawing.Color.Transparent;
            this.gbMatzav.Controls.Add(this.btnok);
            this.gbMatzav.Controls.Add(this.txtname);
            this.gbMatzav.Controls.Add(this.label2);
            this.gbMatzav.Location = new System.Drawing.Point(156, 42);
            this.gbMatzav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMatzav.Name = "gbMatzav";
            this.gbMatzav.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMatzav.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbMatzav.Size = new System.Drawing.Size(297, 218);
            this.gbMatzav.TabIndex = 13;
            this.gbMatzav.TabStop = false;
            this.gbMatzav.Text = "הוספה";
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnok.Location = new System.Drawing.Point(68, 122);
            this.btnok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(135, 46);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "אישור";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(24, 62);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 26);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(200, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "שם סוג";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbedkun);
            this.groupBox1.Controls.Add(this.rbadd);
            this.groupBox1.Location = new System.Drawing.Point(804, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(300, 218);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "מצב טופס";
            // 
            // rbedkun
            // 
            this.rbedkun.AutoSize = true;
            this.rbedkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbedkun.Location = new System.Drawing.Point(166, 118);
            this.rbedkun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbedkun.Name = "rbedkun";
            this.rbedkun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbedkun.Size = new System.Drawing.Size(89, 33);
            this.rbedkun.TabIndex = 0;
            this.rbedkun.TabStop = true;
            this.rbedkun.Text = "עדכון";
            this.rbedkun.UseVisualStyleBackColor = true;
            this.rbedkun.CheckedChanged += new System.EventHandler(this.rbedkun_CheckedChanged);
            // 
            // rbadd
            // 
            this.rbadd.AutoSize = true;
            this.rbadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbadd.Location = new System.Drawing.Point(166, 55);
            this.rbadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbadd.Name = "rbadd";
            this.rbadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbadd.Size = new System.Drawing.Size(97, 33);
            this.rbadd.TabIndex = 0;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "הוספה";
            this.rbadd.UseVisualStyleBackColor = true;
            this.rbadd.CheckedChanged += new System.EventHandler(this.rbadd_CheckedChanged);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(458, 292);
            this.txtfind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfind.Name = "txtfind";
            this.txtfind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfind.Size = new System.Drawing.Size(148, 26);
            this.txtfind.TabIndex = 12;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(662, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "חפש סוג";
            // 
            // dgvKind
            // 
            this.dgvKind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKind.Location = new System.Drawing.Point(303, 349);
            this.dgvKind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKind.Name = "dgvKind";
            this.dgvKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvKind.RowHeadersWidth = 62;
            this.dgvKind.Size = new System.Drawing.Size(656, 474);
            this.dgvKind.TabIndex = 10;
            this.dgvKind.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAuthors_RowHeaderMouseDoubleClick);
            // 
            // frmKindTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 868);
            this.Controls.Add(this.gbMatzav);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKind);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKindTable";
            this.Text = "frmKindTable";
            this.Load += new System.EventHandler(this.frmKindTable_Load);
            this.gbMatzav.ResumeLayout(false);
            this.gbMatzav.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMatzav;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbedkun;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKind;
    }
}
namespace LibreryProject.GUI
{
    partial class frmNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNav));
            this.employee = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.myDetyles = new System.Windows.Forms.TextBox();
            this.books = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.newClient = new System.Windows.Forms.Button();
            this.waitings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.Location = new System.Drawing.Point(867, 492);
            this.employee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(140, 94);
            this.employee.TabIndex = 0;
            this.employee.Text = "עובדים";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.ErrorImage = null;
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(33, 45);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(437, 173);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // myDetyles
            // 
            this.myDetyles.BackColor = System.Drawing.SystemColors.Menu;
            this.myDetyles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myDetyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.myDetyles.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.myDetyles.Location = new System.Drawing.Point(346, 282);
            this.myDetyles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myDetyles.Name = "myDetyles";
            this.myDetyles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.myDetyles.Size = new System.Drawing.Size(476, 82);
            this.myDetyles.TabIndex = 3;
            this.myDetyles.Text = "ספרייה עירונית";
            // 
            // books
            // 
            this.books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.books.Location = new System.Drawing.Point(684, 492);
            this.books.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(140, 94);
            this.books.TabIndex = 4;
            this.books.Text = "ספרים";
            this.books.UseVisualStyleBackColor = true;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // clients
            // 
            this.clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clients.Location = new System.Drawing.Point(511, 492);
            this.clients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(140, 94);
            this.clients.TabIndex = 5;
            this.clients.Text = "לקוחות";
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click);
            // 
            // newClient
            // 
            this.newClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newClient.Location = new System.Drawing.Point(346, 492);
            this.newClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(140, 94);
            this.newClient.TabIndex = 5;
            this.newClient.Text = "הוסף לקוח חדש";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // waitings
            // 
            this.waitings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.waitings.Location = new System.Drawing.Point(168, 492);
            this.waitings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.waitings.Name = "waitings";
            this.waitings.Size = new System.Drawing.Size(140, 94);
            this.waitings.TabIndex = 5;
            this.waitings.Text = "רשימת ממתינים לספר";
            this.waitings.UseVisualStyleBackColor = true;
            this.waitings.Click += new System.EventHandler(this.waitings_Click);
            // 
            // frmNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.waitings);
            this.Controls.Add(this.newClient);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.books);
            this.Controls.Add(this.myDetyles);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.employee);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNav";
            this.Text = "frmNav";
            this.Load += new System.EventHandler(this.frmNav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox myDetyles;
        private System.Windows.Forms.Button books;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Button waitings;
    }
}
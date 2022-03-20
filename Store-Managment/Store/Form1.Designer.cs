namespace Store
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.Lusername = new System.Windows.Forms.Label();
            this.Lpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lincorrentPassword = new System.Windows.Forms.Label();
            this.l2PasswordIncorrent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(174, 69);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(240, 35);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "General Store";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(174, 124);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(240, 37);
            this.tbPassword.TabIndex = 2;
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.BackColor = System.Drawing.Color.Transparent;
            this.Lusername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lusername.ForeColor = System.Drawing.Color.Transparent;
            this.Lusername.Location = new System.Drawing.Point(15, 69);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(153, 25);
            this.Lusername.TabIndex = 4;
            this.Lusername.Text = "Enter Username";
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.BackColor = System.Drawing.Color.Transparent;
            this.Lpassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lpassword.ForeColor = System.Drawing.Color.Transparent;
            this.Lpassword.Location = new System.Drawing.Point(15, 124);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(149, 25);
            this.Lpassword.TabIndex = 5;
            this.Lpassword.Text = "Enter Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(214, 206);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(118, 51);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lincorrentPassword
            // 
            this.lincorrentPassword.AutoSize = true;
            this.lincorrentPassword.Location = new System.Drawing.Point(151, 178);
            this.lincorrentPassword.Name = "lincorrentPassword";
            this.lincorrentPassword.Size = new System.Drawing.Size(0, 15);
            this.lincorrentPassword.TabIndex = 7;
            // 
            // l2PasswordIncorrent
            // 
            this.l2PasswordIncorrent.AutoSize = true;
            this.l2PasswordIncorrent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l2PasswordIncorrent.Location = new System.Drawing.Point(212, 176);
            this.l2PasswordIncorrent.Name = "l2PasswordIncorrent";
            this.l2PasswordIncorrent.Size = new System.Drawing.Size(120, 17);
            this.l2PasswordIncorrent.TabIndex = 8;
            this.l2PasswordIncorrent.Text = "Incorrent Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.l2PasswordIncorrent);
            this.panel1.Controls.Add(this.lincorrentPassword);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.Lpassword);
            this.panel1.Controls.Add(this.Lusername);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Location = new System.Drawing.Point(130, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 283);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(708, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbUsername;
        private Label label1;
        private TextBox tbPassword;
        private Label Lusername;
        private Label Lpassword;
        private Button btnlogin;
        private Label lincorrentPassword;
        private Label l2PasswordIncorrent;
        private Panel panel1;
    }
}
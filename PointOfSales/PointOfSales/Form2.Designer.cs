namespace PointOfSales
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.Label();
            this.uPass = new System.Windows.Forms.TextBox();
            this.iLogin = new System.Windows.Forms.Button();
            this.fPassword = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.fPassword);
            this.groupBox1.Controls.Add(this.iLogin);
            this.groupBox1.Controls.Add(this.uPass);
            this.groupBox1.Controls.Add(this.userPassword);
            this.groupBox1.Controls.Add(this.uName);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(214, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS Goods";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Black;
            this.userName.Location = new System.Drawing.Point(139, 128);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(111, 28);
            this.userName.TabIndex = 1;
            this.userName.Text = "Username";
            // 
            // uName
            // 
            this.uName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uName.Location = new System.Drawing.Point(310, 128);
            this.uName.Multiline = true;
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(167, 28);
            this.uName.TabIndex = 2;
            //this.uName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.ForeColor = System.Drawing.Color.Black;
            this.userPassword.Location = new System.Drawing.Point(139, 192);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(104, 28);
            this.userPassword.TabIndex = 3;
            this.userPassword.Text = "Password";
            // 
            // uPass
            // 
            this.uPass.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPass.Location = new System.Drawing.Point(310, 192);
            this.uPass.Multiline = true;
            this.uPass.Name = "uPass";
            this.uPass.Size = new System.Drawing.Size(167, 28);
            this.uPass.TabIndex = 4;
            // 
            // iLogin
            // 
            this.iLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.iLogin.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iLogin.Location = new System.Drawing.Point(498, 262);
            this.iLogin.Name = "iLogin";
            this.iLogin.Size = new System.Drawing.Size(107, 41);
            this.iLogin.TabIndex = 5;
            this.iLogin.Text = "Login";
            this.iLogin.UseVisualStyleBackColor = true;
            this.iLogin.Click += new System.EventHandler(this.iLogin_Click);
            // 
            // fPassword
            // 
            this.fPassword.AutoSize = true;
            this.fPassword.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPassword.Location = new System.Drawing.Point(338, 234);
            this.fPassword.Name = "fPassword";
            this.fPassword.Size = new System.Drawing.Size(110, 18);
            this.fPassword.TabIndex = 1;
            this.fPassword.TabStop = true;
            this.fPassword.Text = "Forgot Credentials?";
            this.fPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fPassword_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(772, 469);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Form2";
            //this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button iLogin;
        private System.Windows.Forms.TextBox uPass;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.LinkLabel fPassword;
    }
}
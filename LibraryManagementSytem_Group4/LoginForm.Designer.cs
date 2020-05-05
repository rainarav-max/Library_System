namespace LibraryManagementSytem_Group4
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rgUserType = new System.Windows.Forms.ComboBox();
            this.lgUserName = new System.Windows.Forms.TextBox();
            this.lgPassword = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.rgPassword = new System.Windows.Forms.TextBox();
            this.rgUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rgFullName = new System.Windows.Forms.TextBox();
            this.rgStudentId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Raptors Library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserType:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // rgUserType
            // 
            this.rgUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rgUserType.FormattingEnabled = true;
            this.rgUserType.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.rgUserType.Location = new System.Drawing.Point(499, 135);
            this.rgUserType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rgUserType.Name = "rgUserType";
            this.rgUserType.Size = new System.Drawing.Size(212, 21);
            this.rgUserType.TabIndex = 4;
            this.rgUserType.SelectedIndexChanged += new System.EventHandler(this.RgUserType_SelectedIndexChanged);
            // 
            // lgUserName
            // 
            this.lgUserName.Location = new System.Drawing.Point(105, 138);
            this.lgUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lgUserName.Name = "lgUserName";
            this.lgUserName.Size = new System.Drawing.Size(212, 20);
            this.lgUserName.TabIndex = 1;
            // 
            // lgPassword
            // 
            this.lgPassword.Location = new System.Drawing.Point(105, 190);
            this.lgPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lgPassword.Name = "lgPassword";
            this.lgPassword.PasswordChar = '*';
            this.lgPassword.Size = new System.Drawing.Size(212, 20);
            this.lgPassword.TabIndex = 2;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(67, 233);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(212, 42);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Register";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(462, 293);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(212, 42);
            this.registerBtn.TabIndex = 14;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // rgPassword
            // 
            this.rgPassword.Location = new System.Drawing.Point(499, 254);
            this.rgPassword.Margin = new System.Windows.Forms.Padding(2);
            this.rgPassword.Name = "rgPassword";
            this.rgPassword.PasswordChar = '*';
            this.rgPassword.Size = new System.Drawing.Size(212, 20);
            this.rgPassword.TabIndex = 8;
            // 
            // rgUserName
            // 
            this.rgUserName.Location = new System.Drawing.Point(499, 225);
            this.rgUserName.Margin = new System.Windows.Forms.Padding(2);
            this.rgUserName.Name = "rgUserName";
            this.rgUserName.Size = new System.Drawing.Size(212, 20);
            this.rgUserName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "UserName:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Full Name:";
            // 
            // rgFullName
            // 
            this.rgFullName.Location = new System.Drawing.Point(499, 197);
            this.rgFullName.Margin = new System.Windows.Forms.Padding(2);
            this.rgFullName.Name = "rgFullName";
            this.rgFullName.Size = new System.Drawing.Size(212, 20);
            this.rgFullName.TabIndex = 6;
            // 
            // rgStudentId
            // 
            this.rgStudentId.Location = new System.Drawing.Point(499, 168);
            this.rgStudentId.Margin = new System.Windows.Forms.Padding(2);
            this.rgStudentId.Name = "rgStudentId";
            this.rgStudentId.ReadOnly = true;
            this.rgStudentId.Size = new System.Drawing.Size(212, 20);
            this.rgStudentId.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Student Id:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 370);
            this.Controls.Add(this.rgStudentId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rgFullName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.rgPassword);
            this.Controls.Add(this.rgUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.lgPassword);
            this.Controls.Add(this.lgUserName);
            this.Controls.Add(this.rgUserType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rgUserType;
        private System.Windows.Forms.TextBox lgUserName;
        private System.Windows.Forms.TextBox lgPassword;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox rgPassword;
        private System.Windows.Forms.TextBox rgUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rgFullName;
        private System.Windows.Forms.TextBox rgStudentId;
        private System.Windows.Forms.Label label10;
    }
}


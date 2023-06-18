namespace PRNProject
{
    partial class Register
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
            txtUsername = new Label();
            lblRegisterPassword = new Label();
            txtRegisterUsername = new TextBox();
            txtRegisterPassword = new TextBox();
            lblRegisterConfirmPassword = new Label();
            txtRegisterConfirmPassword = new TextBox();
            btnCreateAccount = new Button();
            lblRegisterPhoneNumber = new Label();
            txtRegisterPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Location = new Point(149, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(75, 20);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Username";
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.Location = new Point(154, 149);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new Size(70, 20);
            lblRegisterPassword.TabIndex = 1;
            lblRegisterPassword.Text = "Password";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(246, 83);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(323, 27);
            txtRegisterUsername.TabIndex = 2;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(246, 146);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(323, 27);
            txtRegisterPassword.TabIndex = 3;
            // 
            // lblRegisterConfirmPassword
            // 
            lblRegisterConfirmPassword.AutoSize = true;
            lblRegisterConfirmPassword.Location = new Point(97, 224);
            lblRegisterConfirmPassword.Name = "lblRegisterConfirmPassword";
            lblRegisterConfirmPassword.Size = new Size(127, 20);
            lblRegisterConfirmPassword.TabIndex = 4;
            lblRegisterConfirmPassword.Text = "Confirm Password";
            // 
            // txtRegisterConfirmPassword
            // 
            txtRegisterConfirmPassword.Location = new Point(246, 221);
            txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword";
            txtRegisterConfirmPassword.Size = new Size(323, 27);
            txtRegisterConfirmPassword.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(304, 366);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(180, 29);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // lblRegisterPhoneNumber
            // 
            lblRegisterPhoneNumber.AutoSize = true;
            lblRegisterPhoneNumber.Location = new Point(116, 288);
            lblRegisterPhoneNumber.Name = "lblRegisterPhoneNumber";
            lblRegisterPhoneNumber.Size = new Size(108, 20);
            lblRegisterPhoneNumber.TabIndex = 7;
            lblRegisterPhoneNumber.Text = "Phone Number";
            // 
            // txtRegisterPhoneNumber
            // 
            txtRegisterPhoneNumber.Location = new Point(246, 281);
            txtRegisterPhoneNumber.Name = "txtRegisterPhoneNumber";
            txtRegisterPhoneNumber.Size = new Size(323, 27);
            txtRegisterPhoneNumber.TabIndex = 8;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRegisterPhoneNumber);
            Controls.Add(lblRegisterPhoneNumber);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtRegisterConfirmPassword);
            Controls.Add(lblRegisterConfirmPassword);
            Controls.Add(txtRegisterPassword);
            Controls.Add(txtRegisterUsername);
            Controls.Add(lblRegisterPassword);
            Controls.Add(txtUsername);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUsername;
        private Label lblRegisterPassword;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterPassword;
        private Label lblRegisterConfirmPassword;
        private TextBox txtRegisterConfirmPassword;
        private Button btnCreateAccount;
        private Label lblRegisterPhoneNumber;
        private TextBox txtRegisterPhoneNumber;
    }
}
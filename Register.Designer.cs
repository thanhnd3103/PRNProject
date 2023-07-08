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
            lblRegisterUsernameError = new Label();
            lblRegisterPasswordError = new Label();
            lblRegisterConfirmPasswordError = new Label();
            lblRegisterPhoneNumberError = new Label();
            btnBack = new Button();
            lblRegisterAccountSuccess = new Label();
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
            txtRegisterPassword.PasswordChar = '*';
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
            txtRegisterConfirmPassword.PasswordChar = '*';
            txtRegisterConfirmPassword.Size = new Size(323, 27);
            txtRegisterConfirmPassword.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(301, 344);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(180, 29);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
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
            // lblRegisterUsernameError
            // 
            lblRegisterUsernameError.AutoSize = true;
            lblRegisterUsernameError.Location = new Point(246, 123);
            lblRegisterUsernameError.Name = "lblRegisterUsernameError";
            lblRegisterUsernameError.Size = new Size(0, 20);
            lblRegisterUsernameError.TabIndex = 9;
            // 
            // lblRegisterPasswordError
            // 
            lblRegisterPasswordError.AutoSize = true;
            lblRegisterPasswordError.Location = new Point(246, 185);
            lblRegisterPasswordError.Name = "lblRegisterPasswordError";
            lblRegisterPasswordError.Size = new Size(0, 20);
            lblRegisterPasswordError.TabIndex = 10;
            // 
            // lblRegisterConfirmPasswordError
            // 
            lblRegisterConfirmPasswordError.AutoSize = true;
            lblRegisterConfirmPasswordError.Location = new Point(246, 251);
            lblRegisterConfirmPasswordError.Name = "lblRegisterConfirmPasswordError";
            lblRegisterConfirmPasswordError.Size = new Size(0, 20);
            lblRegisterConfirmPasswordError.TabIndex = 11;
            // 
            // lblRegisterPhoneNumberError
            // 
            lblRegisterPhoneNumberError.AutoSize = true;
            lblRegisterPhoneNumberError.Location = new Point(246, 322);
            lblRegisterPhoneNumberError.Name = "lblRegisterPhoneNumberError";
            lblRegisterPhoneNumberError.Size = new Size(0, 20);
            lblRegisterPhoneNumberError.TabIndex = 12;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblRegisterAccountSuccess
            // 
            lblRegisterAccountSuccess.AutoSize = true;
            lblRegisterAccountSuccess.Location = new Point(301, 389);
            lblRegisterAccountSuccess.Name = "lblRegisterAccountSuccess";
            lblRegisterAccountSuccess.Size = new Size(0, 20);
            lblRegisterAccountSuccess.TabIndex = 14;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegisterAccountSuccess);
            Controls.Add(btnBack);
            Controls.Add(lblRegisterPhoneNumberError);
            Controls.Add(lblRegisterConfirmPasswordError);
            Controls.Add(lblRegisterPasswordError);
            Controls.Add(lblRegisterUsernameError);
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
        private Label lblRegisterUsernameError;
        private Label lblRegisterPasswordError;
        private Label lblRegisterConfirmPasswordError;
        private Label lblRegisterPhoneNumberError;
        private Button btnBack;
        private Label lblRegisterAccountSuccess;
    }
}
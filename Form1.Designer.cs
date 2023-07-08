namespace PRNProject
{
    partial class Form1
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
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            bttNew = new Button();
            bttSave = new Button();
            bttDelete = new Button();
            label3 = new Label();
            lbUsername = new Label();
            lbMarkDown = new LinkLabel();
            lbPlan = new LinkLabel();
            lbMusic = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(11, 41);
            txtTitle.Margin = new Padding(2, 3, 2, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(279, 23);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Message:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(11, 96);
            txtMessage.Margin = new Padding(2, 3, 2, 3);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(279, 137);
            txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, Message });
            dataGridView1.Location = new Point(342, 1);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(504, 586);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Width = 200;
            // 
            // Message
            // 
            Message.DataPropertyName = "Message";
            Message.HeaderText = "Message";
            Message.Name = "Message";
            Message.ReadOnly = true;
            Message.Width = 300;
            // 
            // bttNew
            // 
            bttNew.Location = new Point(10, 260);
            bttNew.Margin = new Padding(2, 3, 2, 3);
            bttNew.Name = "bttNew";
            bttNew.Size = new Size(65, 25);
            bttNew.TabIndex = 5;
            bttNew.Text = "New";
            bttNew.UseVisualStyleBackColor = true;
            bttNew.Click += bttNew_Click;
            // 
            // bttSave
            // 
            bttSave.Location = new Point(79, 260);
            bttSave.Margin = new Padding(2, 3, 2, 3);
            bttSave.Name = "bttSave";
            bttSave.Size = new Size(65, 25);
            bttSave.TabIndex = 6;
            bttSave.Text = "Save";
            bttSave.UseVisualStyleBackColor = true;
            bttSave.Click += bttSave_Click;
            // 
            // bttDelete
            // 
            bttDelete.Location = new Point(213, 260);
            bttDelete.Margin = new Padding(2, 3, 2, 3);
            bttDelete.Name = "bttDelete";
            bttDelete.Size = new Size(65, 25);
            bttDelete.TabIndex = 8;
            bttDelete.Text = "Delete";
            bttDelete.UseVisualStyleBackColor = true;
            bttDelete.Click += bttDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 559);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 9;
            label3.Text = "You login as:";
            label3.Click += label3_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(94, 559);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(64, 17);
            lbUsername.TabIndex = 10;
            lbUsername.Text = "Username";
            lbUsername.Click += lbUsername_Click;
            // 
            // lbMarkDown
            // 
            lbMarkDown.AutoSize = true;
            lbMarkDown.Location = new Point(860, 21);
            lbMarkDown.Name = "lbMarkDown";
            lbMarkDown.Size = new Size(71, 17);
            lbMarkDown.TabIndex = 11;
            lbMarkDown.TabStop = true;
            lbMarkDown.Text = "Mark Down";
            lbMarkDown.LinkClicked += lbMarkDown_LinkClicked;
            // 
            // lbPlan
            // 
            lbPlan.AutoSize = true;
            lbPlan.Location = new Point(867, 64);
            lbPlan.Name = "lbPlan";
            lbPlan.Size = new Size(50, 17);
            lbPlan.TabIndex = 12;
            lbPlan.TabStop = true;
            lbPlan.Text = "Planed";
            lbPlan.LinkClicked += lbPlan_LinkClicked;
            // 
            // lbMusic
            // 
            lbMusic.AutoSize = true;
            lbMusic.Location = new Point(851, 99);
            lbMusic.Name = "lbMusic";
            lbMusic.Size = new Size(92, 17);
            lbMusic.TabIndex = 13;
            lbMusic.TabStop = true;
            lbMusic.Text = "Music Player";
            lbMusic.LinkClicked += lbMusic_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(867, 139);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 17);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Pomodoro";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(164, 556);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 556);
            button2.Name = "button2";
            button2.Size = new Size(73, 23);
            button2.TabIndex = 16;
            button2.Text = "Sign Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 599);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(lbMusic);
            Controls.Add(lbPlan);
            Controls.Add(lbMarkDown);
            Controls.Add(lbUsername);
            Controls.Add(label3);
            Controls.Add(bttDelete);
            Controls.Add(bttSave);
            Controls.Add(bttNew);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Temporary Note-taking App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Button bttRead;
        private System.Windows.Forms.Button bttDelete;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Message;
        private DataGridViewTextBoxColumn DateTime;
        private Label label3;
        private Label lbUsername;
        private LinkLabel lbMarkDown;
        private LinkLabel lbPlan;
        private LinkLabel lbMusic;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
    }
}


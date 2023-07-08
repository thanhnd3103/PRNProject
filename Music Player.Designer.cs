namespace PRNProject
{
    partial class Music_Player
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
            lblCurrentMusicFolder = new Label();
            lbSongList = new ListBox();
            label1 = new Label();
            ptrbBrowse = new PictureBox();
            ptrbPlay = new PictureBox();
            ptrbStop = new PictureBox();
            ptrbRandomize = new PictureBox();
            folderBrowserDialog = new FolderBrowserDialog();
            ptrbBackward = new PictureBox();
            ptrbForward = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ptrbBrowse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrbPlay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrbStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrbRandomize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrbBackward).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrbForward).BeginInit();
            SuspendLayout();
            // 
            // lblCurrentMusicFolder
            // 
            lblCurrentMusicFolder.AutoSize = true;
            lblCurrentMusicFolder.Location = new Point(88, 19);
            lblCurrentMusicFolder.Name = "lblCurrentMusicFolder";
            lblCurrentMusicFolder.Size = new Size(155, 17);
            lblCurrentMusicFolder.TabIndex = 3;
            lblCurrentMusicFolder.Text = "Current Music Folder:";
            // 
            // lbSongList
            // 
            lbSongList.FormattingEnabled = true;
            lbSongList.ItemHeight = 17;
            lbSongList.Location = new Point(88, 75);
            lbSongList.Name = "lbSongList";
            lbSongList.Size = new Size(536, 174);
            lbSongList.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 46);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 5;
            label1.Text = "Songs:";
            // 
            // ptrbBrowse
            // 
            ptrbBrowse.Image = Properties.Resources.pngwing_com__3_;
            ptrbBrowse.Location = new Point(44, 287);
            ptrbBrowse.Name = "ptrbBrowse";
            ptrbBrowse.Size = new Size(44, 42);
            ptrbBrowse.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrbBrowse.TabIndex = 6;
            ptrbBrowse.TabStop = false;
            ptrbBrowse.Click += ptrbBrowse_Click;
            // 
            // ptrbPlay
            // 
            ptrbPlay.Image = Properties.Resources.pngwing_com__1_;
            ptrbPlay.Location = new Point(342, 287);
            ptrbPlay.Name = "ptrbPlay";
            ptrbPlay.Size = new Size(44, 42);
            ptrbPlay.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrbPlay.TabIndex = 7;
            ptrbPlay.TabStop = false;
            ptrbPlay.Click += ptrbPlay_Click;
            // 
            // ptrbStop
            // 
            ptrbStop.Image = Properties.Resources.pngwing_com__2_;
            ptrbStop.Location = new Point(454, 287);
            ptrbStop.Name = "ptrbStop";
            ptrbStop.Size = new Size(44, 42);
            ptrbStop.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrbStop.TabIndex = 8;
            ptrbStop.TabStop = false;
            ptrbStop.Click += ptrbStop_Click;
            // 
            // ptrbRandomize
            // 
            ptrbRandomize.Image = Properties.Resources.pngwing_com;
            ptrbRandomize.Location = new Point(135, 287);
            ptrbRandomize.Name = "ptrbRandomize";
            ptrbRandomize.Size = new Size(44, 42);
            ptrbRandomize.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrbRandomize.TabIndex = 9;
            ptrbRandomize.TabStop = false;
            ptrbRandomize.Click += ptrbRandomize_Click;
            // 
            // ptrbBackward
            // 
            ptrbBackward.Image = Properties.Resources.pngwing_com__5_;
            ptrbBackward.Location = new Point(230, 287);
            ptrbBackward.Name = "ptrbBackward";
            ptrbBackward.Size = new Size(44, 42);
            ptrbBackward.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrbBackward.TabIndex = 10;
            ptrbBackward.TabStop = false;
            ptrbBackward.Click += ptrbBackward_Click;
            // 
            // ptrbForward
            // 
            ptrbForward.Image = Properties.Resources.pngwing_com__4_;
            ptrbForward.Location = new Point(580, 287);
            ptrbForward.Name = "ptrbForward";
            ptrbForward.Size = new Size(44, 42);
            ptrbForward.SizeMode = PictureBoxSizeMode.StretchImage;
            ptrbForward.TabIndex = 11;
            ptrbForward.TabStop = false;
            ptrbForward.Click += ptrbForward_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Music_Player
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(button1);
            Controls.Add(ptrbForward);
            Controls.Add(ptrbBackward);
            Controls.Add(ptrbRandomize);
            Controls.Add(ptrbStop);
            Controls.Add(ptrbPlay);
            Controls.Add(ptrbBrowse);
            Controls.Add(label1);
            Controls.Add(lbSongList);
            Controls.Add(lblCurrentMusicFolder);
            Name = "Music_Player";
            Text = "Music_Player";
            ((System.ComponentModel.ISupportInitialize)ptrbBrowse).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrbPlay).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrbStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrbRandomize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrbBackward).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrbForward).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCurrentMusicFolder;
        private ListBox lbSongList;
        private Label label1;
        private PictureBox ptrbBrowse;
        private PictureBox ptrbPlay;
        private PictureBox ptrbStop;
        private PictureBox ptrbRandomize;
        private FolderBrowserDialog folderBrowserDialog;
        private PictureBox ptrbBackward;
        private PictureBox ptrbForward;
        private Button button1;
    }
}
namespace B15_Ex01_Ziv_302678313_Guy_200433423
{
    partial class FormFaceBookApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaceBookApp));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelMind = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelGroups = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelUserDetails = new System.Windows.Forms.Label();
            this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
            this.buttonNewsFeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCheckIns = new System.Windows.Forms.ListBox();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.listBoxTopCheckin = new System.Windows.Forms.ListBox();
            this.buttonTopCheckIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.friendsListLabel = new System.Windows.Forms.Label();
            this.buttonUploadPicture = new System.Windows.Forms.Button();
            this.pictureBoxObject = new System.Windows.Forms.PictureBox();
            this.labelObjectDetail = new System.Windows.Forms.Label();
            this.textBoxPicturePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(11, 143);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(50, 29);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // profilePic
            // 
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(11, 27);
            this.profilePic.Margin = new System.Windows.Forms.Padding(2);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(105, 112);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            this.profilePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.AutoSize = true;
            this.profileNameLabel.Location = new System.Drawing.Point(8, 9);
            this.profileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(0, 13);
            this.profileNameLabel.TabIndex = 2;
            this.profileNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(182, 35);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(557, 20);
            this.postTextBox.TabIndex = 3;
            // 
            // buttonPost
            // 
            this.buttonPost.Enabled = false;
            this.buttonPost.Location = new System.Drawing.Point(771, 35);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(62, 24);
            this.buttonPost.TabIndex = 4;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelMind
            // 
            this.labelMind.AutoSize = true;
            this.labelMind.Location = new System.Drawing.Point(179, 20);
            this.labelMind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMind.Name = "labelMind";
            this.labelMind.Size = new System.Drawing.Size(109, 13);
            this.labelMind.TabIndex = 5;
            this.labelMind.Text = "What\'s on your mind?";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(11, 271);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(153, 238);
            this.listBoxGroups.TabIndex = 7;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonEvents
            // 
            this.buttonEvents.Enabled = false;
            this.buttonEvents.Location = new System.Drawing.Point(182, 124);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(103, 22);
            this.buttonEvents.TabIndex = 8;
            this.buttonEvents.Text = "Get events";
            this.buttonEvents.UseVisualStyleBackColor = true;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(289, 100);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(448, 56);
            this.listBoxEvents.TabIndex = 9;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(177, 100);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(108, 13);
            this.labelEvents.TabIndex = 10;
            this.labelEvents.Text = "Press to show events";
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(8, 256);
            this.labelGroups.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(63, 13);
            this.labelGroups.TabIndex = 11;
            this.labelGroups.Text = "Groups List:";
            this.labelGroups.Click += new System.EventHandler(this.labelGroups_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(771, 124);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(128, 290);
            this.listBoxFriends.TabIndex = 14;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelUserDetails
            // 
            this.labelUserDetails.AutoSize = true;
            this.labelUserDetails.Location = new System.Drawing.Point(8, 143);
            this.labelUserDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserDetails.Name = "labelUserDetails";
            this.labelUserDetails.Size = new System.Drawing.Size(0, 13);
            this.labelUserDetails.TabIndex = 18;
            // 
            // listBoxNewsFeed
            // 
            this.listBoxNewsFeed.FormattingEnabled = true;
            this.listBoxNewsFeed.Location = new System.Drawing.Point(289, 169);
            this.listBoxNewsFeed.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNewsFeed.Name = "listBoxNewsFeed";
            this.listBoxNewsFeed.Size = new System.Drawing.Size(448, 56);
            this.listBoxNewsFeed.TabIndex = 19;
            // 
            // buttonNewsFeed
            // 
            this.buttonNewsFeed.Enabled = false;
            this.buttonNewsFeed.Location = new System.Drawing.Point(182, 203);
            this.buttonNewsFeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewsFeed.Name = "buttonNewsFeed";
            this.buttonNewsFeed.Size = new System.Drawing.Size(103, 22);
            this.buttonNewsFeed.TabIndex = 20;
            this.buttonNewsFeed.Text = "Get news feed";
            this.buttonNewsFeed.UseVisualStyleBackColor = true;
            this.buttonNewsFeed.Click += new System.EventHandler(this.buttonNewsFeed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Press to show \r\nnews feed";
            // 
            // listBoxCheckIns
            // 
            this.listBoxCheckIns.FormattingEnabled = true;
            this.listBoxCheckIns.Location = new System.Drawing.Point(289, 236);
            this.listBoxCheckIns.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCheckIns.Name = "listBoxCheckIns";
            this.listBoxCheckIns.Size = new System.Drawing.Size(448, 56);
            this.listBoxCheckIns.TabIndex = 22;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Enabled = false;
            this.buttonCheckIn.Location = new System.Drawing.Point(182, 271);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(103, 22);
            this.buttonCheckIn.TabIndex = 23;
            this.buttonCheckIn.Text = "Get check-in\'s";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Location = new System.Drawing.Point(179, 236);
            this.labelCheckIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(76, 26);
            this.labelCheckIn.TabIndex = 24;
            this.labelCheckIn.Text = "Press to show \r\ncheck-in\'s\r\n";
            // 
            // listBoxTopCheckin
            // 
            this.listBoxTopCheckin.FormattingEnabled = true;
            this.listBoxTopCheckin.Location = new System.Drawing.Point(289, 305);
            this.listBoxTopCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTopCheckin.Name = "listBoxTopCheckin";
            this.listBoxTopCheckin.Size = new System.Drawing.Size(448, 56);
            this.listBoxTopCheckin.TabIndex = 25;
            // 
            // buttonTopCheckIn
            // 
            this.buttonTopCheckIn.Enabled = false;
            this.buttonTopCheckIn.Location = new System.Drawing.Point(182, 339);
            this.buttonTopCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTopCheckIn.Name = "buttonTopCheckIn";
            this.buttonTopCheckIn.Size = new System.Drawing.Size(103, 22);
            this.buttonTopCheckIn.TabIndex = 26;
            this.buttonTopCheckIn.Text = "Get top check-in\'s";
            this.buttonTopCheckIn.UseVisualStyleBackColor = true;
            this.buttonTopCheckIn.Click += new System.EventHandler(this.buttonTopCheckIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "Press to show \r\ntop check-in\'s\r\n";
            // 
            // friendsListLabel
            // 
            this.friendsListLabel.AutoSize = true;
            this.friendsListLabel.Location = new System.Drawing.Point(768, 109);
            this.friendsListLabel.Name = "friendsListLabel";
            this.friendsListLabel.Size = new System.Drawing.Size(63, 13);
            this.friendsListLabel.TabIndex = 30;
            this.friendsListLabel.Text = "Friends List:";
            // 
            // buttonUploadPicture
            // 
            this.buttonUploadPicture.Enabled = false;
            this.buttonUploadPicture.Location = new System.Drawing.Point(183, 60);
            this.buttonUploadPicture.Name = "buttonUploadPicture";
            this.buttonUploadPicture.Size = new System.Drawing.Size(102, 23);
            this.buttonUploadPicture.TabIndex = 32;
            this.buttonUploadPicture.Text = "Upload Picture";
            this.buttonUploadPicture.UseVisualStyleBackColor = true;
            this.buttonUploadPicture.Click += new System.EventHandler(this.buttonUploadPicture_Click);
            // 
            // pictureBoxObject
            // 
            this.pictureBoxObject.Location = new System.Drawing.Point(289, 422);
            this.pictureBoxObject.Name = "pictureBoxObject";
            this.pictureBoxObject.Size = new System.Drawing.Size(100, 88);
            this.pictureBoxObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxObject.TabIndex = 33;
            this.pictureBoxObject.TabStop = false;
            // 
            // labelObjectDetail
            // 
            this.labelObjectDetail.AutoSize = true;
            this.labelObjectDetail.Location = new System.Drawing.Point(423, 429);
            this.labelObjectDetail.Name = "labelObjectDetail";
            this.labelObjectDetail.Size = new System.Drawing.Size(0, 13);
            this.labelObjectDetail.TabIndex = 35;
            // 
            // textBoxPicturePath
            // 
            this.textBoxPicturePath.Enabled = false;
            this.textBoxPicturePath.Location = new System.Drawing.Point(289, 62);
            this.textBoxPicturePath.Name = "textBoxPicturePath";
            this.textBoxPicturePath.Size = new System.Drawing.Size(450, 20);
            this.textBoxPicturePath.TabIndex = 36;
            // 
            // FormFaceBookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(953, 522);
            this.Controls.Add(this.textBoxPicturePath);
            this.Controls.Add(this.labelObjectDetail);
            this.Controls.Add(this.pictureBoxObject);
            this.Controls.Add(this.buttonUploadPicture);
            this.Controls.Add(this.friendsListLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTopCheckIn);
            this.Controls.Add(this.listBoxTopCheckin);
            this.Controls.Add(this.labelCheckIn);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.listBoxCheckIns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewsFeed);
            this.Controls.Add(this.listBoxNewsFeed);
            this.Controls.Add(this.labelUserDetails);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonEvents);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.labelMind);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.profileNameLabel);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFaceBookApp";
            this.Text = "FaceBoock Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Label labelMind;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelUserDetails;
        private System.Windows.Forms.ListBox listBoxNewsFeed;
        private System.Windows.Forms.Button buttonNewsFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCheckIns;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.ListBox listBoxTopCheckin;
        private System.Windows.Forms.Button buttonTopCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label friendsListLabel;
        private System.Windows.Forms.Button buttonUploadPicture;
        private System.Windows.Forms.PictureBox pictureBoxObject;
        private System.Windows.Forms.Label labelObjectDetail;
        private System.Windows.Forms.TextBox textBoxPicturePath;
    }
}


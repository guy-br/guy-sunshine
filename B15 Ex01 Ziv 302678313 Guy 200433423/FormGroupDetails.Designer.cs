namespace B15_Ex01_Ziv_302678313_Guy_200433423
{
    partial class FormGroupDetails
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
            this.listBoxGroupMembers = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelGroupDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGroupMembers
            // 
            this.listBoxGroupMembers.FormattingEnabled = true;
            this.listBoxGroupMembers.Location = new System.Drawing.Point(12, 95);
            this.listBoxGroupMembers.Name = "listBoxGroupMembers";
            this.listBoxGroupMembers.Size = new System.Drawing.Size(278, 173);
            this.listBoxGroupMembers.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(23, 26);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGroupName.Location = new System.Drawing.Point(41, 13);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(115, 17);
            this.labelGroupName.TabIndex = 2;
            this.labelGroupName.Text = "labelGroupName";
            // 
            // labelGroupDescription
            // 
            this.labelGroupDescription.AutoSize = true;
            this.labelGroupDescription.Location = new System.Drawing.Point(41, 39);
            this.labelGroupDescription.Name = "labelGroupDescription";
            this.labelGroupDescription.Size = new System.Drawing.Size(111, 13);
            this.labelGroupDescription.TabIndex = 3;
            this.labelGroupDescription.Text = "labelGroupDescription";
            // 
            // FormGroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 280);
            this.Controls.Add(this.labelGroupDescription);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listBoxGroupMembers);
            this.Name = "FormGroupDetails";
            this.Text = "Group Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroupMembers;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelGroupDescription;
    }
}
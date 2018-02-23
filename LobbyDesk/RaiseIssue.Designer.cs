namespace LobbyDesk
{
    partial class RaiseIssue
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
            this.RaisedIssueDescriptionLabel = new System.Windows.Forms.Label();
            this.RaisedIssueDescTextBox = new System.Windows.Forms.TextBox();
            this.RaisedIssueTitleLabel = new System.Windows.Forms.Label();
            this.RaisedIssueTitleTextBox = new System.Windows.Forms.TextBox();
            this.RaiseIssueSaveButton = new System.Windows.Forms.Button();
            this.RaiseIssueCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RaisedIssueDescriptionLabel
            // 
            this.RaisedIssueDescriptionLabel.AutoSize = true;
            this.RaisedIssueDescriptionLabel.Location = new System.Drawing.Point(12, 49);
            this.RaisedIssueDescriptionLabel.Name = "RaisedIssueDescriptionLabel";
            this.RaisedIssueDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.RaisedIssueDescriptionLabel.TabIndex = 0;
            this.RaisedIssueDescriptionLabel.Text = "Description";
            // 
            // RaisedIssueDescTextBox
            // 
            this.RaisedIssueDescTextBox.Location = new System.Drawing.Point(12, 65);
            this.RaisedIssueDescTextBox.Multiline = true;
            this.RaisedIssueDescTextBox.Name = "RaisedIssueDescTextBox";
            this.RaisedIssueDescTextBox.Size = new System.Drawing.Size(203, 175);
            this.RaisedIssueDescTextBox.TabIndex = 1;
            this.RaisedIssueDescTextBox.TextChanged += new System.EventHandler(this.RaisedIssueDescTextBox_TextChanged);
            // 
            // RaisedIssueTitleLabel
            // 
            this.RaisedIssueTitleLabel.AutoSize = true;
            this.RaisedIssueTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.RaisedIssueTitleLabel.Name = "RaisedIssueTitleLabel";
            this.RaisedIssueTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.RaisedIssueTitleLabel.TabIndex = 2;
            this.RaisedIssueTitleLabel.Text = "Title";
            // 
            // RaisedIssueTitleTextBox
            // 
            this.RaisedIssueTitleTextBox.Location = new System.Drawing.Point(12, 26);
            this.RaisedIssueTitleTextBox.Name = "RaisedIssueTitleTextBox";
            this.RaisedIssueTitleTextBox.Size = new System.Drawing.Size(203, 20);
            this.RaisedIssueTitleTextBox.TabIndex = 3;
            this.RaisedIssueTitleTextBox.TextChanged += new System.EventHandler(this.RaisedIssueTextBox_TextChanged);
            // 
            // RaiseIssueSaveButton
            // 
            this.RaiseIssueSaveButton.Location = new System.Drawing.Point(140, 259);
            this.RaiseIssueSaveButton.Name = "RaiseIssueSaveButton";
            this.RaiseIssueSaveButton.Size = new System.Drawing.Size(75, 23);
            this.RaiseIssueSaveButton.TabIndex = 4;
            this.RaiseIssueSaveButton.Text = "Save";
            this.RaiseIssueSaveButton.UseVisualStyleBackColor = true;
            this.RaiseIssueSaveButton.Click += new System.EventHandler(this.RaiseIssueSave_Click);
            // 
            // RaiseIssueCancelButton
            // 
            this.RaiseIssueCancelButton.Location = new System.Drawing.Point(59, 259);
            this.RaiseIssueCancelButton.Name = "RaiseIssueCancelButton";
            this.RaiseIssueCancelButton.Size = new System.Drawing.Size(75, 23);
            this.RaiseIssueCancelButton.TabIndex = 5;
            this.RaiseIssueCancelButton.Text = "Cancel";
            this.RaiseIssueCancelButton.UseVisualStyleBackColor = true;
            // 
            // RaiseIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 293);
            this.Controls.Add(this.RaiseIssueCancelButton);
            this.Controls.Add(this.RaiseIssueSaveButton);
            this.Controls.Add(this.RaisedIssueTitleTextBox);
            this.Controls.Add(this.RaisedIssueTitleLabel);
            this.Controls.Add(this.RaisedIssueDescTextBox);
            this.Controls.Add(this.RaisedIssueDescriptionLabel);
            this.Name = "RaiseIssue";
            this.Text = "Raise Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RaisedIssueDescriptionLabel;
        private System.Windows.Forms.TextBox RaisedIssueDescTextBox;
        private System.Windows.Forms.Label RaisedIssueTitleLabel;
        private System.Windows.Forms.TextBox RaisedIssueTitleTextBox;
        private System.Windows.Forms.Button RaiseIssueSaveButton;
        private System.Windows.Forms.Button RaiseIssueCancelButton;
    }
}
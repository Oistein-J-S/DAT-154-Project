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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RaisedIssueTitleLabel = new System.Windows.Forms.Label();
            this.RaisedIssueTextBox = new System.Windows.Forms.TextBox();
            this.RaiseIssueSave = new System.Windows.Forms.Button();
            this.RaiseIssueCancel = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 175);
            this.textBox1.TabIndex = 1;
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
            // RaisedIssueTextBox
            // 
            this.RaisedIssueTextBox.Location = new System.Drawing.Point(12, 26);
            this.RaisedIssueTextBox.Name = "RaisedIssueTextBox";
            this.RaisedIssueTextBox.Size = new System.Drawing.Size(203, 20);
            this.RaisedIssueTextBox.TabIndex = 3;
            // 
            // RaiseIssueSave
            // 
            this.RaiseIssueSave.Location = new System.Drawing.Point(140, 259);
            this.RaiseIssueSave.Name = "RaiseIssueSave";
            this.RaiseIssueSave.Size = new System.Drawing.Size(75, 23);
            this.RaiseIssueSave.TabIndex = 4;
            this.RaiseIssueSave.Text = "Save";
            this.RaiseIssueSave.UseVisualStyleBackColor = true;
            // 
            // RaiseIssueCancel
            // 
            this.RaiseIssueCancel.Location = new System.Drawing.Point(59, 259);
            this.RaiseIssueCancel.Name = "RaiseIssueCancel";
            this.RaiseIssueCancel.Size = new System.Drawing.Size(75, 23);
            this.RaiseIssueCancel.TabIndex = 5;
            this.RaiseIssueCancel.Text = "Cancel";
            this.RaiseIssueCancel.UseVisualStyleBackColor = true;
            // 
            // RaiseIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 293);
            this.Controls.Add(this.RaiseIssueCancel);
            this.Controls.Add(this.RaiseIssueSave);
            this.Controls.Add(this.RaisedIssueTextBox);
            this.Controls.Add(this.RaisedIssueTitleLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RaisedIssueDescriptionLabel);
            this.Name = "RaiseIssue";
            this.Text = "Raise Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RaisedIssueDescriptionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RaisedIssueTitleLabel;
        private System.Windows.Forms.TextBox RaisedIssueTextBox;
        private System.Windows.Forms.Button RaiseIssueSave;
        private System.Windows.Forms.Button RaiseIssueCancel;
    }
}
namespace LobbyDesk
{
    partial class LoadCustomer
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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchResultsListBox = new System.Windows.Forms.ListBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(12, 9);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last name";
            // 
            // LastNameSearchTextBox
            // 
            this.LastNameSearchTextBox.Location = new System.Drawing.Point(15, 25);
            this.LastNameSearchTextBox.Name = "LastNameSearchTextBox";
            this.LastNameSearchTextBox.Size = new System.Drawing.Size(176, 20);
            this.LastNameSearchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(197, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 20);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchResultsListBox
            // 
            this.SearchResultsListBox.FormattingEnabled = true;
            this.SearchResultsListBox.Location = new System.Drawing.Point(15, 51);
            this.SearchResultsListBox.Name = "SearchResultsListBox";
            this.SearchResultsListBox.Size = new System.Drawing.Size(176, 199);
            this.SearchResultsListBox.TabIndex = 3;
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(197, 265);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(75, 20);
            this.LoadDataButton.TabIndex = 4;
            this.LoadDataButton.Text = "Load data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(116, 265);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 20);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // LoadCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.SearchResultsListBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameSearchTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Name = "LoadCustomer";
            this.Text = "Load Customer Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameSearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox SearchResultsListBox;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
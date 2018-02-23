namespace LobbyDesk
{
    partial class RoomServiceOrder
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
            this.RoomServiceItemPickComboBox = new System.Windows.Forms.ComboBox();
            this.RoomServiceItemLabel = new System.Windows.Forms.Label();
            this.RoomServiceItemAddButton = new System.Windows.Forms.Button();
            this.RoomServiceItemListBox = new System.Windows.Forms.ListBox();
            this.RoomServiceItemDeleteButton = new System.Windows.Forms.Button();
            this.RoomServiceAmountLabel = new System.Windows.Forms.Label();
            this.RoomServiceAmountTextBox = new System.Windows.Forms.TextBox();
            this.RoomServiceSaveButton = new System.Windows.Forms.Button();
            this.RoomServiceCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoomServiceItemPickComboBox
            // 
            this.RoomServiceItemPickComboBox.FormattingEnabled = true;
            this.RoomServiceItemPickComboBox.Location = new System.Drawing.Point(12, 31);
            this.RoomServiceItemPickComboBox.Name = "RoomServiceItemPickComboBox";
            this.RoomServiceItemPickComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoomServiceItemPickComboBox.TabIndex = 0;
            // 
            // RoomServiceItemLabel
            // 
            this.RoomServiceItemLabel.AutoSize = true;
            this.RoomServiceItemLabel.Location = new System.Drawing.Point(12, 9);
            this.RoomServiceItemLabel.Name = "RoomServiceItemLabel";
            this.RoomServiceItemLabel.Size = new System.Drawing.Size(27, 13);
            this.RoomServiceItemLabel.TabIndex = 1;
            this.RoomServiceItemLabel.Text = "Item";
            // 
            // RoomServiceItemAddButton
            // 
            this.RoomServiceItemAddButton.Location = new System.Drawing.Point(139, 31);
            this.RoomServiceItemAddButton.Name = "RoomServiceItemAddButton";
            this.RoomServiceItemAddButton.Size = new System.Drawing.Size(75, 23);
            this.RoomServiceItemAddButton.TabIndex = 2;
            this.RoomServiceItemAddButton.Text = "Add";
            this.RoomServiceItemAddButton.UseVisualStyleBackColor = true;
            this.RoomServiceItemAddButton.Click += new System.EventHandler(this.RoomServiceItemAddButton_Click);
            // 
            // RoomServiceItemListBox
            // 
            this.RoomServiceItemListBox.FormattingEnabled = true;
            this.RoomServiceItemListBox.Location = new System.Drawing.Point(12, 69);
            this.RoomServiceItemListBox.Name = "RoomServiceItemListBox";
            this.RoomServiceItemListBox.Size = new System.Drawing.Size(120, 108);
            this.RoomServiceItemListBox.TabIndex = 3;
            // 
            // RoomServiceItemDeleteButton
            // 
            this.RoomServiceItemDeleteButton.Location = new System.Drawing.Point(138, 69);
            this.RoomServiceItemDeleteButton.Name = "RoomServiceItemDeleteButton";
            this.RoomServiceItemDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.RoomServiceItemDeleteButton.TabIndex = 4;
            this.RoomServiceItemDeleteButton.Text = "Delete";
            this.RoomServiceItemDeleteButton.UseVisualStyleBackColor = true;
            this.RoomServiceItemDeleteButton.Click += new System.EventHandler(this.RoomServiceItemDeleteButton_Click);
            // 
            // RoomServiceAmountLabel
            // 
            this.RoomServiceAmountLabel.AutoSize = true;
            this.RoomServiceAmountLabel.Location = new System.Drawing.Point(12, 194);
            this.RoomServiceAmountLabel.Name = "RoomServiceAmountLabel";
            this.RoomServiceAmountLabel.Size = new System.Drawing.Size(43, 13);
            this.RoomServiceAmountLabel.TabIndex = 5;
            this.RoomServiceAmountLabel.Text = "Amount";
            // 
            // RoomServiceAmountTextBox
            // 
            this.RoomServiceAmountTextBox.Location = new System.Drawing.Point(61, 191);
            this.RoomServiceAmountTextBox.Name = "RoomServiceAmountTextBox";
            this.RoomServiceAmountTextBox.Size = new System.Drawing.Size(71, 20);
            this.RoomServiceAmountTextBox.TabIndex = 6;
            // 
            // RoomServiceSaveButton
            // 
            this.RoomServiceSaveButton.Location = new System.Drawing.Point(142, 226);
            this.RoomServiceSaveButton.Name = "RoomServiceSaveButton";
            this.RoomServiceSaveButton.Size = new System.Drawing.Size(75, 23);
            this.RoomServiceSaveButton.TabIndex = 7;
            this.RoomServiceSaveButton.Text = "Save";
            this.RoomServiceSaveButton.UseVisualStyleBackColor = true;
            this.RoomServiceSaveButton.Click += new System.EventHandler(this.RoomServiceSaveButton_Click);
            // 
            // RoomServiceCancelButton
            // 
            this.RoomServiceCancelButton.Location = new System.Drawing.Point(61, 226);
            this.RoomServiceCancelButton.Name = "RoomServiceCancelButton";
            this.RoomServiceCancelButton.Size = new System.Drawing.Size(75, 23);
            this.RoomServiceCancelButton.TabIndex = 8;
            this.RoomServiceCancelButton.Text = "Cancel";
            this.RoomServiceCancelButton.UseVisualStyleBackColor = true;
            this.RoomServiceCancelButton.Click += new System.EventHandler(this.RoomServiceCancelButton_Click);
            // 
            // RoomServiceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 261);
            this.Controls.Add(this.RoomServiceCancelButton);
            this.Controls.Add(this.RoomServiceSaveButton);
            this.Controls.Add(this.RoomServiceAmountTextBox);
            this.Controls.Add(this.RoomServiceAmountLabel);
            this.Controls.Add(this.RoomServiceItemDeleteButton);
            this.Controls.Add(this.RoomServiceItemListBox);
            this.Controls.Add(this.RoomServiceItemAddButton);
            this.Controls.Add(this.RoomServiceItemLabel);
            this.Controls.Add(this.RoomServiceItemPickComboBox);
            this.Name = "RoomServiceOrder";
            this.Text = "Room service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RoomServiceItemPickComboBox;
        private System.Windows.Forms.Label RoomServiceItemLabel;
        private System.Windows.Forms.Button RoomServiceItemAddButton;
        private System.Windows.Forms.ListBox RoomServiceItemListBox;
        private System.Windows.Forms.Button RoomServiceItemDeleteButton;
        private System.Windows.Forms.Label RoomServiceAmountLabel;
        private System.Windows.Forms.TextBox RoomServiceAmountTextBox;
        private System.Windows.Forms.Button RoomServiceSaveButton;
        private System.Windows.Forms.Button RoomServiceCancelButton;
    }
}
namespace LobbyDesk
{
    partial class MainviewForm
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
            this.CheckInTodayListBox = new System.Windows.Forms.ListBox();
            this.CheckInTodayLAbel = new System.Windows.Forms.Label();
            this.CheckOutTodayListBox = new System.Windows.Forms.ListBox();
            this.CheckOutTodayLabel = new System.Windows.Forms.Label();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.NewBookingButton = new System.Windows.Forms.Button();
            this.SearchBookingButton = new System.Windows.Forms.Button();
            this.RemoveBookingButton = new System.Windows.Forms.Button();
            this.ViewBookingButton = new System.Windows.Forms.Button();
            this.RoomServiceButton = new System.Windows.Forms.Button();
            this.RegisterMaintReqButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckInTodayListBox
            // 
            this.CheckInTodayListBox.FormattingEnabled = true;
            this.CheckInTodayListBox.Location = new System.Drawing.Point(26, 54);
            this.CheckInTodayListBox.Name = "CheckInTodayListBox";
            this.CheckInTodayListBox.Size = new System.Drawing.Size(258, 394);
            this.CheckInTodayListBox.TabIndex = 0;
            // 
            // CheckInTodayLAbel
            // 
            this.CheckInTodayLAbel.AutoSize = true;
            this.CheckInTodayLAbel.Location = new System.Drawing.Point(23, 38);
            this.CheckInTodayLAbel.Name = "CheckInTodayLAbel";
            this.CheckInTodayLAbel.Size = new System.Drawing.Size(91, 13);
            this.CheckInTodayLAbel.TabIndex = 1;
            this.CheckInTodayLAbel.Text = "Todays check-ins";
            // 
            // CheckOutTodayListBox
            // 
            this.CheckOutTodayListBox.FormattingEnabled = true;
            this.CheckOutTodayListBox.Location = new System.Drawing.Point(311, 54);
            this.CheckOutTodayListBox.Name = "CheckOutTodayListBox";
            this.CheckOutTodayListBox.Size = new System.Drawing.Size(258, 394);
            this.CheckOutTodayListBox.TabIndex = 2;
            // 
            // CheckOutTodayLabel
            // 
            this.CheckOutTodayLabel.AutoSize = true;
            this.CheckOutTodayLabel.Location = new System.Drawing.Point(308, 38);
            this.CheckOutTodayLabel.Name = "CheckOutTodayLabel";
            this.CheckOutTodayLabel.Size = new System.Drawing.Size(98, 13);
            this.CheckOutTodayLabel.TabIndex = 3;
            this.CheckOutTodayLabel.Text = "Todays check-outs";
            // 
            // CheckInButton
            // 
            this.CheckInButton.Location = new System.Drawing.Point(605, 83);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(127, 23);
            this.CheckInButton.TabIndex = 4;
            this.CheckInButton.Text = "Check in";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(605, 112);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(127, 23);
            this.CheckOutButton.TabIndex = 5;
            this.CheckOutButton.Text = "Check out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            // 
            // NewBookingButton
            // 
            this.NewBookingButton.Location = new System.Drawing.Point(605, 199);
            this.NewBookingButton.Name = "NewBookingButton";
            this.NewBookingButton.Size = new System.Drawing.Size(127, 23);
            this.NewBookingButton.TabIndex = 6;
            this.NewBookingButton.Text = "New booking...";
            this.NewBookingButton.UseVisualStyleBackColor = true;
            this.NewBookingButton.Click += new System.EventHandler(this.NewBookingButton_Click);
            // 
            // SearchBookingButton
            // 
            this.SearchBookingButton.Location = new System.Drawing.Point(605, 170);
            this.SearchBookingButton.Name = "SearchBookingButton";
            this.SearchBookingButton.Size = new System.Drawing.Size(127, 23);
            this.SearchBookingButton.TabIndex = 7;
            this.SearchBookingButton.Text = "Search bookings...";
            this.SearchBookingButton.UseVisualStyleBackColor = true;
            // 
            // RemoveBookingButton
            // 
            this.RemoveBookingButton.Location = new System.Drawing.Point(605, 141);
            this.RemoveBookingButton.Name = "RemoveBookingButton";
            this.RemoveBookingButton.Size = new System.Drawing.Size(127, 23);
            this.RemoveBookingButton.TabIndex = 8;
            this.RemoveBookingButton.Text = "Delete booking";
            this.RemoveBookingButton.UseVisualStyleBackColor = true;
            // 
            // ViewBookingButton
            // 
            this.ViewBookingButton.Location = new System.Drawing.Point(605, 54);
            this.ViewBookingButton.Name = "ViewBookingButton";
            this.ViewBookingButton.Size = new System.Drawing.Size(127, 23);
            this.ViewBookingButton.TabIndex = 9;
            this.ViewBookingButton.Text = "View booking";
            this.ViewBookingButton.UseVisualStyleBackColor = true;
            this.ViewBookingButton.Click += new System.EventHandler(this.ViewBookingButton_Click);
            // 
            // RoomServiceButton
            // 
            this.RoomServiceButton.Location = new System.Drawing.Point(605, 228);
            this.RoomServiceButton.Name = "RoomServiceButton";
            this.RoomServiceButton.Size = new System.Drawing.Size(127, 23);
            this.RoomServiceButton.TabIndex = 10;
            this.RoomServiceButton.Text = "Register room service...";
            this.RoomServiceButton.UseVisualStyleBackColor = true;
            this.RoomServiceButton.Click += new System.EventHandler(this.RoomServiceButton_Click);
            // 
            // RegisterMaintReqButton
            // 
            this.RegisterMaintReqButton.Location = new System.Drawing.Point(605, 257);
            this.RegisterMaintReqButton.Name = "RegisterMaintReqButton";
            this.RegisterMaintReqButton.Size = new System.Drawing.Size(127, 23);
            this.RegisterMaintReqButton.TabIndex = 11;
            this.RegisterMaintReqButton.Text = "Register maint. req.";
            this.RegisterMaintReqButton.UseVisualStyleBackColor = true;
            this.RegisterMaintReqButton.Click += new System.EventHandler(this.RegisterMaintReqButton_Click);
            // 
            // MainviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 475);
            this.Controls.Add(this.RegisterMaintReqButton);
            this.Controls.Add(this.RoomServiceButton);
            this.Controls.Add(this.ViewBookingButton);
            this.Controls.Add(this.RemoveBookingButton);
            this.Controls.Add(this.SearchBookingButton);
            this.Controls.Add(this.NewBookingButton);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.CheckOutTodayLabel);
            this.Controls.Add(this.CheckOutTodayListBox);
            this.Controls.Add(this.CheckInTodayLAbel);
            this.Controls.Add(this.CheckInTodayListBox);
            this.Name = "MainviewForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CheckInTodayListBox;
        private System.Windows.Forms.Label CheckInTodayLAbel;
        private System.Windows.Forms.ListBox CheckOutTodayListBox;
        private System.Windows.Forms.Label CheckOutTodayLabel;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button NewBookingButton;
        private System.Windows.Forms.Button SearchBookingButton;
        private System.Windows.Forms.Button RemoveBookingButton;
        private System.Windows.Forms.Button ViewBookingButton;
        private System.Windows.Forms.Button RoomServiceButton;
        private System.Windows.Forms.Button RegisterMaintReqButton;
    }
}


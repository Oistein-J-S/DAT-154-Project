namespace LobbyDesk
{
    partial class BookingForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RoomNoLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.BookingIdTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.BookingIdLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.CheckOutDateLabel = new System.Windows.Forms.Label();
            this.CheckInDateLabel = new System.Windows.Forms.Label();
            this.BookingBalanceTextBox = new System.Windows.Forms.TextBox();
            this.BookingBalanceLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RoomTypeLabel = new System.Windows.Forms.Label();
            this.RoomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoadCustomerButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.RoomNoLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CustomerIdLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BookingIdTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CustomerIdTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BookingIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LastNameTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LastNameLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CheckOutDateLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.CheckInDateLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.BookingBalanceTextBox, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.BookingBalanceLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.RoomTypeLabel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.RoomTypeComboBox, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 183);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // RoomNoLabel
            // 
            this.RoomNoLabel.AutoSize = true;
            this.RoomNoLabel.Location = new System.Drawing.Point(303, 0);
            this.RoomNoLabel.Name = "RoomNoLabel";
            this.RoomNoLabel.Size = new System.Drawing.Size(53, 13);
            this.RoomNoLabel.TabIndex = 16;
            this.RoomNoLabel.Text = "Room no.";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Location = new System.Drawing.Point(153, 0);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIdLabel.TabIndex = 4;
            this.CustomerIdLabel.Text = "Customer ID";
            // 
            // BookingIdTextBox
            // 
            this.BookingIdTextBox.Location = new System.Drawing.Point(3, 28);
            this.BookingIdTextBox.Name = "BookingIdTextBox";
            this.BookingIdTextBox.Size = new System.Drawing.Size(144, 20);
            this.BookingIdTextBox.TabIndex = 2;
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(153, 28);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(144, 20);
            this.CustomerIdTextBox.TabIndex = 1;
            // 
            // BookingIdLabel
            // 
            this.BookingIdLabel.AutoSize = true;
            this.BookingIdLabel.Location = new System.Drawing.Point(3, 0);
            this.BookingIdLabel.Name = "BookingIdLabel";
            this.BookingIdLabel.Size = new System.Drawing.Size(60, 13);
            this.BookingIdLabel.TabIndex = 3;
            this.BookingIdLabel.Text = "Booking ID";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(3, 93);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(153, 93);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 65);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(153, 65);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "Last name";
            // 
            // CheckOutDateLabel
            // 
            this.CheckOutDateLabel.AutoSize = true;
            this.CheckOutDateLabel.Location = new System.Drawing.Point(153, 130);
            this.CheckOutDateLabel.Name = "CheckOutDateLabel";
            this.CheckOutDateLabel.Size = new System.Drawing.Size(80, 13);
            this.CheckOutDateLabel.TabIndex = 12;
            this.CheckOutDateLabel.Text = "Check out date";
            // 
            // CheckInDateLabel
            // 
            this.CheckInDateLabel.AutoSize = true;
            this.CheckInDateLabel.Location = new System.Drawing.Point(3, 130);
            this.CheckInDateLabel.Name = "CheckInDateLabel";
            this.CheckInDateLabel.Size = new System.Drawing.Size(73, 13);
            this.CheckInDateLabel.TabIndex = 11;
            this.CheckInDateLabel.Text = "Check in date";
            // 
            // BookingBalanceTextBox
            // 
            this.BookingBalanceTextBox.Location = new System.Drawing.Point(303, 93);
            this.BookingBalanceTextBox.Name = "BookingBalanceTextBox";
            this.BookingBalanceTextBox.Size = new System.Drawing.Size(144, 20);
            this.BookingBalanceTextBox.TabIndex = 13;
            // 
            // BookingBalanceLabel
            // 
            this.BookingBalanceLabel.AutoSize = true;
            this.BookingBalanceLabel.Location = new System.Drawing.Point(303, 65);
            this.BookingBalanceLabel.Name = "BookingBalanceLabel";
            this.BookingBalanceLabel.Size = new System.Drawing.Size(87, 13);
            this.BookingBalanceLabel.TabIndex = 14;
            this.BookingBalanceLabel.Text = "Booking balance";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(303, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 15;
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Location = new System.Drawing.Point(303, 130);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.RoomTypeLabel.TabIndex = 20;
            this.RoomTypeLabel.Text = "Room type";
            // 
            // RoomTypeComboBox
            // 
            this.RoomTypeComboBox.FormattingEnabled = true;
            this.RoomTypeComboBox.Location = new System.Drawing.Point(303, 158);
            this.RoomTypeComboBox.Name = "RoomTypeComboBox";
            this.RoomTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoomTypeComboBox.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(153, 158);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(379, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(298, 226);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // LoadCustomerButton
            // 
            this.LoadCustomerButton.Location = new System.Drawing.Point(196, 226);
            this.LoadCustomerButton.Name = "LoadCustomerButton";
            this.LoadCustomerButton.Size = new System.Drawing.Size(96, 23);
            this.LoadCustomerButton.TabIndex = 23;
            this.LoadCustomerButton.Text = "Load Customer...";
            this.LoadCustomerButton.UseVisualStyleBackColor = true;
            this.LoadCustomerButton.Click += new System.EventHandler(this.LoadCustomerButton_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 261);
            this.Controls.Add(this.LoadCustomerButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "BookingForm";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.TextBox BookingIdTextBox;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.Label BookingIdLabel;
        private System.Windows.Forms.Label RoomNoLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label CheckOutDateLabel;
        private System.Windows.Forms.Label CheckInDateLabel;
        private System.Windows.Forms.TextBox BookingBalanceTextBox;
        private System.Windows.Forms.Label BookingBalanceLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label RoomTypeLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox RoomTypeComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button LoadCustomerButton;
    }
}
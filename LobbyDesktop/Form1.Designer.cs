namespace LobbyDesktop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.roomListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkingInTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkingOutTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAllBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomNoLabel = new System.Windows.Forms.Label();
            this.OccupantLabel = new System.Windows.Forms.Label();
            this.CheckInOutLabel = new System.Windows.Forms.Label();
            this.RoomTypeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckInTodayPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckInRoomNoLabel = new System.Windows.Forms.Label();
            this.CheckInGuestLabel = new System.Windows.Forms.Label();
            this.CheckInCheckingOutLabel = new System.Windows.Forms.Label();
            this.RoomListPanel = new System.Windows.Forms.Panel();
            this.CheckOutTodayPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.CheckInTodayPanel.SuspendLayout();
            this.RoomListPanel.SuspendLayout();
            this.CheckOutTodayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomListToolStripMenuItem,
            this.checkingInTodayToolStripMenuItem,
            this.checkingOutTodayToolStripMenuItem,
            this.seeAllBookingsToolStripMenuItem,
            this.makeABookingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // roomListToolStripMenuItem
            // 
            this.roomListToolStripMenuItem.Name = "roomListToolStripMenuItem";
            this.roomListToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.roomListToolStripMenuItem.Text = "Room List";
            this.roomListToolStripMenuItem.Click += new System.EventHandler(this.roomListToolStripMenuItem_Click);
            // 
            // checkingInTodayToolStripMenuItem
            // 
            this.checkingInTodayToolStripMenuItem.Name = "checkingInTodayToolStripMenuItem";
            this.checkingInTodayToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.checkingInTodayToolStripMenuItem.Text = "Checking in today";
            this.checkingInTodayToolStripMenuItem.Click += new System.EventHandler(this.checkingInTodayToolStripMenuItem_Click);
            // 
            // checkingOutTodayToolStripMenuItem
            // 
            this.checkingOutTodayToolStripMenuItem.Name = "checkingOutTodayToolStripMenuItem";
            this.checkingOutTodayToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.checkingOutTodayToolStripMenuItem.Text = "Checking out today";
            this.checkingOutTodayToolStripMenuItem.Click += new System.EventHandler(this.checkingOutTodayToolStripMenuItem_Click);
            // 
            // seeAllBookingsToolStripMenuItem
            // 
            this.seeAllBookingsToolStripMenuItem.Name = "seeAllBookingsToolStripMenuItem";
            this.seeAllBookingsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.seeAllBookingsToolStripMenuItem.Text = "See all bookings";
            this.seeAllBookingsToolStripMenuItem.Click += new System.EventHandler(this.seeAllBookingsToolStripMenuItem_Click);
            // 
            // makeABookingToolStripMenuItem
            // 
            this.makeABookingToolStripMenuItem.Name = "makeABookingToolStripMenuItem";
            this.makeABookingToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.makeABookingToolStripMenuItem.Text = "Make a booking";
            this.makeABookingToolStripMenuItem.Click += new System.EventHandler(this.makeABookingToolStripMenuItem_Click);
            // 
            // RoomNoLabel
            // 
            this.RoomNoLabel.AutoSize = true;
            this.RoomNoLabel.Location = new System.Drawing.Point(9, 46);
            this.RoomNoLabel.Name = "RoomNoLabel";
            this.RoomNoLabel.Size = new System.Drawing.Size(55, 13);
            this.RoomNoLabel.TabIndex = 2;
            this.RoomNoLabel.Text = "Room No.";
            this.RoomNoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // OccupantLabel
            // 
            this.OccupantLabel.AutoSize = true;
            this.OccupantLabel.Location = new System.Drawing.Point(172, 46);
            this.OccupantLabel.Name = "OccupantLabel";
            this.OccupantLabel.Size = new System.Drawing.Size(54, 13);
            this.OccupantLabel.TabIndex = 3;
            this.OccupantLabel.Text = "Occupant";
            this.OccupantLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CheckInOutLabel
            // 
            this.CheckInOutLabel.AutoSize = true;
            this.CheckInOutLabel.Location = new System.Drawing.Point(286, 46);
            this.CheckInOutLabel.Name = "CheckInOutLabel";
            this.CheckInOutLabel.Size = new System.Drawing.Size(89, 13);
            this.CheckInOutLabel.TabIndex = 4;
            this.CheckInOutLabel.Text = "Checking in / out";
            this.CheckInOutLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // RoomTypeLabel
            // 
            this.RoomTypeLabel.AutoSize = true;
            this.RoomTypeLabel.Location = new System.Drawing.Point(79, 46);
            this.RoomTypeLabel.Name = "RoomTypeLabel";
            this.RoomTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.RoomTypeLabel.TabIndex = 5;
            this.RoomTypeLabel.Text = "Type";
            this.RoomTypeLabel.Click += new System.EventHandler(this.RoomTypeLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.44144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.55856F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 547);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // CheckInTodayPanel
            // 
            this.CheckInTodayPanel.Controls.Add(this.RoomListPanel);
            this.CheckInTodayPanel.Controls.Add(this.CheckInCheckingOutLabel);
            this.CheckInTodayPanel.Controls.Add(this.CheckInGuestLabel);
            this.CheckInTodayPanel.Controls.Add(this.CheckInRoomNoLabel);
            this.CheckInTodayPanel.Controls.Add(this.tableLayoutPanel2);
            this.CheckInTodayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckInTodayPanel.Location = new System.Drawing.Point(0, 24);
            this.CheckInTodayPanel.Name = "CheckInTodayPanel";
            this.CheckInTodayPanel.Size = new System.Drawing.Size(1366, 790);
            this.CheckInTodayPanel.TabIndex = 6;
            this.CheckInTodayPanel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.04396F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.95605F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(455, 565);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // CheckInRoomNoLabel
            // 
            this.CheckInRoomNoLabel.AutoSize = true;
            this.CheckInRoomNoLabel.Location = new System.Drawing.Point(22, 38);
            this.CheckInRoomNoLabel.Name = "CheckInRoomNoLabel";
            this.CheckInRoomNoLabel.Size = new System.Drawing.Size(55, 13);
            this.CheckInRoomNoLabel.TabIndex = 1;
            this.CheckInRoomNoLabel.Text = "Room No.";
            this.CheckInRoomNoLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CheckInGuestLabel
            // 
            this.CheckInGuestLabel.AutoSize = true;
            this.CheckInGuestLabel.Location = new System.Drawing.Point(101, 38);
            this.CheckInGuestLabel.Name = "CheckInGuestLabel";
            this.CheckInGuestLabel.Size = new System.Drawing.Size(66, 13);
            this.CheckInGuestLabel.TabIndex = 2;
            this.CheckInGuestLabel.Text = "Guest Name";
            this.CheckInGuestLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // CheckInCheckingOutLabel
            // 
            this.CheckInCheckingOutLabel.AutoSize = true;
            this.CheckInCheckingOutLabel.Location = new System.Drawing.Point(391, 38);
            this.CheckInCheckingOutLabel.Name = "CheckInCheckingOutLabel";
            this.CheckInCheckingOutLabel.Size = new System.Drawing.Size(70, 13);
            this.CheckInCheckingOutLabel.TabIndex = 3;
            this.CheckInCheckingOutLabel.Text = "Checking out";
            this.CheckInCheckingOutLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // RoomListPanel
            // 
            this.RoomListPanel.Controls.Add(this.CheckOutTodayPanel);
            this.RoomListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomListPanel.Location = new System.Drawing.Point(0, 0);
            this.RoomListPanel.Name = "RoomListPanel";
            this.RoomListPanel.Size = new System.Drawing.Size(1366, 790);
            this.RoomListPanel.TabIndex = 4;
            // 
            // CheckOutTodayPanel
            // 
            this.CheckOutTodayPanel.Controls.Add(this.label2);
            this.CheckOutTodayPanel.Controls.Add(this.label3);
            this.CheckOutTodayPanel.Controls.Add(this.tableLayoutPanel3);
            this.CheckOutTodayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckOutTodayPanel.Location = new System.Drawing.Point(0, 0);
            this.CheckOutTodayPanel.Name = "CheckOutTodayPanel";
            this.CheckOutTodayPanel.Size = new System.Drawing.Size(1366, 790);
            this.CheckOutTodayPanel.TabIndex = 0;
            this.CheckOutTodayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckOutTodayPanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Guest Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room No.";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.04396F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.95605F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 49);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(455, 565);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 814);
            this.Controls.Add(this.CheckInTodayPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.RoomTypeLabel);
            this.Controls.Add(this.CheckInOutLabel);
            this.Controls.Add(this.OccupantLabel);
            this.Controls.Add(this.RoomNoLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CheckInTodayPanel.ResumeLayout(false);
            this.CheckInTodayPanel.PerformLayout();
            this.RoomListPanel.ResumeLayout(false);
            this.CheckOutTodayPanel.ResumeLayout(false);
            this.CheckOutTodayPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem roomListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkingInTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkingOutTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeAllBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.Label RoomNoLabel;
        private System.Windows.Forms.Label OccupantLabel;
        private System.Windows.Forms.Label CheckInOutLabel;
        private System.Windows.Forms.Label RoomTypeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel CheckInTodayPanel;
        private System.Windows.Forms.Label CheckInRoomNoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label CheckInGuestLabel;
        private System.Windows.Forms.Label CheckInCheckingOutLabel;
        private System.Windows.Forms.Panel RoomListPanel;
        private System.Windows.Forms.Panel CheckOutTodayPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}


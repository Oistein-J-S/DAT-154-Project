using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LobbyDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RoomListPanel.Controls.Add(tableLayoutPanel1);
            RoomListPanel.Controls.Add(RoomNoLabel);
            RoomListPanel.Controls.Add(RoomTypeLabel);
            RoomListPanel.Controls.Add(OccupantLabel);
            RoomListPanel.Controls.Add(CheckInOutLabel);
            CheckOutTodayPanel.Show();




        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoomTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkingInTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInTodayPanel.Show();
        }

        private void checkingOutTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutTodayPanel.Show();
        }

        private void seeAllBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makeABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RoomListPanel.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void CheckOutTodayPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

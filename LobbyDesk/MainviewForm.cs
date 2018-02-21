using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LobbyDesk
{
    public partial class MainviewForm : Form
    {
        public MainviewForm()
        {
            InitializeComponent();
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewBookingButton_Click(object sender, EventArgs e)
        {
            Form f = new BookingForm();
            f.Show();
        }

        private void NewBookingButton_Click(object sender, EventArgs e)
        {
            Form f = new BookingForm();
            f.Show();
        }

        private void RoomServiceButton_Click(object sender, EventArgs e)
        {
            Form f = new RoomServiceOrder();
            f.Show();
        }

        private void RegisterMaintReqButton_Click(object sender, EventArgs e)
        {
            Form f = new RaiseIssue();
            f.Show();
        }
    }
}

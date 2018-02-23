using ObjectContainerDLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LobbyDesk
{
    public partial class MainviewForm : Form
    {
        public MainviewForm()
        {
            InitializeComponent();



        }
        private void GetCheckOutsToday(object sender, EventArgs e)
        {
            CheckOutTodayListBox.DataSource = (List<Booking>)sender;
        }
        private void GetCheckInsToday(object sender, EventArgs e)
        {
            CheckInTodayListBox.DataSource = (List<Booking>)sender;
        }


        private void CheckInButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewBookingButton_Click(object sender, EventArgs e)
        {
            if (CheckInTodayListBox.SelectedItem != null) { 
                Form f = new BookingForm((Booking) CheckInTodayListBox.SelectedItem);
                f.Show();
            } else if (CheckOutTodayListBox.SelectedItem != null)
            {
                Form f = new BookingForm((Booking)CheckOutTodayListBox.SelectedItem);
                f.Show();
            }
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
            f.TopLevel = false;
            f.Parent = this;
            f.Activate();
            f.Show();
        }

        private void SearchBookingButton_Click(object sender, EventArgs e)
        {
            Form f = new SearchBookings();
            f.Show();
        }

        private void CheckInTodayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckOutTodayListBox.ClearSelected();
        }

        private void CheckOutTodayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInTodayListBox.ClearSelected();
        }
    }
}

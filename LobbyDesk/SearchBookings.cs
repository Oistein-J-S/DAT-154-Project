using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectContainerDLL;

namespace LobbyDesk
{
    public partial class SearchBookings : Form
    {
        public SearchBookings()
        {
            InitializeComponent();
        }

        private void BookingsListBox_MouseDoubleClick (object sender, EventArgs e)
        {
            Form f = new BookingForm((Booking) BookingsListBox.SelectedItem);
            f.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchBookingsToFrom(FromDTP.Value, ToDTP.Value);
        }
        private void SearchBookingsToFrom(DateTime from, DateTime to)
        {

        }
        private void SearchReceiver(object sender, EventArgs e)
        {
            BookingsListBox.DataSource = (List<Booking>)sender;
            BookingsListBox.Refresh();
        }
    }
}

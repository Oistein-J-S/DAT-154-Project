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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }
        public BookingForm(Booking b)
        {
            InitializeComponent();
            FirstNameTextBox.Text = b.customer.FirstName;
            LastNameTextBox.Text = b.customer.LastName;
            CustomerIdTextBox.Text = b.customer.Id.ToString();
            BookingBalanceTextBox.Text = b.Balance.ToString();
            //RoomTypeComboBox.SelectedText =
            BookingIdTextBox.Text = b.BookingId.ToString();
            //RoomNoTextBox.Text = b.

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

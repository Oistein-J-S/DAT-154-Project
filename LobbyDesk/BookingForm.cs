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
        bool newBooking;

        public BookingForm()
        {
            InitializeComponent();
            newBooking = true;
        }
        public BookingForm(Booking b)
        {
            InitializeComponent();
            this.CancelButton = CancelButton;
            this.AcceptButton = SaveButton;
            FirstNameTextBox.Text = b.Customer.FirstName;
            LastNameTextBox.Text = b.Customer.LastName;
            CustomerIdTextBox.Text = b.Customer.Id.ToString();
            BookingBalanceTextBox.Text = b.Balance.ToString();
            //RoomTypeComboBox.SelectedText =
            BookingIdTextBox.Text = b.BookingId.ToString();
            //RoomNoTextBox.Text = b.
            newBooking = false;
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (newBooking)
            {

                //Booking b = new Booking(CustomerId);
            }
            this.Close();


        }

        private void LoadCustomerButton_Click(object sender, EventArgs e)
        {
            LoadCustomer f = new LoadCustomer();
            f.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

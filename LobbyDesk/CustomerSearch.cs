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
    public partial class LoadCustomer : Form
    {
        public LoadCustomer()
        {
            InitializeComponent();
            this.CancelButton = CancelButton;
            this.AcceptButton = LoadDataButton;
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            Customer c = (Customer) SearchResultsListBox.SelectedItem;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // search for last name from customer db
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

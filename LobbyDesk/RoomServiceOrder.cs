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
    public partial class RoomServiceOrder : Form
    {
        List<Item> l;
        int total;
        public RoomServiceOrder()
        {
            InitializeComponent();
            l = new List<Item>();
            total = 0;
            this.CancelButton = RoomServiceCancelButton;
            this.AcceptButton = RoomServiceSaveButton;
        }


        private void RoomServiceSaveButton_Click(object sender, EventArgs e)
        {
            Order o = new Order(l);
        }

        private void RoomServiceItemAddButton_Click(object sender, EventArgs e)
        {
            l.Add((Item) RoomServiceItemPickComboBox.SelectedItem);
            Item i = (Item)RoomServiceItemPickComboBox.SelectedItem;
            total += i.Value;
            RoomServiceAmountTextBox.Update();
        }

    }
}

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
        List<string> l;
        int total;
        public RoomServiceOrder()
        {
            InitializeComponent();
            l = new List<Item>();
            total = 0;
        }


        private void RoomServiceSaveButton_Click(object sender, EventArgs e)
        {
            Order o = new Order(l,total);
        }

        private void RoomServiceItemAddButton_Click(object sender, EventArgs e)
        {
            l.Add(RoomServiceItemPickComboBox.SelectedText);
            total += RoomServiceItemPickComboBox.SelectedItem.Value;
        }
    }
}

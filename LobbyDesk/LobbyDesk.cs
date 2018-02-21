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
    public partial class LobbyDesk : Form
    {
        public LobbyDesk()
        {
            InitializeComponent();
            panel1.Controls.Add(label1_1);
            panel1.Controls.Add(label1_2);
            panel1.Controls.Add(tableLayoutPanel1);

            panel2.Controls.Add(label2_1);
            panel2.Controls.Add(label2_2);
            panel2.Controls.Add(label2_3);
            panel2.Controls.Add(tableLayoutPanel2);

            panel3.Controls.Add(label3_1);
            panel3.Controls.Add(label3_2);
            panel3.Controls.Add(label3_3);
            panel3.Controls.Add(tableLayoutPanel3);


            panel1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void checkingInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;

        }

        private void checkingOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }
    }
}

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
    public partial class RaiseIssue : Form
    {
        public RaiseIssue()
        {
            InitializeComponent();
            this.CancelButton = RaiseIssueCancelButton;
            this.AcceptButton = RaiseIssueSaveButton;
        }

        private void RaisedIssueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RaiseIssueSave_Click(object sender, EventArgs e)
        {
            Issue i = new Issue(RaisedIssueTitleTextBox.Text, RaisedIssueDescTextBox.Text);
            this.Close();
        }

        private void RaisedIssueDescTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RaiseIssueCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

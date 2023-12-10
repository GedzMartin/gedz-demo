using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipz
{
    public partial class FormClientChoice : Form
    {
        public FormClientChoice()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            this.Close();
            formClient.Show();
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            FormWithdrawing formChosingCurrency = new FormWithdrawing();
            this.Close();
            formChosingCurrency.Show();
        }

        private void ShowBalancebutton_Click(object sender, EventArgs e)
        {
            FormShowingBalance formShowingBalance = new FormShowingBalance();
            this.Close();
            formShowingBalance.Show();
        }

        private void TITLE_Click(object sender, EventArgs e)
        {

        }
    }
}

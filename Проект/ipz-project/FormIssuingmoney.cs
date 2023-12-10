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
    public partial class FormIssuingmoney : Form
    {
        public FormIssuingmoney()
        {
            InitializeComponent();
        }

        private void Issuingmoney_KeyDown(object sender, KeyEventArgs e)
        {
            FormStart start = new FormStart();
            this.Close();
            start.Focus();
        }

        private void TITLE_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientChoice formClientChoice = new FormClientChoice();
            this.Hide();
            formClientChoice.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            this.Close();
            formStart.Focus();
        }
    }
}

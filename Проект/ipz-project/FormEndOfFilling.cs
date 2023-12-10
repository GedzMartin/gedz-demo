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
    public partial class FormEndOfFilling : Form
    {
        public FormEndOfFilling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmployeeChoice formEmployeeChoice = new FormEmployeeChoice();
            this.Close();
            formEmployeeChoice.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormStart formStart = new FormStart();
            this.Close();
            formStart.Focus();
        }
    }
}

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
    public partial class FormEmployeeChoice : Form
    {
        public FormEmployeeChoice()
        {
            InitializeComponent();
        }

        private void ShowBalancebutton_Click(object sender, EventArgs e)
        {
            FormShowingCapacity formShowingCapacity = new FormShowingCapacity();
            this.Close();
            formShowingCapacity.Show();
        }

        private void Withdrawbutton_Click(object sender, EventArgs e)
        {
            FormFilling formFilling = new FormFilling();
            this.Close();
            formFilling.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormEmployer formEmployer = new FormEmployer();
            this.Close();
            formEmployer.Show();
        }
    }
}

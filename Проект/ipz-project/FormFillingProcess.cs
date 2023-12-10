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
    public partial class FormFillingProcess : Form
    {
        public FormFillingProcess()
        {
            InitializeComponent();
        }

        private void FormFillingProcess_KeyDown(object sender, KeyEventArgs e)
        {
            FormEndOfFilling formEndOfFilling = new FormEndOfFilling();
            this.Close();
            formEndOfFilling.Show();
        }

        private void TITLE_Click(object sender, EventArgs e)
        {

        }

        private void dialogue_Click(object sender, EventArgs e)
        {

        }
    }
}

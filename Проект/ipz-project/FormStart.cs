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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void TITLE_Click(object sender, EventArgs e)
        {

        }
    }
}

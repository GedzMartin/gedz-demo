using MySql.Data.MySqlClient;
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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String pincode = textBox1.Text;

            ClassDB classDB = new ClassDB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` WHERE `pincode` = @ps", classDB.getConnection());
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = pincode;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                FormClientChoice formClientChoice = new FormClientChoice();
                this.Close();
                formClientChoice.Show();
            }
            else
                MessageBox.Show("Incorrect PIN-CODE");
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

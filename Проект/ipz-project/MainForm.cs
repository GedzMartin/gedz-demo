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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        public void start_Click(object sender, EventArgs e)
        {   
            ClassDB classDB = new ClassDB();

            string phonenumber = textBox1.Text;
            Helper.phonenumber = phonenumber;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = phonenumber;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                FormClient formClient = new FormClient();
                this.Close();
                formClient.Show();
            }
            else
                MessageBox.Show("Client with such phone number doesn`t exist. Try again");
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            FormEmployer formEmployer = new FormEmployer();
            this.Close();
            formEmployer.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

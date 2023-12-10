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
    public partial class FormEmployer : Form
    {
        public FormEmployer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            ClassDB classDB = new ClassDB();
            classDB.openConnection();
            string login = loginBox1.Text;
            Helper.login = login;
            string password = passwordBox1.Text;
            Helper.password = password;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admins` WHERE `login` = @pn AND `password` = @ps", classDB.getConnection());
            command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                FormEmployeeChoice formEmployeeChoice = new FormEmployeeChoice();
                this.Close();
                formEmployeeChoice.Show();
            }
            else
                MessageBox.Show("Incorrect data!");
            classDB.closeConnection();
        }
    }
}

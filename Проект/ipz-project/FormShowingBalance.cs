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
    public partial class FormShowingBalance : Form
    {
        
        public FormShowingBalance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormClientChoice formClientChoice = new FormClientChoice();
            this.Close();
            formClientChoice.Show();
        }
      

private void FormShowingBalance_Load(object sender, EventArgs e)
{
    string number = Helper.phonenumber;
    ClassDB classDB = new ClassDB();
    classDB.openConnection();
    MySqlCommand command1 = new MySqlCommand("SELECT `balanceuah` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
    MySqlCommand command2 = new MySqlCommand("SELECT `balanceeur` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
    MySqlCommand command3 = new MySqlCommand("SELECT `balanceusd` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
    MySqlCommand command4 = new MySqlCommand("SELECT `clientname` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
    MySqlCommand command5 = new MySqlCommand("SELECT `clientsurname` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
    command1.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
    string value1 = command1.ExecuteScalar().ToString();
    command2.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
    string value2 = command2.ExecuteScalar().ToString();
    command3.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
    string value3 = command3.ExecuteScalar().ToString();  
    command4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
    string value4 = command4.ExecuteScalar().ToString();
    command5.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
    string value5 = command5.ExecuteScalar().ToString();
    labelUAH.Text = value1;
    labelEUR.Text = value2;
    labelUSD.Text = value3;
    groupBox1.Text = $"{value4} {value5}";
    classDB.closeConnection();
}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FormShowingCapacity : Form
    {
        public FormShowingCapacity()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormEmployeeChoice formEmployeeChoice = new FormEmployeeChoice();
            this.Close();
            formEmployeeChoice.Show();
        }

        private void FormShowingCapacity_Load(object sender, EventArgs e)
        {
            string name = Helper.nameatm;
            ClassDB classDB = new ClassDB();
            classDB.openConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT `currentuah` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT `currenteur` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT `currentusd` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
            MySqlCommand command4 = new MySqlCommand("SELECT `maxuah` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
            MySqlCommand command5 = new MySqlCommand("SELECT `maxeur` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
            MySqlCommand command6 = new MySqlCommand("SELECT `maxusd` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
            command1.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
            string value1 = command1.ExecuteScalar().ToString();
            command2.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
            string value2 = command2.ExecuteScalar().ToString();
            command3.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
            string value3 = command3.ExecuteScalar().ToString();
            command4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
            string value4 = command4.ExecuteScalar().ToString();
            command5.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
            string value5 = command5.ExecuteScalar().ToString();
            command6.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
            string value6 = command5.ExecuteScalar().ToString();
            labelUAH.Text = $"{value1}/{value4}";
            labelEUR.Text = $"{value2}/{value5}";
            labelUSD.Text = $"{value3}/{value6}";
            classDB.closeConnection();
        }

        private void labelEUR_Click(object sender, EventArgs e)
        {

        }
    }
}

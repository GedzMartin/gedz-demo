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
    public partial class FormFilling : Form
    {
        public FormFilling()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormEmployeeChoice formEmployeeChoice = new FormEmployeeChoice();
            this.Close();
            formEmployeeChoice.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string withdraw = ValuetextBox.Text;
            int tofill;
            if (Int32.TryParse(withdraw, out tofill))
            {
                int currentcapacity;
                int ableinatmuah, ableinatmeur, ableinatmusd;
                int maxinatmuah, maxinatmeur, maxinatmusd;
                string number = Helper.phonenumber;

                ClassDB classDB = new ClassDB();
                classDB.openConnection();

                string name = Helper.nameatm;

                MySqlCommand command_1 = new MySqlCommand("SELECT `currentuah` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
                command_1.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                string value_1 = command_1.ExecuteScalar().ToString();

                MySqlCommand command_2 = new MySqlCommand("SELECT `currenteur` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
                command_2.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                string value_2 = command_2.ExecuteScalar().ToString();

                MySqlCommand command_3 = new MySqlCommand("SELECT `currenteur` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
                command_3.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                string value_3 = command_3.ExecuteScalar().ToString();

                MySqlCommand command_4 = new MySqlCommand("SELECT `maxuah` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
                command_4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                string maxvalue_1 = command_4.ExecuteScalar().ToString();

                MySqlCommand command_5 = new MySqlCommand("SELECT `maxeur` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
                command_5.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                string maxvalue_2 = command_5.ExecuteScalar().ToString();

                MySqlCommand command_6 = new MySqlCommand("SELECT `maxusd` FROM `atmcapacity` WHERE `atm` = @pn", classDB.getConnection());
                command_6.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                string maxvalue_3 = command_6.ExecuteScalar().ToString();

                ableinatmuah = Int32.Parse(value_1);
                ableinatmeur = Int32.Parse(value_2);
                ableinatmusd = Int32.Parse(value_3);
                maxinatmuah = Int32.Parse(maxvalue_1);
                maxinatmeur = Int32.Parse(maxvalue_2);
                maxinatmusd = Int32.Parse(maxvalue_3);
                if (radioButton1.Checked)
                {

                    if (ableinatmuah + tofill <= maxinatmuah)
                    {
                        FormFillingProcess formFillingProcess = new FormFillingProcess();
                        this.Close();
                        formFillingProcess.Show();

                        int balanceuah = ableinatmuah + tofill;

                        MySqlCommand command4 = new MySqlCommand("UPDATE `atmcapacity` SET `currentuah` = @tw WHERE `atmcapacity`.`atm` = @pn;", classDB.getConnection());
                        command4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                        command4.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balanceuah;
                        command4.ExecuteNonQuery();

                    }
                    else
                        MessageBox.Show($"This amount can`t be placed. Max: {maxinatmuah - ableinatmuah}");

                }
                if (radioButton2.Checked) 
                {
                    if (ableinatmeur + tofill <= maxinatmeur)
                    {
                        FormFillingProcess formFillingProcess = new FormFillingProcess();
                        this.Close();
                        formFillingProcess.Show();

                        int balanceeur = ableinatmuah + tofill;

                        MySqlCommand command4 = new MySqlCommand("UPDATE `atmcapacity` SET `currenteur` = @tw WHERE `atmcapacity`.`atm` = @pn;", classDB.getConnection());
                        command4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                        command4.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balanceeur;
                        command4.ExecuteNonQuery();

                    }
                    else
                        MessageBox.Show($"This amount can`t be placed. Max: {maxinatmeur - ableinatmeur}");
                }
                if (radioButton3.Checked) 
                {
                    if (ableinatmusd + tofill <= maxinatmusd)
                    {
                        FormFillingProcess formFillingProcess = new FormFillingProcess();
                        this.Close();
                        formFillingProcess.Show();

                        int balanceusd = ableinatmuah + tofill;

                        MySqlCommand command4 = new MySqlCommand("UPDATE `atmcapacity` SET `currentusd` = @tw WHERE `atmcapacity`.`atm` = @pn;", classDB.getConnection());
                        command4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                        command4.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balanceusd;
                        command4.ExecuteNonQuery();

                    }
                    else
                        MessageBox.Show($"This amount can`t be placed. Max: {maxinatmusd-ableinatmusd}");
                }
            }
            else
                MessageBox.Show("Incorect value");

        }

        private void TITLE_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

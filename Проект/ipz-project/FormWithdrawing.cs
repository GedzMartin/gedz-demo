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
    public partial class FormWithdrawing : Form
    {
        public FormWithdrawing()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormClientChoice formClientChoice = new FormClientChoice();
            this.Close();
            formClientChoice.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string withdraw = ValuetextBox.Text;
            int towithdraw;
            if (Int32.TryParse(withdraw, out towithdraw))
            {

                int abletowithdraw;
                int ableinatmuah,ableinatmeur,ableinatmusd;
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

                ableinatmuah = Int32.Parse(value_1);
                ableinatmeur = Int32.Parse(value_2);
                ableinatmusd = Int32.Parse(value_3);
                if (radioButton1.Checked)
                {
                    MySqlCommand command1 = new MySqlCommand("SELECT `balanceuah` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
                    command1.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
                    string value1 = command1.ExecuteScalar().ToString();

                    abletowithdraw = Int32.Parse(value1);
                    if (ableinatmuah >= towithdraw)
                    {
                        if (abletowithdraw >= towithdraw)
                        {
                            FormIssuingmoney formIssuingmoney = new FormIssuingmoney();
                            this.Close();
                            formIssuingmoney.Show();
                            int balance1 = abletowithdraw - towithdraw;

                            MySqlCommand command4 = new MySqlCommand("UPDATE `clients` SET `balanceuah` = @tw WHERE `clients`.`phonenumber` = @pn;", classDB.getConnection());
                            command4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
                            command4.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balance1;
                            command4.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Not enough money!");
                            goto exit;
                        }
                        int balanceatmuah = ableinatmuah - towithdraw;

                        MySqlCommand command_4 = new MySqlCommand("UPDATE `atmcapacity` SET `currentuah` = @tw WHERE `atmcapacity`.`atm` = @pn;", classDB.getConnection());
                        command_4.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                        command_4.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balanceatmuah;
                        command_4.ExecuteNonQuery();

                    }
                    else
                        MessageBox.Show($"Not enough cash in ATM. Able: {ableinatmuah}");
                }
                if (radioButton2.Checked)
                {
                    MySqlCommand command2 = new MySqlCommand("SELECT `balanceeur` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
                    command2.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
                    string value2 = command2.ExecuteScalar().ToString();

                    abletowithdraw = Int32.Parse(value2);
                    if (ableinatmeur >= towithdraw)
                    {
                        if (abletowithdraw >= towithdraw)
                        {

                            FormIssuingmoney formIssuingmoney = new FormIssuingmoney();
                            this.Close();
                            formIssuingmoney.Show();
                            int balance2 = abletowithdraw - towithdraw;

                            MySqlCommand command5 = new MySqlCommand("UPDATE `clients` SET `balanceeur` = @tw WHERE `clients`.`phonenumber` = @pn;", classDB.getConnection());
                            command5.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
                            command5.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balance2;
                            command5.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Not enough money!");
                            goto exit;
                        }
                        int balanceatmeur = ableinatmeur - towithdraw;

                        MySqlCommand command_5 = new MySqlCommand("UPDATE `atmcapacity` SET `currenteur` = @tw WHERE `atmcapacity`.`atm` = @pn;", classDB.getConnection());
                        command_5.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                        command_5.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balanceatmeur;
                        command_5.ExecuteNonQuery();
                    }
                    else
                        MessageBox.Show($"Not enough cash in ATM. Able: {ableinatmeur}");


                }
                if (radioButton3.Checked)
                {
                    MySqlCommand command3 = new MySqlCommand("SELECT `balanceusd` FROM `clients` WHERE `phonenumber` = @pn", classDB.getConnection());
                    command3.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
                    string value3 = command3.ExecuteScalar().ToString();

                    abletowithdraw = Int32.Parse(value3);
                    if (ableinatmusd >= towithdraw)
                    {
                        if (abletowithdraw >= towithdraw)
                        {
                            FormIssuingmoney formIssuingmoney = new FormIssuingmoney();
                            this.Close();
                            formIssuingmoney.Show();
                            int balance3 = abletowithdraw - towithdraw;

                            MySqlCommand command6 = new MySqlCommand("UPDATE `clients` SET `balanceusd` = @tw WHERE `clients`.`phonenumber` = @pn;", classDB.getConnection());
                            command6.Parameters.Add("@pn", MySqlDbType.VarChar).Value = number;
                            command6.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balance3;
                            command6.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Not enough money!");
                            goto exit;
                        }
                        int balanceatmusd = ableinatmusd - towithdraw;

                        MySqlCommand command_6 = new MySqlCommand("UPDATE `atmcapacity` SET `currentusd` = @tw WHERE `atmcapacity`.`atm` = @pn;", classDB.getConnection());
                        command_6.Parameters.Add("@pn", MySqlDbType.VarChar).Value = name;
                        command_6.Parameters.Add("@tw", MySqlDbType.VarChar).Value = balanceatmusd;
                        command_6.ExecuteNonQuery();
                    }
                    else
                        MessageBox.Show($"Not enough cash in ATM. Able: {ableinatmeur}");

                }
            exit:
                classDB.closeConnection();
            }
            else
                MessageBox.Show("Incorect value");
            
        }

        private void FormWithdrawing_Load(object sender, EventArgs e)
        {

        }
    }
}

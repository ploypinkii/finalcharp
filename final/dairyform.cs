using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace final
{
    public partial class dairyform : UserControl
    {
        public dairyform()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (happybtn.Checked == false && excitedbtn.Checked == false && sadbtn.Checked == false && angrybtn.Checked == false && boredbtn.Checked == false && calmbtn.Checked == false)
            {
                MessageBox.Show("Choose your feeling please");
            }
            if(happybtn.Checked == true || excitedbtn.Checked == true || sadbtn.Checked == true || angrybtn.Checked == true || boredbtn.Checked == true || calmbtn.Checked == true)
            {
                DB db = new DB();

                string date = guna2DateTimePicker1.Text;
                string note = notetextbox.Text;
                string usr = Program.username;
                string emo = Program.emotion;
                string[] datefinal = date.Split('/');
                string dy = datefinal[0];
                string mn = datefinal[1];
                string yr = datefinal[2];

                db.openConnection();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string selectsql = $"SELECT * FROM `dairy` WHERE `user` = \"{Program.username}\" AND `day` = \"{dy}\" AND `month` = \"{mn}\" AND `year` = \"{yr}\"";
                MySqlCommand cmd = new MySqlCommand(selectsql, db.GetConnection());
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count <= 0)
                {
                    db.openConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `dairy`(`user`, `emo`, `day`, `month`, `year`, `note`) VALUES (@usr,@emo,@dy,@mn,@yr,@note)", db.GetConnection());
                command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = usr;
                command.Parameters.Add("@emo", MySqlDbType.VarChar).Value = emo;
                command.Parameters.Add("@dy", MySqlDbType.VarChar).Value = dy;
                command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mn;
                command.Parameters.Add("@yr", MySqlDbType.VarChar).Value = yr;
                command.Parameters.Add("@note", MySqlDbType.Text).Value = note;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                MessageBox.Show("Add dairy successfull!");
                db.closeConnection();
                }
                else
                {
                    MessageBox.Show("You already use to write this diary please write diary in other's day");
                }
            }
        }

        private void happybtn_Click(object sender, EventArgs e)
        {
            Program.emotion = "Happy";
        }

        private void excitedbtn_Click(object sender, EventArgs e)
        {
            Program.emotion = "Excited";
        }

        private void sadbtn_Click(object sender, EventArgs e)
        {
            Program.emotion = "Sad";
        }

        private void angrybtn_Click(object sender, EventArgs e)
        {
            Program.emotion = "Angry";
        }

        private void boredbtn_Click(object sender, EventArgs e)
        {
            Program.emotion = "Bored";
        }

        private void calmbtn_Click(object sender, EventArgs e)
        {
            Program.emotion = "Calm";
        }


        private void dairyform_Load(object sender, EventArgs e)
        {
            this.guna2DateTimePicker1.Value = DateTime.Now;
        }
    }
}

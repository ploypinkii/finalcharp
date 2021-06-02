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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
            label2.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
        }

        private void showsigncheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showsigncheck.Checked)
            {
                string a = signpasswordtext.Text;
                signpasswordtext.PasswordChar = '\0';
            }
            else
            {
                signpasswordtext.PasswordChar = '♥';
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linksignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login m = new login();
            m.Show();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            // add new user
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `login`(`username`, `password`, `phonenumber`, `email`) VALUES (@usn, @pass, @phone, @mail)",db.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = signusernametext.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = signpasswordtext.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = signphonetext.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = signmailtext.Text;

            // open the connection
            db.openConnection();
            Boolean check = true;

            // check if textbox contains the default values
            if(!checTextboxValues())
            {
                // check if the password equl the confirm password
                if(signpasswordtext.Text.Equals(signrepeatpasstext.Text))
                {
                    label8.Hide();
                    // check if the username already exists
                    if (checkUsername())
                    {
                        //MessageBox.Show("this username already has an account","Duplicate Username",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                        check = false;
                        label2.Show();
                        db.closeConnection();

                    }
                    else
                    {
                        label2.Hide();
                        db.closeConnection();
                    }
                    if (checkemail())
                    {
                        check = false;
                        label10.Show();
                        db.closeConnection();
                    }
                    else
                    {
                        label10.Hide();
                        db.closeConnection();
                    }
                    if (checkphone())
                    {
                        check = false;
                        label9.Show();
                        db.closeConnection();

                    }
                    else
                    {
                        label9.Hide();
                        db.closeConnection();
                    }
                    if (check == true)
                    {
                        label2.Hide();
                        label10.Hide();
                        label9.Hide();
                        //excute the query
                        db.openConnection();
                        command.ExecuteNonQuery();
                        try
                        {
                            db.closeConnection();
                            MessageBox.Show("account created");
                        }
                        catch (Exception)
                        {
                            db.closeConnection();
                            MessageBox.Show("error");
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("worng ! confirm password don't matching");
                    label8.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill your information completely");
            }
            
            // close the connection
            db.closeConnection();

        }
        //Check username has already
         public Boolean checkUsername()
        {
            DB db = new DB();
            string username = signusernametext.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `username` = @usn", db.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check username has already in database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkemail()
        {
            DB db = new DB();
            string email = signmailtext.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `email` = @mail", db.GetConnection());
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check username has already in database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkphone()
        {
            DB db = new DB();
            string phonenum = signphonetext.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `phonenumber` = @phone", db.GetConnection());
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phonenum;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check username has already in database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //check if the textboxes contain the default values
        public Boolean checTextboxValues()
        {
            string usn = signusernametext.Text;
            string pass = signpasswordtext.Text;
            string phone = signphonetext.Text;
            string email = signmailtext.Text;
            if (usn.Equals("") || pass.Equals("") || phone.Equals("") || email.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }
    }
}

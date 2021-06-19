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
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        //ปุ่มปิดโปรแกรม
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //ปุ่ม show password
        private void showcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showcheck.Checked)
            {
                string a = passwordbox.Text;
                passwordbox.PasswordChar = '\0';
            }
            else
            {
                passwordbox.PasswordChar = '♥';
            }
        }

        //ปุ่ม sign in
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            reg m = new reg();
            m.Show();
        }

        //ปุ่มเข้าสู่ระบบ
        private void loginbtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string username = usernamebox.Text;
            string password = passwordbox.Text;
            Program.username = usernamebox.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `username` = @usn AND `password` = @pass",db.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                Mainprogram m = new Mainprogram();
                m.Show();
            }
            else
            {
                MessageBox.Show("Username or Password are invalid please try again!","login");
            }
        }

        //กด login โดยการกด enter
        private void passwordbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn_Click(loginbtn, e);
            }
        }

        //ปุ่มลืมรหัสผ่าน
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forgot1 m = new Forgot1();
            m.Show();
        }

        private void usernamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

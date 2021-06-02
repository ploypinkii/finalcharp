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
    public partial class Repassword : Form
    {
        public Repassword()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verifyotpbtn_Click(object sender, EventArgs e)
        {
            if (repeatnewpasswordtextbox.Text == "")
            {
                repeatpasscheck.Text = "please Enter repeat password";
            }
            if (newpasswordtextbox.Text == "")
            {
                newpasscheck.Text = "please Enter new password";
            }
            if(newpasswordtextbox.Text != repeatnewpasswordtextbox.Text)
            {
                repeatpasscheck.Text = "Password don't match please try again";
            }
            if (newpasswordtextbox.Text == repeatnewpasswordtextbox.Text)
            {
                DB db = new DB();
                db.openConnection();
                string sql = "UPDATE login SET password ='" + repeatnewpasswordtextbox.Text + "' WHERE email = '" + Program.email + "' ";
                MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());
                
                cmd.ExecuteReader();
                db.closeConnection();
                MessageBox.Show("เปลี่ยนรหัสผ่านเรียบร้อย", "แจ้งเตือน");

                this.Hide();
                login m = new login();
                m.Show();
            }

        }

        private void signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login m = new login();
            m.Show();
        }

        private void showcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showcheck.Checked)
            {
                string a = newpasswordtextbox.Text;
                newpasswordtextbox.PasswordChar = '\0';
            }
            else
            {
                newpasswordtextbox.PasswordChar = '♥';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string a = repeatnewpasswordtextbox.Text;
                repeatnewpasswordtextbox.PasswordChar = '\0';
            }
            else
            {
                repeatnewpasswordtextbox.PasswordChar = '♥';
            }
        }
    }
}

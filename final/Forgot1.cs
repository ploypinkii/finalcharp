using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace final
{
    public partial class Forgot1 : Form
    {
        string OTPCode;
        public static string to;
        public static string email;
        public Forgot1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login m = new login();
            m.Show();
        }
        //ปุ่ม send OTP
        private void sendotpbtn_Click(object sender, EventArgs e)
        {
            if (emailtextbox.Text == "")
            {
                label5.Text = "Enter E-mail please";
            }
            else
            {
                Program.email = emailtextbox.Text;
                DB db = new DB();
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM `login` WHERE `email` = '" + emailtextbox.Text + "'", db.GetConnection());
                MySqlDataReader read1 = command1.ExecuteReader();
                bool checkhave = false; //ไม่มีใน DB
                while (read1.Read())
                {
                    checkhave = true;
                }
                if (checkhave == true)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    OTPCode = (rand.Next(999999)).ToString();
                    
                    MailMessage message = new MailMessage();
                    to = (emailtextbox.Text).ToString();
                    from = "PLOYploy142536789@gmail.com";
                    pass = "krislay19313";
                    messageBody = "Your Reset OTP code is " + OTPCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "OTP for verify e-mail";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code send successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    label5.Text = "This e-mail doesn't use to register with our program";
                }
            }
        }
        //ปุ่ม verify
        private void verifyotpbtn_Click(object sender, EventArgs e)
        {
            if (otptextbox.Text == "")
            {
                label6.Text = "Please enter OTP";
            }

            if (OTPCode == (otptextbox.Text).ToString())
            {
                to = emailtextbox.Text;
                Repassword np = new Repassword();
                this.Hide();
                np.Show();
            }
            else
            {
                MessageBox.Show("Invalid password please try again");
            }
        }

        private void emailtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (Regex.IsMatch(emailtextbox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.emailtextbox, "E-mail are invalid");
                return;
            }
        }
    }
}

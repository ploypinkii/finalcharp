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
using System.IO;
using System.Text.RegularExpressions;

namespace final
{
    public partial class reg : Form
    {
        string cgmailcom = "gmail.com";
        string cgmailcoth = "gmail.co.th";
        string cgmailacth = "gmail.ac.th";
        string ckkumailcom = "kkumail.com";
        string ckkuacth = "kku.ac.th";
        char[] checkat = {'@'};


        public reg()
        {
            //คำแจ้งเตือนในกรณีไม่ถูกต้อง
            InitializeComponent();
            label2.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
        }
        //ปุ่มแสดงรหัสผ่าน
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
        //ปุ่มปิดโปรแกรม
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //ปุ่ม login เพื่อย้อนกลับไปหน้าแรก
        private void linksignin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login m = new login();
            m.Show();
        }
        //ปุ่ม sign in 
        private void signupbtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            DB db = new DB();

            string sql = "INSERT INTO login(username, password, phonenumber, email, img) VALUES('" + signusernametext.Text + "','" + signpasswordtext.Text + "','" + signphonetext.Text + "','" + signmailtext.Text + "',@img)";

            db.GetConnection();
            //db.openConnection();
            //add new user
            /*
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `login`(`username`, `password`, `phonenumber`, `email`,`img`) VALUES (@usn, @pass, @phone, @mail,@img)", db.GetConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = signusernametext.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = signpasswordtext.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = signphonetext.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = signmailtext.Text;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = pictureBox1.Image;

            // open the connection*/
            db.openConnection();
            Boolean check = true;

            // check if textbox contains the default values
            if (!checTextboxValues())
            {
                if (!checknumberofpassword())
                {
                    if (!checknumberofphone())
                    {
                        // check if the password equl the confirm password
                        if (signpasswordtext.Text.Equals(signrepeatpasstext.Text))
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
                                check = true;
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
                                check = true;
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
                                check = true;
                                label9.Hide();
                                db.closeConnection();
                            }
                            //เช็ตตัว @ ในอีเมลล์
                            if(signmailtext.Text.IndexOfAny(checkat) > 0)
                            {
                                string mail = signmailtext.Text;
                                string[] checkmail = mail.Split('@');
                                string at = checkmail[1];

                                if (at == cgmailcom || at == cgmailacth || at == cgmailcoth || at == ckkumailcom || at == ckkuacth)
                                {
                                    errorProvider1.Clear();
                                    if (check == true)
                                    {
                                        label2.Hide();
                                        label10.Hide();
                                        label9.Hide();

                                        //excute the query
                                        db.openConnection();
                                        MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());
                                        cmd.Parameters.Add("@img", MySqlDbType.LongBlob);
                                        cmd.Parameters["@img"].Value = img;
                                        cmd.ExecuteNonQuery();

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
                                    errorProvider1.SetError(this.signmailtext, "E-mail are invalid");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(this.signmailtext, "E-mail are invalid");
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
                        MessageBox.Show("phone number should be 10 characters");
                    }
                }
                else
                {
                    MessageBox.Show("Password should be more than 6 characters");
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
        //ค้นหา e-mail ว่ามีหรือไม่จาก database
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
        //ค้นหาเบอร์โทรศัพท์
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
        //ตรวจสอบจำนวนรหัสผ่าน
        public Boolean checknumberofpassword()
        {
            if (signpasswordtext.TextLength < 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checknumberofphone()
        {
            if (signphonetext.TextLength < 10 || signphonetext.TextLength > 10)
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

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "png files(*png)|*.png|jpg files(*.jpg)|*.jpg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void signusernametext_KeyPress(object sender, KeyPressEventArgs e)
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

        private void signphonetext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void signpasswordtext_KeyPress(object sender, KeyPressEventArgs e)
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

        private void signrepeatpasstext_KeyPress(object sender, KeyPressEventArgs e)
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

        private void signmailtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if (((int)e.KeyChar >= 64 && (int)e.KeyChar <= 122) || ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) 
                || ((int)e.KeyChar == 8) || ((int)e.KeyChar == 13) || ((int)e.KeyChar == 46))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; 
                MessageBox.Show("invalid", "e-mail checking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

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

namespace final
{
    public partial class Mainprogram : Form
    {
        MySqlCommand cmdpic;
        MySqlDataAdapter adtpic;
        public Mainprogram()
        {
            InitializeComponent();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainprogram_Load(object sender, EventArgs e)
        {
            usershow.Text = Program.username;
            addbtn.FillColor = Color.Thistle;
            addbtn.ForeColor = Color.White;
            showbtn.FillColor = Color.Thistle;
            showbtn.ForeColor = Color.White;
            Main.FillColor = Color.SeaShell;
            Main.ForeColor = Color.Black;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(new maincs());
            showpicture1();
            changebtn.Hide();
        }
        private void showpicture1()
        {
            MySqlConnection conn = new MySqlConnection("host=localhost;username=root;password=;database=finalproject");
            string sql = "SELECT * FROM login WHERE username='" + Program.username + "'";
            conn.Open();
            cmdpic = new MySqlCommand(sql, conn);
            MySqlDataReader myReader = null;
            myReader = cmdpic.ExecuteReader();

            while (myReader.Read())
            {
                //byte[] imgg = myReader.GetString("img");
                byte[] imgg = (byte[])(myReader["img"]);
                if (imgg == null)
                {
                    guna2PictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(imgg);
                    Image img = Image.FromStream(mstream);
                    guna2PictureBox1.Image = img;
                }
            }
            conn.Close();


        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addbtn.FillColor = Color.SeaShell;
            addbtn.ForeColor = Color.Black;
            showbtn.FillColor = Color.Thistle;
            showbtn.ForeColor = Color.White;
            Main.FillColor = Color.Thistle;
            Main.ForeColor = Color.White;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(new dairyform());

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            addbtn.FillColor = Color.Thistle;
            addbtn.ForeColor = Color.White;
            Main.FillColor = Color.Thistle;
            Main.ForeColor = Color.White;
            showbtn.FillColor = Color.SeaShell;
            showbtn.ForeColor = Color.Black;
            readbtn.FillColor = Color.Thistle;
            readbtn.ForeColor = Color.White;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(new mydairy());
        }

        private void Main_Click(object sender, EventArgs e)
        {
            addbtn.FillColor = Color.Thistle;
            addbtn.ForeColor = Color.White;
            showbtn.FillColor = Color.Thistle;
            showbtn.ForeColor = Color.White;
            Main.FillColor = Color.SeaShell;
            Main.ForeColor = Color.Black;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(new maincs());


        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login m = new login();
            m.Show();
        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            addbtn.FillColor = Color.Thistle;
            addbtn.ForeColor = Color.White;
            showbtn.FillColor = Color.Thistle;
            showbtn.ForeColor = Color.White;
            Main.FillColor = Color.Thistle;
            Main.ForeColor = Color.White;
            readbtn.FillColor = Color.SeaShell;
            readbtn.ForeColor = Color.Black;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(new read());
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "png files(*png)|*.png|jpg files(*.jpg)|*.jpg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox1.Image = Image.FromFile(opf.FileName);
            }
            changebtn.Show();
            browsebtn.Hide();
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            guna2PictureBox1.Image.Save(ms, guna2PictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            DB db = new DB();
            string sql = "UPDATE `login` SET `img` = @img WHERE username='" + Program.username + "'";

            db.openConnection();
            MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection());
            cmd.Parameters.Add("@img", MySqlDbType.LongBlob);
            cmd.Parameters["@img"].Value = img;
            cmd.ExecuteNonQuery();
            MessageBox.Show("already update profile!");
            changebtn.Hide();
            browsebtn.Show();
        }
    }
}

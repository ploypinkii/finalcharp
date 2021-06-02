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
    public partial class Mainprogram : Form
    {
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
    }
}

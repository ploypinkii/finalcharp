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
    public partial class mydairy : UserControl
    {
        public mydairy()
        {
            InitializeComponent();
        }
        
        private void mydairy_Load(object sender, EventArgs e)
        {
            mydairy2.Controls.Add(new showemo());
        }

        private void preview_Click(object sender, EventArgs e)
        {
            mydairy2.Controls.Clear();
            mydairy2.Controls.Add(new showemo());
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            mydairy2.Controls.Clear();
            mydairy2.Controls.Add(new edit());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            mydairy2.Controls.Clear();
            mydairy2.Controls.Add(new delete());
        }
    }
}

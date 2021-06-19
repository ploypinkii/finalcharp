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
    public partial class edit : UserControl
    {
        private List<readdairy> bookdairy = new List<readdairy>();
        public edit()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            bookdairy.Clear();
            string date = guna2DateTimePicker1.Text;
            string note = notetextbox.Text;
            string usr = Program.username;
            string emo = Program.emotion;
            string[] datefinal = date.Split('/');
            string dy = datefinal[0];
            string mn = datefinal[1];
            string yr = datefinal[2];



            db.openConnection();
            string selectsql = $"SELECT * FROM `dairy` WHERE `user` = \"{Program.username}\" AND `day` = \"{dy}\" AND `month` = \"{mn}\" AND `year` = \"{yr}\"";
            MySqlCommand cmd = new MySqlCommand(selectsql, db.GetConnection());
            db.closeConnection();
            try
            {

                db.openConnection();
                using (MySqlDataReader read = cmd.ExecuteReader())

                {
                    string noteshow = "";
                    while (read.Read())
                    {
                        Program.emo = read.GetString("emo").ToString();
                        Program.note = read.GetString("note").ToString();
                        Program.picturetoclass = (byte[])(read["image"]);

                        readdairy item = new readdairy()
                        {
                            emo = Program.emo,
                            note = Program.note,
                            picturedairy = Program.picturetoclass
                        };
                        bookdairy.Add(item);
                    }
                    foreach (var i in bookdairy)
                    {
                        try
                        {
                            MemoryStream mstream = new MemoryStream(i.picturedairy);
                            Image img = Image.FromStream(mstream);
                            pictureBox1.Image = img;
                        }
                        catch (Exception)
                        {
                            pictureBox1.Image = null;
                        }

                        noteshow = noteshow + "\n" + i.note;
                    }
                    notetextbox.Text = noteshow;
                    
                    db.closeConnection();

                    if(Program.emo == "Happy")
                    {
                        happybtn.Checked = true;
                        excitedbtn.Checked = false;
                        sadbtn.Checked = false;
                        angrybtn.Checked = false;
                        boredbtn.Checked = false;
                        calmbtn.Checked = false;
                    }
                    else if (Program.emo == "Excited")
                    {
                        happybtn.Checked = false;
                        excitedbtn.Checked = true;
                        sadbtn.Checked = false;
                        angrybtn.Checked = false;
                        boredbtn.Checked = false;
                        calmbtn.Checked = false;
                    }
                    else if (Program.emo == "Sad")
                    {
                        happybtn.Checked = false;
                        excitedbtn.Checked = false;
                        sadbtn.Checked = true;
                        angrybtn.Checked = false;
                        boredbtn.Checked = false;
                        calmbtn.Checked = false;
                    }
                    else  if (Program.emo == "Angry")
                    {
                        happybtn.Checked = false;
                        excitedbtn.Checked = false;
                        sadbtn.Checked = false;
                        angrybtn.Checked = true;
                        boredbtn.Checked = false;
                        calmbtn.Checked = false;
                    }
                    else if (Program.emo == "Bored")
                    {
                        happybtn.Checked = false;
                        excitedbtn.Checked = false;
                        sadbtn.Checked = false;
                        angrybtn.Checked = false;
                        boredbtn.Checked = true;
                        calmbtn.Checked = false;
                    }
                    else if (Program.emo == "Calm")
                    {
                        happybtn.Checked = false;
                        excitedbtn.Checked = false;
                        sadbtn.Checked = false;
                        angrybtn.Checked = false;
                        boredbtn.Checked = false;
                        calmbtn.Checked = true;
                    }
                }
            }
            finally
            {
                db.closeConnection();
            }

        }
        private void showpicture1()
        {
            if (Program.picturetoclass == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                try
                {
                    MemoryStream mstream = new MemoryStream(Program.picturetoclass);
                    Image img = Image.FromStream(mstream);
                    pictureBox1.Image = img;
                }
                catch (Exception)
                {
                    pictureBox1.Image = null;
                }
            }
        }
            private void editbtn_Click(object sender, EventArgs e)
        {
            if (happybtn.Checked == false && excitedbtn.Checked == false && sadbtn.Checked == false && angrybtn.Checked == false && boredbtn.Checked == false && calmbtn.Checked == false)
            {
                MessageBox.Show("Choose your feeling please");
            }
            if (happybtn.Checked == true || excitedbtn.Checked == true || sadbtn.Checked == true || angrybtn.Checked == true || boredbtn.Checked == true || calmbtn.Checked == true)
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

                if (table.Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    db.openConnection();
                    MySqlCommand command = new MySqlCommand($"UPDATE `dairy` SET `emo`=\"{emo}\",`note`=\"{note}\" , image = @img WHERE `user` = \"{Program.username}\" AND `day` = \"{dy}\" AND `month` = \"{mn}\" AND `year` = \"{yr}\"", db.GetConnection());
                    command.Parameters.Add("@img", MySqlDbType.LongBlob);
                    command.Parameters["@img"].Value = img;
                    //command.ExecuteNonQuery();
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    MessageBox.Show("Edit dairy successfull!");
                    db.closeConnection();

                }
                else
                {
                    MessageBox.Show("something wrong! please try again");
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

        private void edit_Load(object sender, EventArgs e)
        {
            this.guna2DateTimePicker1.Value = DateTime.Now;
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
    }
}

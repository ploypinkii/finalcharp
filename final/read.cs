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
    public partial class read : UserControl
    {
        private List<readdairy> bookdairy = new List<readdairy>();
        List<Class> allbill = new List<Class>();
        int status = 0;
        public static string checkdate;

        public read()
        {
            InitializeComponent();
        }
        private void showdairy()
        {
            DB db = new DB();
            DataSet ds = new DataSet();
            db.openConnection();
            string selectsql = $"SELECT emo,day,month,year,note,image FROM `dairy` WHERE `user` = \"{Program.username}\"";
            MySqlCommand cmd = new MySqlCommand(selectsql, db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            db.closeConnection();
            adapter.Fill(ds);
            dairygridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dairygridview.AllowUserToResizeRows = false;
            dairygridview.DataSource = ds.Tables[0].DefaultView;
        }
        private void read_Load(object sender, EventArgs e)
        {
            this.searchdatetimepicker.Value = DateTime.Now;
            checkdate = searchdatetimepicker.Text;
            showdairy();
            status = 0;
            printbtn.Hide();
            clearbtn.Hide();
            label3.Hide();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            printbtn.Show();
            clearbtn.Show();
            label3.Show();
            allbill.Clear();
            bookdairy.Clear();
            string date = searchdatetimepicker.Text;
            string note = richTextBox.Text;
            string usr = Program.username;
            string emo = Program.emotion;
            string[] datefinal = date.Split('/');
            string dy = datefinal[0];
            string mn = datefinal[1];
            string yr = datefinal[2];

            DB db = new DB();
            DataSet ds = new DataSet();
            db.openConnection();
            status = 1;
            string selectsqlfromdate = $"SELECT emo,day,month,year,note,image FROM `dairy` WHERE `user` = \"{Program.username}\" AND `day` = \"{dy}\" AND `month` = \"{mn}\" AND `year` = \"{yr}\"";
            MySqlCommand cmdsearch = new MySqlCommand(selectsqlfromdate, db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdsearch);
            adapter.Fill(ds);
            db.closeConnection();
            dairygridview.DataSource = ds.Tables[0].DefaultView;

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
                            picturebox.Image = img;
                        }
                        catch (Exception)
                        {
                            picturebox.Image = null;
                        }

                        noteshow = noteshow + "\n" + i.note;
                    }
                    richTextBox.Text = noteshow;
                }
                if (Program.emo == "Happy")
                {
                    emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/happy.png";
                }
                if (Program.emo == "Calm")
                {
                    emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Calm.png";
                }
                if (Program.emo == "Excited")
                {
                    emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Excited.png";
                }
                if (Program.emo == "Sad")
                {
                    emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Sad.png";
                }
                if (Program.emo == "Angry")
                {
                    emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Angry.png";
                }
                if (Program.emo == "Bored")
                {
                    emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Bored.png";
                }
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void dairygridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dairygridview.CurrentRow.Selected = true;
            richTextBox.Text = dairygridview.Rows[e.RowIndex].Cells["note"].FormattedValue.ToString();
            Program.emo = dairygridview.Rows[e.RowIndex].Cells["emo"].FormattedValue.ToString();
            var data = (Byte[])(dairygridview.Rows[e.RowIndex].Cells["image"].Value);
            var stream = new MemoryStream(data);
            picturebox.Image = Image.FromStream(stream);
            if (Program.emo == "Happy")
            {
                emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/happy.png";
            }
            if (Program.emo == "Calm")
            {
                emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Calm.png";
            }
            if (Program.emo == "Excited")
            {
                emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Excited.png";
            }
            if (Program.emo == "Sad")
            {
                emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Sad.png";
            }
            if (Program.emo == "Angry")
            {
                emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Angry.png";
            }
            if (Program.emo == "Bored")
            {
                emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/Bored.png";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Grow", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(400, 50));
            e.Graphics.DrawString("My Diary", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(355, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(300, 150));
            int number = 1;
            var fnt = new Font("supermarket", 14, FontStyle.Regular);
            int x = 100, y = 100;
            int dy = (int)fnt.GetHeight(e.Graphics) * 1;
            foreach (var i in allbill)
            {
                y = y + 35;
                e.Graphics.DrawString("\n\n\nบันทึกเมื่อ  " + i.day, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(305, y));
                e.Graphics.DrawString("\n\n\n   /" + i.month, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(405, y));
                e.Graphics.DrawString("\n\n\n   /" + i.year, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(430, y));
                e.Graphics.DrawString("\n\n\n\n\nFeeling :    " + i.emo, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(350, y));
                e.Graphics.DrawString("\n\n\n\n\n\n\n   " + i.note, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(280, y));
                e.Graphics.DrawImage(picturebox.Image,300, 400, 300, 300);

                number = number + 1;
            }
            //e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
            e.Graphics.DrawString("USERNAME        " + Program.username.ToString(), new Font("supermarket", 10, FontStyle.Regular), Brushes.Black, new Point(350,1050));
        }

        private void selectvaluebill()
        {
            string date = searchdatetimepicker.Text;
            string note = richTextBox.Text;
            string usr = Program.username;
            string emo = Program.emotion;
            string[] datefinal = date.Split('/');
            string dy = datefinal[0];
            string mn = datefinal[1];
            string yr = datefinal[2];

            allbill.Clear();
            DB db = new DB();
            if (status == 0)
            {
                string selectsqlfromdate = $"SELECT emo,day,month,year,note,image FROM `dairy` WHERE `user` = \"{Program.username}\"";
                MySqlCommand cmdsearch = new MySqlCommand(selectsqlfromdate, db.GetConnection());
                db.openConnection();
                MySqlDataReader adapter = cmdsearch.ExecuteReader();
                while (adapter.Read())
                {
                    Program.prday = adapter.GetString("day").ToString();
                    Program.prmonth = adapter.GetString("month").ToString();
                    Program.pryear = adapter.GetString("year").ToString();
                    Program.premo = adapter.GetString("emo").ToString();
                    Program.prnote = adapter.GetString("note").ToString();
                    Program.picturetoclass = (byte[])(adapter["image"]);

                    Class item = new Class()
                    {
                        day = Program.prday,
                        month = Program.prmonth,
                        year = Program.pryear,
                        emo = Program.premo,
                        note = Program.prnote,
                        picturetoclass = Program.prpicturetoclass
                    };
                    allbill.Add(item);
                }
            }
            else
            {
                string selectsqlfromdate = $"SELECT emo,day,month,year,note,image FROM `dairy` WHERE `user` = \"{Program.username}\" AND `day` = \"{dy}\" AND `month` = \"{mn}\" AND `year` = \"{yr}\"";
                MySqlCommand cmdsearch = new MySqlCommand(selectsqlfromdate, db.GetConnection());
                db.openConnection();
                MySqlDataReader adapter = cmdsearch.ExecuteReader();
                while (adapter.Read())
                {
                    Program.prday = adapter.GetString("day").ToString();
                    Program.prmonth = adapter.GetString("month").ToString();
                    Program.pryear = adapter.GetString("year").ToString();
                    Program.premo = adapter.GetString("emo").ToString();
                    Program.prnote = adapter.GetString("note").ToString();
                    Program.picturetoclass = (byte[])(adapter["image"]);

                    Class item = new Class()
                    {
                        day = Program.prday,
                        month = Program.prmonth,
                        year = Program.pryear,
                        emo = Program.premo,
                        note = Program.prnote,
                        picturetoclass = Program.prpicturetoclass
                    };
                    allbill.Add(item);

                }
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            selectvaluebill();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            showdairy();
            allbill.Clear();
            status = 0;
            picturebox.Image = null;
            richTextBox.Text = "";
            emopic.ImageLocation = "D:/ED/term2/ED251007/C#/ploypink/final/img/happy.png";
            bookdairy.Clear();
            clearbtn.Hide();
            printbtn.Hide();

        }


    }
}

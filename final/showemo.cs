﻿using System;
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
    public partial class showemo : UserControl
    {
        private List<readdairy> bookdairy = new List<readdairy>();
        private static float some;
        private static float happyper;
        private static float excitedper;
        private static float sadper;
        private static float angryper;
        private static float boredper;
        private static float calmper;
        int lenght;
        int show;
        int index = 0;


        public showemo()
        {
            InitializeComponent();
        }
        private void showemo_Load(object sender, EventArgs e)
        {
            //ดึงข้อมูลจาก username ออกมาแสดง
            DB db = new DB();
            db.openConnection();
            string selectsql = $"SELECT * FROM `dairy` WHERE `user` = \"{Program.username}\"";
            MySqlCommand cmd = new MySqlCommand(selectsql, db.GetConnection());
            db.closeConnection();
            try
            {
                db.openConnection();
                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    lenght = 0;
                    while (read.Read())
                    {
                        lenght = lenght + 1;
                        Program.emo = read.GetString("emo").ToString();
                        Program.day = read.GetString("day").ToString();
                        Program.month = read.GetString("month").ToString();
                        Program.year = read.GetString("year").ToString();
                        Program.year = read.GetString("year").ToString();
                        Program.note = read.GetString("note").ToString();
                        Program.picturetoclass = (byte[])(read["image"]);

                        readdairy item = new readdairy()
                        {
                            emo = Program.emo,
                            day = Program.day,
                            month = Program.month,
                            year = Program.year,
                            note = Program.note,
                            picturedairy = Program.picturetoclass
                        };
                        bookdairy.Add(item);
                    }
                    db.closeConnection();
                }
                db.openConnection();
                //นับ happy
                string countsql = $"SELECT COUNT(emo) FROM dairy WHERE user = \"{Program.username}\" AND emo = 'Happy'";
                MySqlCommand cmd1 = new MySqlCommand(countsql, db.GetConnection());
                MySqlDataReader read1 = cmd1.ExecuteReader();
                while (read1.Read())
                {
                    Program.counthappy = float.Parse(read1.GetString("COUNT(emo)"));
                }
                db.closeConnection();
                //นับ excited
                db.openConnection();
                string countsql1 = $"SELECT COUNT(emo) FROM dairy WHERE user = \"{Program.username}\" AND emo = 'Excited'";
                MySqlCommand cmd2 = new MySqlCommand(countsql1, db.GetConnection());
                MySqlDataReader read2 = cmd2.ExecuteReader();
                while (read2.Read())
                {
                    Program.countexcited = float.Parse(read2.GetString("COUNT(emo)"));
                }
                db.closeConnection();
                //นับ sad
                db.openConnection();
                string countsql2 = $"SELECT COUNT(emo) FROM dairy WHERE user = \"{Program.username}\" AND emo = 'Sad'";
                MySqlCommand cmd3 = new MySqlCommand(countsql2, db.GetConnection());
                MySqlDataReader read3 = cmd3.ExecuteReader();
                while (read3.Read())
                {
                    Program.countsad = float.Parse(read3.GetString("COUNT(emo)"));
                }
                db.closeConnection();
                //นับ angry
                db.openConnection();
                string countsql3 = $"SELECT COUNT(emo) FROM dairy WHERE user = \"{Program.username}\" AND emo = 'Angry'";
                MySqlCommand cmd4 = new MySqlCommand(countsql3, db.GetConnection());
                MySqlDataReader read4 = cmd4.ExecuteReader();
                while (read4.Read())
                {
                    Program.countangry = float.Parse(read4.GetString("COUNT(emo)"));
                }
                db.closeConnection();
                //นับ bored
                db.openConnection();
                string countsql4 = $"SELECT COUNT(emo) FROM dairy WHERE user = \"{Program.username}\" AND emo = 'Bored'";
                MySqlCommand cmd5 = new MySqlCommand(countsql4, db.GetConnection());
                MySqlDataReader read5 = cmd5.ExecuteReader();
                while (read5.Read())
                {
                    Program.countbored = float.Parse(read5.GetString("COUNT(emo)"));
                }
                db.closeConnection();
                //นับ calm
                db.openConnection();
                string countsql5 = $"SELECT COUNT(emo) FROM dairy WHERE user = \"{Program.username}\" AND emo = 'Calm'";
                MySqlCommand cmd6 = new MySqlCommand(countsql5, db.GetConnection());
                MySqlDataReader read6 = cmd6.ExecuteReader();
                while (read6.Read())
                {
                    Program.countcalm = float.Parse(read6.GetString("COUNT(emo)"));
                }
                db.closeConnection();
                some = Program.countangry + Program.countbored + Program.countcalm + Program.countexcited + Program.counthappy + Program.countsad;
                happyper = Program.counthappy * 100 / some;
                excitedper = Program.countexcited * 100 / some;
                sadper = Program.countsad * 100 / some;
                angryper = Program.countangry * 100 / some;
                boredper = Program.countbored * 100 / some;
                calmper = Program.countcalm * 100 / some;

                Console.WriteLine(happyper);
                Console.WriteLine(excitedper);
                Console.WriteLine(sadper);
                Console.WriteLine(angryper);
                Console.WriteLine(boredper);
                Console.WriteLine(calmper);

                label2.Text = String.Format("{0:F2}%", happyper);
                label3.Text = String.Format("{0:F2}%", excitedper);
                label10.Text = String.Format("{0:F2}%", sadper);
                label13.Text = String.Format("{0:F2}%", angryper);
                label12.Text = String.Format("{0:F2}%", boredper);
                label11.Text = String.Format("{0:F2}%", calmper);

                //แนะนำมีความสุข
                if (Program.counthappy > Program.countexcited && Program.counthappy > Program.countsad && Program.counthappy > Program.countangry && Program.counthappy > Program.countbored && Program.counthappy > Program.countcalm)
                {
                    advicetextbox.Text = "ช่วงนี้ดูท่าจะมีความสุขนะ ☺";
                }
                //แนะนำตื่นเต้น
                if (Program.countexcited > Program.counthappy && Program.countexcited > Program.countsad && Program.countexcited > Program.countangry && Program.countexcited > Program.countbored && Program.countexcited > Program.countcalm)
                {
                    advicetextbox.Text = "เรื่องตื่นเต้นเยอะจังเลยน้า ☺";
                }
                //แนะนำเศร้า
                if (Program.countsad > Program.counthappy && Program.countsad > Program.countexcited && Program.countsad > Program.countangry && Program.countsad > Program.countbored && Program.countsad > Program.countcalm)
                {
                    advicetextbox.Text = "ลองหาอะไรใหม่ๆทำดูไหม ความเศร้าของเธอจะได้ลดลง เป็นห่วงนะ";
                }
                //แนะนำโกรธ
                if (Program.countangry > Program.counthappy && Program.countangry > Program.countexcited && Program.countangry > Program.countbored && Program.countangry > Program.countcalm && Program.countangry > Program.countsad)
                {
                    advicetextbox.Text = "ลองฝึกหายใจเวลาโกรธ มันช่วยให้เธอโกรธน้อยลงได้นะ ";
                }
                //แนะนำเบื่อ
                if (Program.countbored > Program.countexcited && Program.countbored > Program.countsad && Program.countbored > Program.countangry && Program.countbored > Program.counthappy && Program.countbored > Program.countcalm)
                {
                    advicetextbox.Text = "ลองทำเรื่องที่อยากลองทำดูไหม ท่าจะสนุกนะ !";
                }
                if (Program.countcalm > Program.countexcited && Program.countcalm > Program.countsad && Program.countcalm > Program.countangry && Program.countcalm > Program.countbored && Program.countcalm > Program.counthappy)
                {
                    advicetextbox.Text = "ช่วงนี้สบายดีจังเลยน้า ~";
                }

            }
            finally
            {
                db.closeConnection();
            }
            show = lenght-1;
            showpicture1();

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
            
            foreach (var i in bookdairy)
            {
                date.Text = i.day + "/" + i.month + "/" + i.year;
                emolabel.Text = i.emo;
                richTextBox1.Text = i.note;
            }
            nextButton.Enabled = false;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //show = index leght = countlist
            if (show >= lenght-1)
            {
                nextButton.Enabled = false;
                backButton.Enabled = true;
            }
            else
            {
                show = show + 1;
                showbutton();
                backButton.Enabled = true;
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (show <= 0)
            {
                backButton.Enabled = false;
                nextButton.Enabled = true;
            }
            else
            {
                show = show - 1;
                showbutton();
                nextButton.Enabled = true;
            }
        }

        private void showbutton()
        {
            
            //MessageBox.Show(show + " " + index);
            index = 0;
            foreach (var i in bookdairy)
            {
                //MessageBox.Show("in loop:"+show + " " + index);
                if (show == index)
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
                    date.Text = i.day + "/" + i.month + "/" + i.year;
                    emolabel.Text = i.emo;
                    richTextBox1.Text = i.note;
                }
                index = index + 1;
            }
            
        }
    }
}

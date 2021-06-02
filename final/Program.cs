using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{

    static class Program
    {
        public static string username;
        public static string email;
        public static string emotion;
        public static string emo;
        public static string day;
        public static string month;
        public static string year;
        public static string note;
        public static float counthappy = 0;
        public static float countexcited = 0;
        public static float countsad = 0;
        public static float countangry = 0;
        public static float countbored = 0;
        public static float countcalm = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}

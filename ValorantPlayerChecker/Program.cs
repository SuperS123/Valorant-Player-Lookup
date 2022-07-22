using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorantPlayerChecker
{

    internal static class Program
    {
        public static string current_version = "1.1";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Auto Updater
            var text = create_request("https://raw.githubusercontent.com/SuperS123/Valorant-Player-Lookup/main/version.txt");

            if(text == "Error")
            {
                MessageBox.Show("Version check failed, please check your internet connection!", "Auto-Update Preloader", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Run(new Form1());
                return;
            }
            if (!text.Contains(current_version)) 
            {
                MessageBox.Show($"New version available! You must download this update to run VALORANT Player Finder\n\nYour Version: {current_version}\nCurrent Version: {text}\n\nPress OK to go to the Github page", "Auto-Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("https://github.com/SuperS123/Valorant-Player-Lookup");
                return;
            }
            else
            {
                Application.Run(new Form1());
                return;
            }
        }

        private static string create_request(string url)
        {
            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);

                httpRequest.Accept = "application/json";


                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                return "Error";
            }

        }
    }
}

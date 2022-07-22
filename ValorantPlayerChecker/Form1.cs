using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ValorantPlayerChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            settingsPanel.Location = new Point(2, 4);
        }

        private string generate_rank_url(int tier)
        {
            return $"https://media.valorant-api.com/competitivetiers/564d8e28-c226-3180-6285-e48a390db8b1/{tier.ToString()}/smallicon.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Settings")
            {
                mainPanel.Hide();
                settingsPanel.Show();
                button2.Text = "Go Back";
            }
            else if(button2.Text == "Go Back")
            {
                settingsPanel.Hide();
                mainPanel.Show();
                button2.Text = "Settings";
            }
        }

        private void setPictureBox(PictureBox pictureBox, string url)
        {
            var request = WebRequest.Create(url);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox.Image = Bitmap.FromStream(stream);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private string create_request(string url)
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
            }catch(Exception ex)
            {
                return "Error";
            }

        }

        //Search
        private void button1_Click(object sender, EventArgs e)
        {
            compPanel.Hide();
            playerPanel.Hide();
            // Region Checking & Validation
            var region = comboBox1.Text;
            if(region.StartsWith("North"))
            {
                region = "na";
            } else if(region.StartsWith("Europe"))
            {
                region = "eu";
            } else if (region.StartsWith("Korea"))
            {
                region = "kr";
            } else if(region.StartsWith("Asia"))
            {
                region = "ap";
            } else
            {
                MessageBox.Show("Re-select your region in settings", "Error - Invalid Region", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tagline Validation
            if(!tag.Text.Contains("#"))
            {
                MessageBox.Show("Make sure you have the correct username with their tagline and selected the right region in settings", "Error - Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string[] strings = tag.Text.Split('#');
            string username = strings[0];
            string tagline = strings[1];

            // Standard Player Data
            var playerData = create_request($@"https://api.henrikdev.xyz/valorant/v1/account/{username}/{tagline}");

            if(playerData == "Error")
            {
                MessageBox.Show("Make sure you have the correct username with their tagline and selected the right region in settings", "Error - Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlayerRoot player = JsonConvert.DeserializeObject<PlayerRoot>(playerData);

            usernameLabel.Text = player.data.name + "#" + player.data.tag;
            levelLabel.Text = "Level: " + player.data.account_level;
            setPictureBox(pictureBox1, player.data.card.small);

            playerPanel.Show();

            // Comp Data - Part 1 | General Elo Data
            var compDataRequest1 = create_request($@"https://api.henrikdev.xyz/valorant/v1/mmr/{region}/{username}/{tagline}");

            if(compDataRequest1 == "Error" || compDataRequest1.Contains("null"))
            {
                MessageBox.Show("There was an error, please make sure you selected the correct region in settings.", "Error - Comp Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                playerPanel.Hide();
                return;
            }

            Root elo = JsonConvert.DeserializeObject<Root>(compDataRequest1);

            rank.Text = elo.data.currenttierpatched;
            rankProgress.Text = elo.data.ranking_in_tier + "/100";
            setPictureBox(pictureBox2, generate_rank_url(elo.data.currenttier));


            //TODO: Comp Data - Part 2 | Match History
            var compMatchHistoryReq = create_request($@"https://api.henrikdev.xyz/valorant/v1/mmr-history/{region}/{username}/{tagline}");

            MatchHistoryRoot matchHistory = JsonConvert.DeserializeObject<MatchHistoryRoot>(compMatchHistoryReq);

            for(int i = 0; i < matchHistory.data.Count; i++)
            {
                string[] test = matchHistory.data[i].date.Split(' ');
                var month = test[1].Substring(0, 3);
                var date = test[2];
                change_history(i, matchHistory.data[i].mmr_change_to_last_game, month + " " + date.Split(',')[0]);
            }

            compPanel.Show();

        }

        private void change_history(int count, int elo, string date) {
            if(count == 0)
            {
                bool positive = elo > 0;
                rr1.Text = elo.ToString();
                if(positive)
                {
                    elo1.BackColor = Color.FromArgb(192, 255, 192);
                } else if(elo == 0)
                {
                    elo1.BackColor = Color.Gray;
                } else if(elo < 0)
                {
                    elo1.BackColor = Color.FromArgb(255, 192, 192);
                }
                date1.Text = date;
                elo1.Visible = true;
            } else if (count == 1)
            {
                bool positive = elo > 0;
                rr2.Text = elo.ToString();
                if (positive)
                {
                    elo2.BackColor = Color.FromArgb(192, 255, 192);
                }
                else if (elo == 0)
                {
                    elo2.BackColor = Color.Gray;
                }
                else if (elo < 0)
                {
                    elo2.BackColor = Color.FromArgb(255, 192, 192);
                }
                date2.Text = date;
                elo2.Visible = true;
            }
            else if (count == 2)
            {
                bool positive = elo > 0;
                rr3.Text = elo.ToString();
                if (positive)
                {
                    elo3.BackColor = Color.FromArgb(192, 255, 192);
                }
                else if (elo == 0)
                {
                    elo3.BackColor = Color.Gray;
                }
                else if (elo < 0)
                {
                    elo3.BackColor = Color.FromArgb(255, 192, 192);
                }
                date3.Text = date;
                elo3.Visible = true;
            }
            else if (count == 3)
            {
                bool positive = elo > 0;
                rr4.Text = elo.ToString();
                if (positive)
                {
                    elo4.BackColor = Color.FromArgb(192, 255, 192);
                }
                else if (elo == 0)
                {
                    elo4.BackColor = Color.Gray;
                }
                else if (elo < 0)
                {
                    elo4.BackColor = Color.FromArgb(255, 192, 192);
                }
                date4.Text = date;
                elo4.Visible = true;
            }
            else if (count == 4)
            {
                bool positive = elo > 0;
                rr5.Text = elo.ToString();
                if (positive)
                {
                    elo5.BackColor = Color.FromArgb(192, 255, 192);
                }
                else if (elo == 0)
                {
                    elo5.BackColor = Color.Gray;
                }
                else if (elo < 0)
                {
                    elo5.BackColor = Color.FromArgb(255, 192, 192);
                }
                date5.Text = date;
                elo5.Visible = true;
            }
        }
    }
}

public class Data
{
    public int currenttier { get; set; }
    public string currenttierpatched { get; set; }
    public int ranking_in_tier { get; set; }
    public int mmr_change_to_last_game { get; set; }
    public int elo { get; set; }
    public string name { get; set; }
    public string tag { get; set; }
    public bool old { get; set; }
}

public class Root
{
    public int status { get; set; }
    public Data data { get; set; }
}

public class MatchHistoryData
{
    public int currenttier { get; set; }
    public string currenttierpatched { get; set; }
    public int ranking_in_tier { get; set; }
    public int mmr_change_to_last_game { get; set; }
    public int elo { get; set; }
    public string date { get; set; }
    public int date_raw { get; set; }
}

public class MatchHistoryRoot
{
    public int status { get; set; }
    public string name { get; set; }
    public string tag { get; set; }
    public List<MatchHistoryData> data { get; set; }
}

public class Card
{
    public string small { get; set; }
    public string large { get; set; }
    public string wide { get; set; }
    public string id { get; set; }
}

public class PlayerData
{
    public string puuid { get; set; }
    public string region { get; set; }
    public int account_level { get; set; }
    public string name { get; set; }
    public string tag { get; set; }
    public Card card { get; set; }
    public string last_update { get; set; }
}

public class PlayerRoot
{
    public int status { get; set; }
    public PlayerData data { get; set; }
}


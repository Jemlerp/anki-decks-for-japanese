using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;

namespace forvoAudioJishoYomikataScrape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _SaveLocation = "";

        private void buttonSetSaveLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sfd = new FolderBrowserDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _SaveLocation = sfd.SelectedPath;
            }
            buttonStart.Enabled = true;
        }

        private void buttonLoadWordsFropmTangorinScrapeFormat_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> words = new List<string>();
                List<string> input = File.ReadAllLines(ofd.FileName).ToList();
                foreach (string lijn in input)
                {
                    if (lijn.Length > 0)
                    {
                        var x = lijn.Split('"').ToList();
                        x.RemoveAt(0);
                        x.ForEach(y => words.Add(y));
                    }
                }

                string setString = "";
                foreach (string line in words)
                {
                    if (line.Trim().Length > 0)
                    {
                        line.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty);
                        setString += line + "\r\n";
                    }
                }
                textBox1.Text = setString;
            }
        }

        private void button1_Click(object sender, EventArgs e) //test
        {
            List<string> ja = new List<string>();
            ja.Add("ご兄弟");
            Scrapings.scrapeJishoDotOrg(ja);

            HtmlWeb web = new HtmlWeb();
            var htmldocd = web.Load("https://nl.forvo.com/search/" + "ご兄弟");
            var resultd = htmldocd.DocumentNode.SelectNodes("//*[contains(@class, 'play')]")[0];
            string audioFileLink = "https://audio00.forvo.com/audios/mp3/" + Encoding.UTF8.GetString(Convert.FromBase64String(resultd.Attributes[2].Value.Split('\'').ToList().Where(x => x.Length > 20).ToList()[2]));
            using (WebClient wbc = new WebClient())
            {
                wbc.DownloadFile(audioFileLink, "金色" + " " + "blalalla" + ".mp3");
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            List<Scrapings.DataTypes.WordWithYomikata> een = Scrapings.scrapeJishoDotOrg(textBox1.Lines.ToList()); // save to file

            List<string> save = new List<string>();
            foreach (var x in een)
            {
                string saveme = x.Word + " " + x.Yomikata + "\r\n";
                save.Add(saveme);
            }
            File.WriteAllLines(_SaveLocation + "\\alleWorden.txt", save);

            Scrapings.ScrapeForvo(_SaveLocation, een);

        }

        private void buttonLoadFromN4_Click(object sender, EventArgs e)
        {
            string toTextBox = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadAllLines(ofd.FileName))
                {
                    toTextBox += line.Split('>')[3].Split('<')[0] + "\r\n";
                }
            }
            textBox1.Text = toTextBox;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string toTextBox = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadAllLines(ofd.FileName))
                {
                    toTextBox += line.Split('\t')[0] + "\r\n";
                }
            }
            textBox1.Text = toTextBox;
        }
    }
}

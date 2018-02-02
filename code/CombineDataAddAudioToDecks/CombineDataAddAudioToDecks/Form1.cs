using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CombineDataAddAudioToDecks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> alleLinesIndeck = new List<string>();
        List<string> wordsThatHaveAudio = new List<string>();

        string saveLoc = "";
        string audioDir = "";

        private void buttonOpenDeck_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadAllLines(ofd.FileName))
                {
                    alleLinesIndeck.Add(line);
                }
            }
        }

        private void buttonOpenSoundExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                audioDir = fbd.SelectedPath;
                wordsThatHaveAudio = File.ReadAllLines(audioDir + $"\\alleWorden.txt").ToList();
            }
        }

        private void buttonSetSAveloc_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveLoc = sfd.FileName;
            }
        }

        private static string RandomString(int length)
        {
            Random random = new Random();
            string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length).Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string toSave = "";
            foreach (string line in alleLinesIndeck)
            {
                string audioName = "geenAudio" + RandomString(20);
                try
                {
                    audioName = wordsThatHaveAudio.First(x => x.Contains(line.Split('\t')[0]));
                }
                catch { }

                toSave += line + $"\t[sound:{audioName}.mp3]\r\n";
            }
            File.WriteAllText(saveLoc, toSave);
        }
    }
}

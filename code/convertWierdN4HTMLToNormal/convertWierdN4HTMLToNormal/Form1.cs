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

namespace convertWierdN4HTMLToNormal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> alleLinesInDeck = new List<string>();
        string saveLoc = "";

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                alleLinesInDeck = File.ReadAllLines(ofd.FileName).ToList();
            }
        }

        private void buttonSAve_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                saveLoc = sfd.FileName;
            }
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            string toSave = "";
            foreach(string line in alleLinesInDeck)
            {
                string kanjiWord = "";
                string yomikata = "";
                string meangin = "";
                string tags = "";

                string line1more = "";
                if(line.Contains("font-size: 12px;"))
                {
                    //long
                    line1more = line.Substring(101);

                    kanjiWord = line1more.Split('<')[0];

                    yomikata = line1more.Split('>')[3].Split('<')[0];

                    meangin = line1more.Split('>')[4].Split('<')[0];

                    tags = line1more.Split('>')[9].Substring(3);
                }
                else
                {
                    //short
                    line1more = line.Substring(64);

                    kanjiWord = line1more.Split('<')[0];

                    yomikata = line1more.Split('>')[3].Split('<')[0];

                    yomikata = line1more.Split('>')[4].Split('<')[0];

                    tags = line1more.Split('>')[5].Substring(3);
                }

                toSave += kanjiWord.Replace("\t", "").Trim() + "\t" + yomikata.Replace("\t", "").Trim() + "\t" + meangin.Replace("\t", "").Trim() + "\t" + tags.Replace("\t", "").Trim() + "\r\n";
            }
            File.WriteAllText(saveLoc, toSave);
        }
    }
}

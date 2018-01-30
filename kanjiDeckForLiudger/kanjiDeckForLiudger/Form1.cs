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

namespace kanjiDeckForLiudger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<AnkiKanjiEntry> nihongoshark;
        List<char> kanjis;
        string saveLoc;

        private void buttonOpenAnkiDeck_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                nihongoshark = Arbijd.GetAnkisFromTxt(ofd.FileName);
            }
        }

        private void buttonOpenKanjiList_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                kanjis = Arbijd.GetKanjisFromTxt(ofd.FileName);
            }
        }

        private void buttonSetSaveLoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                saveLoc = sfd.FileName;
            }
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            List<string> toSave = new List<string>();
            foreach (var x in nihongoshark)
            {
                if (kanjis.Contains(x.Kanji))
                {
                    //toSave += x.AnkiLine + "\r\n";
                    toSave.Add(x.AnkiLine);
                }
            }

            //File.WriteAllText(saveLoc, toSave);
            File.WriteAllLines(saveLoc, toSave.ToArray());

        }
    }
}

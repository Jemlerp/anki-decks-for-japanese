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

namespace NihongoSharkALevelKanjiFilterAndAddKiyomiMeanging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _AnkiDeck = new List<string>();
            _KyomiComment = new List<string>();
            _KanjisToLearn = new List<string>();
        }

        List<string> _AnkiDeck;
        List<string> _KyomiComment;
        List<string> _KyomiReadingNKotoba;
        List<string> _KanjisToLearn;
        string _SaveLoc = "";

        private void buttonOpenShark_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _AnkiDeck = File.ReadAllLines(ofd.FileName).ToList();
                _AnkiDeck.RemoveAll(i => i.Trim().Length == 0);
            }
        }

        private void buttonOpenKyopmiComemmtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _KyomiComment = File.ReadAllLines(ofd.FileName).ToList();
                _KyomiComment.RemoveAll(i => i.Trim().Length == 0);
            }
        }

        private void buttonLoadKyoReading_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _KyomiReadingNKotoba = File.ReadAllLines(ofd.FileName).ToList();
                _KyomiReadingNKotoba.RemoveAll(i => i.Trim().Length == 0);
            }
        }

        private void buttonOpenKanjisToLearn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var x = File.ReadAllLines(ofd.FileName).ToList().Where(z => z.Trim().Length > 0).ToList();
                foreach (var y in x)
                {
                    if (y.Trim().Length > 0)
                    {
                        _KanjisToLearn.Add(y.Trim());                        
                    }
                }
            }
        }

        private void buttonSetSaveLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                _SaveLoc = fbd.SelectedPath + "\\ui.txt";
            }
            buttonDo.Enabled = true;
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            try
            {
                string x = MeerKanjiDingu.doIt(_KanjisToLearn, _AnkiDeck, _KyomiComment, _KyomiReadingNKotoba).Aggregate((a1, a2) => (a1 + "\r\n") + a2);
                //File.WriteAllLines(_SaveLoc, MeerKanjiDingu.doIt(_KanjisToLearn, _AnkiDeck, _KyomiComment).ToArray());
                File.WriteAllText(_SaveLoc, x);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

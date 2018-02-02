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

namespace VocabKanjiAddImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<kanjiWithImageLocation> nihongoshark;
        List<ankiDeckCard> vocabDeck;
        string saveLoc = "";

        private void buttonLoadNihongoSharkDeck_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                nihongoshark = deckLogic.LoadNihongoSharkDeckExport(ofd.FileName);
            }
        }

        private void buttonLoadVocabDeck_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                vocabDeck = deckLogic.LoadVocabularyCards(ofd.FileName);
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
            File.WriteAllText(saveLoc,deckLogic.CrosReferencKanjiAndAddImageLocation(vocabDeck, nihongoshark)
                .Select(x => x.cardData)
                .Aggregate((y, z) => y+ "\r\n" + z)
                );
        }
    }
}

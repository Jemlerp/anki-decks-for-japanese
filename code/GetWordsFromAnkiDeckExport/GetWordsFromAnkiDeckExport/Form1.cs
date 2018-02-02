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

namespace GetWordsFromAnkiDeckExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                foreach(string line in File.ReadAllLines(ofd.FileName))
                {
                    Text += line.Split('\t')[0] + "\r\n";
                }
            }
            textBox1.Text = Text;
        }
    }
}

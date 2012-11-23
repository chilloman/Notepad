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

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lagreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream;
            string input = tbInput.Text;

            saveFileDialog1.Filter = "txt fil (.txt)|*.txt|Alle filtyper (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Title = "Lagre filen";
            saveFileDialog1.FileName = "fil.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter wText = new StreamWriter(fileStream);
                    wText.Write(input);

                    wText.Flush();
                    wText.Close();
                    fileStream.Close();
                }
            }
        }

        private void åpneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt fil (.txt)|*.txt|Alle filtyper (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            saveFileDialog1.Title = "Åpne txt fil";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    tbInput.Text = reader.ReadToEnd();
                }

                fileStream.Close();
            }
        }
    }
}

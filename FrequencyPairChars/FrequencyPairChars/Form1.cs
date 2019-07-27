using FrequencyPairChars.SupportClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequencyPairChars
{
    public partial class Form1 : Form
    {
        private FrequencyAnalyzer frequencyAnalyzer;

        public Form1()
        {
            InitializeComponent();
            frequencyAnalyzer = new FrequencyAnalyzer();
        }

        private void BtnManualText_Click(object sender, EventArgs e)
        {
            frequencyAnalyzer.AnalyzeText(TxtManualText.Text);
            TxtFrequencies.Text = frequencyAnalyzer.frequencyCounter.ToString();
        }

        private void BtnClearResults_Click(object sender, EventArgs e)
        {
            TxtFrequencies.Clear();
            frequencyAnalyzer.Reset();
        }
        
        private void BtnOpenSubmitFile_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBoxFilePath.Text = openFileDialog1.FileName;

                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                {
                    string s = string.Empty;
                    while ((s = sr.ReadLine()) != null)
                    {
                        text.Append(s);
                    }
                }
                frequencyAnalyzer.AnalyzeText(text.ToString());
                TxtFrequencies.Text = frequencyAnalyzer.frequencyCounter.ToString();
            }
        }
    }
}

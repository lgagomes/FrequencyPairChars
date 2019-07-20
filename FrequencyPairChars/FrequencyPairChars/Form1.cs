using FrequencyPairChars.SupportClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            TxtManualText.Text = string.Empty;
            TxtManualText.Text = frequencyAnalyzer.frequencyCounter.ToString();
        }
    }
}

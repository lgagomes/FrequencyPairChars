namespace FrequencyPairChars
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtManualText = new System.Windows.Forms.TextBox();
            this.BtnManualText = new System.Windows.Forms.Button();
            this.TxtFrequencies = new System.Windows.Forms.TextBox();
            this.TextBoxFilePath = new System.Windows.Forms.TextBox();
            this.BtnOpenSubmitFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClearResults = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtManualText
            // 
            this.TxtManualText.Location = new System.Drawing.Point(4, 15);
            this.TxtManualText.Multiline = true;
            this.TxtManualText.Name = "TxtManualText";
            this.TxtManualText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtManualText.Size = new System.Drawing.Size(233, 321);
            this.TxtManualText.TabIndex = 0;
            // 
            // BtnManualText
            // 
            this.BtnManualText.Location = new System.Drawing.Point(62, 350);
            this.BtnManualText.Name = "BtnManualText";
            this.BtnManualText.Size = new System.Drawing.Size(112, 46);
            this.BtnManualText.TabIndex = 1;
            this.BtnManualText.Text = "Manually \r\nInform Text";
            this.BtnManualText.UseVisualStyleBackColor = true;
            this.BtnManualText.Click += new System.EventHandler(this.BtnManualText_Click);
            // 
            // TxtFrequencies
            // 
            this.TxtFrequencies.Location = new System.Drawing.Point(17, 15);
            this.TxtFrequencies.Multiline = true;
            this.TxtFrequencies.Name = "TxtFrequencies";
            this.TxtFrequencies.ReadOnly = true;
            this.TxtFrequencies.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtFrequencies.Size = new System.Drawing.Size(248, 321);
            this.TxtFrequencies.TabIndex = 2;
            // 
            // TextBoxFilePath
            // 
            this.TextBoxFilePath.Location = new System.Drawing.Point(6, 30);
            this.TextBoxFilePath.Name = "TextBoxFilePath";
            this.TextBoxFilePath.Size = new System.Drawing.Size(218, 20);
            this.TextBoxFilePath.TabIndex = 3;
            // 
            // BtnOpenSubmitFile
            // 
            this.BtnOpenSubmitFile.Location = new System.Drawing.Point(32, 65);
            this.BtnOpenSubmitFile.Name = "BtnOpenSubmitFile";
            this.BtnOpenSubmitFile.Size = new System.Drawing.Size(178, 23);
            this.BtnOpenSubmitFile.TabIndex = 4;
            this.BtnOpenSubmitFile.Text = "Open and Submit File";
            this.BtnOpenSubmitFile.UseVisualStyleBackColor = true;
            this.BtnOpenSubmitFile.Click += new System.EventHandler(this.BtnOpenSubmitFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnManualText);
            this.groupBox1.Controls.Add(this.TxtManualText);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 402);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBoxFilePath);
            this.groupBox2.Controls.Add(this.BtnOpenSubmitFile);
            this.groupBox2.Location = new System.Drawing.Point(264, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 122);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text File";
            // 
            // BtnClearResults
            // 
            this.BtnClearResults.Location = new System.Drawing.Point(88, 362);
            this.BtnClearResults.Name = "BtnClearResults";
            this.BtnClearResults.Size = new System.Drawing.Size(126, 23);
            this.BtnClearResults.TabIndex = 8;
            this.BtnClearResults.Text = "Clear Results";
            this.BtnClearResults.UseVisualStyleBackColor = true;
            this.BtnClearResults.Click += new System.EventHandler(this.BtnClearResults_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnClearResults);
            this.groupBox3.Controls.Add(this.TxtFrequencies);
            this.groupBox3.Location = new System.Drawing.Point(521, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 407);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtManualText;
        private System.Windows.Forms.Button BtnManualText;
        private System.Windows.Forms.TextBox TxtFrequencies;
        private System.Windows.Forms.TextBox TextBoxFilePath;
        private System.Windows.Forms.Button BtnOpenSubmitFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnClearResults;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


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
            this.SuspendLayout();
            // 
            // TxtManualText
            // 
            this.TxtManualText.Location = new System.Drawing.Point(8, 17);
            this.TxtManualText.Multiline = true;
            this.TxtManualText.Name = "TxtManualText";
            this.TxtManualText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtManualText.Size = new System.Drawing.Size(554, 320);
            this.TxtManualText.TabIndex = 0;
            // 
            // BtnManualText
            // 
            this.BtnManualText.Location = new System.Drawing.Point(190, 343);
            this.BtnManualText.Name = "BtnManualText";
            this.BtnManualText.Size = new System.Drawing.Size(174, 23);
            this.BtnManualText.TabIndex = 1;
            this.BtnManualText.Text = "Manually inform text";
            this.BtnManualText.UseVisualStyleBackColor = true;
            this.BtnManualText.Click += new System.EventHandler(this.BtnManualText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 378);
            this.Controls.Add(this.BtnManualText);
            this.Controls.Add(this.TxtManualText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtManualText;
        private System.Windows.Forms.Button BtnManualText;
    }
}


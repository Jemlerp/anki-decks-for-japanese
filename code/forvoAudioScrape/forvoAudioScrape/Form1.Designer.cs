namespace forvoAudioJishoYomikataScrape
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadWordsFropmTangorinScrapeFormat = new System.Windows.Forms.Button();
            this.buttonSetSaveLoc = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLoadFromN4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(650, 1481);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Words";
            // 
            // buttonLoadWordsFropmTangorinScrapeFormat
            // 
            this.buttonLoadWordsFropmTangorinScrapeFormat.Location = new System.Drawing.Point(38, 1582);
            this.buttonLoadWordsFropmTangorinScrapeFormat.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonLoadWordsFropmTangorinScrapeFormat.Name = "buttonLoadWordsFropmTangorinScrapeFormat";
            this.buttonLoadWordsFropmTangorinScrapeFormat.Size = new System.Drawing.Size(659, 194);
            this.buttonLoadWordsFropmTangorinScrapeFormat.TabIndex = 4;
            this.buttonLoadWordsFropmTangorinScrapeFormat.Text = "Load Words From Tangorin Scrape Format";
            this.buttonLoadWordsFropmTangorinScrapeFormat.UseVisualStyleBackColor = true;
            this.buttonLoadWordsFropmTangorinScrapeFormat.Click += new System.EventHandler(this.buttonLoadWordsFropmTangorinScrapeFormat_Click);
            // 
            // buttonSetSaveLoc
            // 
            this.buttonSetSaveLoc.Location = new System.Drawing.Point(906, 760);
            this.buttonSetSaveLoc.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonSetSaveLoc.Name = "buttonSetSaveLoc";
            this.buttonSetSaveLoc.Size = new System.Drawing.Size(659, 194);
            this.buttonSetSaveLoc.TabIndex = 5;
            this.buttonSetSaveLoc.Text = "Set Save Location";
            this.buttonSetSaveLoc.UseVisualStyleBackColor = true;
            this.buttonSetSaveLoc.Click += new System.EventHandler(this.buttonSetSaveLoc_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(906, 1013);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(659, 194);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1165, 1611);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLoadFromN4
            // 
            this.buttonLoadFromN4.Location = new System.Drawing.Point(38, 1788);
            this.buttonLoadFromN4.Name = "buttonLoadFromN4";
            this.buttonLoadFromN4.Size = new System.Drawing.Size(659, 200);
            this.buttonLoadFromN4.TabIndex = 8;
            this.buttonLoadFromN4.Text = "LoadFromN4Deck";
            this.buttonLoadFromN4.UseVisualStyleBackColor = true;
            this.buttonLoadFromN4.Click += new System.EventHandler(this.buttonLoadFromN4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 1994);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(659, 200);
            this.button2.TabIndex = 9;
            this.button2.Text = "LoadFromNotHTMLExport";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 2232);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLoadFromN4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSetSaveLoc);
            this.Controls.Add(this.buttonLoadWordsFropmTangorinScrapeFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadWordsFropmTangorinScrapeFormat;
        private System.Windows.Forms.Button buttonSetSaveLoc;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLoadFromN4;
        private System.Windows.Forms.Button button2;
    }
}


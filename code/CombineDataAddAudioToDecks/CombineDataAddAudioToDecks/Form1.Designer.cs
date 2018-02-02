namespace CombineDataAddAudioToDecks
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
            this.buttonOpenDeck = new System.Windows.Forms.Button();
            this.buttonOpenSoundExport = new System.Windows.Forms.Button();
            this.buttonSetSAveloc = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenDeck
            // 
            this.buttonOpenDeck.Location = new System.Drawing.Point(21, 12);
            this.buttonOpenDeck.Name = "buttonOpenDeck";
            this.buttonOpenDeck.Size = new System.Drawing.Size(265, 189);
            this.buttonOpenDeck.TabIndex = 0;
            this.buttonOpenDeck.Text = "OpenDeck";
            this.buttonOpenDeck.UseVisualStyleBackColor = true;
            this.buttonOpenDeck.Click += new System.EventHandler(this.buttonOpenDeck_Click);
            // 
            // buttonOpenSoundExport
            // 
            this.buttonOpenSoundExport.Location = new System.Drawing.Point(21, 224);
            this.buttonOpenSoundExport.Name = "buttonOpenSoundExport";
            this.buttonOpenSoundExport.Size = new System.Drawing.Size(265, 189);
            this.buttonOpenSoundExport.TabIndex = 1;
            this.buttonOpenSoundExport.Text = "OpenScrapeExportDir";
            this.buttonOpenSoundExport.UseVisualStyleBackColor = true;
            this.buttonOpenSoundExport.Click += new System.EventHandler(this.buttonOpenSoundExport_Click);
            // 
            // buttonSetSAveloc
            // 
            this.buttonSetSAveloc.Location = new System.Drawing.Point(21, 486);
            this.buttonSetSAveloc.Name = "buttonSetSAveloc";
            this.buttonSetSAveloc.Size = new System.Drawing.Size(265, 189);
            this.buttonSetSAveloc.TabIndex = 2;
            this.buttonSetSAveloc.Text = "SaveFileLocation";
            this.buttonSetSAveloc.UseVisualStyleBackColor = true;
            this.buttonSetSAveloc.Click += new System.EventHandler(this.buttonSetSAveloc_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(444, 486);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(265, 189);
            this.buttonGo.TabIndex = 3;
            this.buttonGo.Text = "Start";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 837);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonSetSAveloc);
            this.Controls.Add(this.buttonOpenSoundExport);
            this.Controls.Add(this.buttonOpenDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenDeck;
        private System.Windows.Forms.Button buttonOpenSoundExport;
        private System.Windows.Forms.Button buttonSetSAveloc;
        private System.Windows.Forms.Button buttonGo;
    }
}


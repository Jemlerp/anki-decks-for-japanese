namespace VocabKanjiAddImages
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
            this.buttonLoadNihongoSharkDeck = new System.Windows.Forms.Button();
            this.buttonLoadVocabDeck = new System.Windows.Forms.Button();
            this.buttonSetSaveLoc = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadNihongoSharkDeck
            // 
            this.buttonLoadNihongoSharkDeck.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadNihongoSharkDeck.Name = "buttonLoadNihongoSharkDeck";
            this.buttonLoadNihongoSharkDeck.Size = new System.Drawing.Size(114, 106);
            this.buttonLoadNihongoSharkDeck.TabIndex = 0;
            this.buttonLoadNihongoSharkDeck.Text = "LoadNihongoSharkDeck";
            this.buttonLoadNihongoSharkDeck.UseVisualStyleBackColor = true;
            this.buttonLoadNihongoSharkDeck.Click += new System.EventHandler(this.buttonLoadNihongoSharkDeck_Click);
            // 
            // buttonLoadVocabDeck
            // 
            this.buttonLoadVocabDeck.Location = new System.Drawing.Point(12, 124);
            this.buttonLoadVocabDeck.Name = "buttonLoadVocabDeck";
            this.buttonLoadVocabDeck.Size = new System.Drawing.Size(114, 106);
            this.buttonLoadVocabDeck.TabIndex = 1;
            this.buttonLoadVocabDeck.Text = "LoadVobabularyDeck";
            this.buttonLoadVocabDeck.UseVisualStyleBackColor = true;
            this.buttonLoadVocabDeck.Click += new System.EventHandler(this.buttonLoadVocabDeck_Click);
            // 
            // buttonSetSaveLoc
            // 
            this.buttonSetSaveLoc.Location = new System.Drawing.Point(12, 236);
            this.buttonSetSaveLoc.Name = "buttonSetSaveLoc";
            this.buttonSetSaveLoc.Size = new System.Drawing.Size(114, 106);
            this.buttonSetSaveLoc.TabIndex = 2;
            this.buttonSetSaveLoc.Text = "SetSaveLocation";
            this.buttonSetSaveLoc.UseVisualStyleBackColor = true;
            this.buttonSetSaveLoc.Click += new System.EventHandler(this.buttonSetSaveLoc_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(12, 348);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(114, 106);
            this.buttonDo.TabIndex = 3;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 486);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonSetSaveLoc);
            this.Controls.Add(this.buttonLoadVocabDeck);
            this.Controls.Add(this.buttonLoadNihongoSharkDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadNihongoSharkDeck;
        private System.Windows.Forms.Button buttonLoadVocabDeck;
        private System.Windows.Forms.Button buttonSetSaveLoc;
        private System.Windows.Forms.Button buttonDo;
    }
}


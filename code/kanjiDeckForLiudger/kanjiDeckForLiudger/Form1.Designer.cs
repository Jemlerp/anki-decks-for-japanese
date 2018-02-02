namespace kanjiDeckForLiudger
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
            this.buttonOpenAnkiDeck = new System.Windows.Forms.Button();
            this.buttonOpenKanjiList = new System.Windows.Forms.Button();
            this.buttonSetSaveLoc = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenAnkiDeck
            // 
            this.buttonOpenAnkiDeck.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenAnkiDeck.Name = "buttonOpenAnkiDeck";
            this.buttonOpenAnkiDeck.Size = new System.Drawing.Size(103, 52);
            this.buttonOpenAnkiDeck.TabIndex = 0;
            this.buttonOpenAnkiDeck.Text = "OpenAnkiDeck";
            this.buttonOpenAnkiDeck.UseVisualStyleBackColor = true;
            this.buttonOpenAnkiDeck.Click += new System.EventHandler(this.buttonOpenAnkiDeck_Click);
            // 
            // buttonOpenKanjiList
            // 
            this.buttonOpenKanjiList.Location = new System.Drawing.Point(12, 70);
            this.buttonOpenKanjiList.Name = "buttonOpenKanjiList";
            this.buttonOpenKanjiList.Size = new System.Drawing.Size(103, 52);
            this.buttonOpenKanjiList.TabIndex = 1;
            this.buttonOpenKanjiList.Text = "OpenKanjiList";
            this.buttonOpenKanjiList.UseVisualStyleBackColor = true;
            this.buttonOpenKanjiList.Click += new System.EventHandler(this.buttonOpenKanjiList_Click);
            // 
            // buttonSetSaveLoc
            // 
            this.buttonSetSaveLoc.Location = new System.Drawing.Point(12, 128);
            this.buttonSetSaveLoc.Name = "buttonSetSaveLoc";
            this.buttonSetSaveLoc.Size = new System.Drawing.Size(103, 52);
            this.buttonSetSaveLoc.TabIndex = 2;
            this.buttonSetSaveLoc.Text = "Set CSV SaveLoc";
            this.buttonSetSaveLoc.UseVisualStyleBackColor = true;
            this.buttonSetSaveLoc.Click += new System.EventHandler(this.buttonSetSaveLoc_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(12, 186);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(103, 52);
            this.buttonDo.TabIndex = 3;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 325);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonSetSaveLoc);
            this.Controls.Add(this.buttonOpenKanjiList);
            this.Controls.Add(this.buttonOpenAnkiDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenAnkiDeck;
        private System.Windows.Forms.Button buttonOpenKanjiList;
        private System.Windows.Forms.Button buttonSetSaveLoc;
        private System.Windows.Forms.Button buttonDo;
    }
}


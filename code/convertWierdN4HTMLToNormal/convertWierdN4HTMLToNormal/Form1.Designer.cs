namespace convertWierdN4HTMLToNormal
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSAve = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(28, 31);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(341, 167);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSAve
            // 
            this.buttonSAve.Location = new System.Drawing.Point(28, 258);
            this.buttonSAve.Name = "buttonSAve";
            this.buttonSAve.Size = new System.Drawing.Size(341, 167);
            this.buttonSAve.TabIndex = 1;
            this.buttonSAve.Text = "SetSave";
            this.buttonSAve.UseVisualStyleBackColor = true;
            this.buttonSAve.Click += new System.EventHandler(this.buttonSAve_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Location = new System.Drawing.Point(28, 571);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(341, 167);
            this.buttonDo.TabIndex = 2;
            this.buttonDo.Text = "Do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 857);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonSAve);
            this.Controls.Add(this.buttonLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSAve;
        private System.Windows.Forms.Button buttonDo;
    }
}


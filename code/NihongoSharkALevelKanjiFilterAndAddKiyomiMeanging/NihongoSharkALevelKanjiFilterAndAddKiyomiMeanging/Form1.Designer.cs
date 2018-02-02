namespace NihongoSharkALevelKanjiFilterAndAddKiyomiMeanging
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
            this.buttonOpenShark = new System.Windows.Forms.Button();
            this.buttonOpenKyopmiComemmtn = new System.Windows.Forms.Button();
            this.buttonSetSaveLoc = new System.Windows.Forms.Button();
            this.buttonDo = new System.Windows.Forms.Button();
            this.buttonOpenKanjisToLearn = new System.Windows.Forms.Button();
            this.buttonLoadKyoReading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenShark
            // 
            this.buttonOpenShark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenShark.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenShark.Name = "buttonOpenShark";
            this.buttonOpenShark.Size = new System.Drawing.Size(274, 50);
            this.buttonOpenShark.TabIndex = 0;
            this.buttonOpenShark.Text = "Open Shark";
            this.buttonOpenShark.UseVisualStyleBackColor = true;
            this.buttonOpenShark.Click += new System.EventHandler(this.buttonOpenShark_Click);
            // 
            // buttonOpenKyopmiComemmtn
            // 
            this.buttonOpenKyopmiComemmtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenKyopmiComemmtn.Location = new System.Drawing.Point(12, 68);
            this.buttonOpenKyopmiComemmtn.Name = "buttonOpenKyopmiComemmtn";
            this.buttonOpenKyopmiComemmtn.Size = new System.Drawing.Size(274, 50);
            this.buttonOpenKyopmiComemmtn.TabIndex = 1;
            this.buttonOpenKyopmiComemmtn.Text = "Open Kiomy comment";
            this.buttonOpenKyopmiComemmtn.UseVisualStyleBackColor = true;
            this.buttonOpenKyopmiComemmtn.Click += new System.EventHandler(this.buttonOpenKyopmiComemmtn_Click);
            // 
            // buttonSetSaveLoc
            // 
            this.buttonSetSaveLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetSaveLoc.Location = new System.Drawing.Point(12, 236);
            this.buttonSetSaveLoc.Name = "buttonSetSaveLoc";
            this.buttonSetSaveLoc.Size = new System.Drawing.Size(274, 50);
            this.buttonSetSaveLoc.TabIndex = 2;
            this.buttonSetSaveLoc.Text = "SetSaveLoc";
            this.buttonSetSaveLoc.UseVisualStyleBackColor = true;
            this.buttonSetSaveLoc.Click += new System.EventHandler(this.buttonSetSaveLoc_Click);
            // 
            // buttonDo
            // 
            this.buttonDo.Enabled = false;
            this.buttonDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDo.Location = new System.Drawing.Point(12, 292);
            this.buttonDo.Name = "buttonDo";
            this.buttonDo.Size = new System.Drawing.Size(274, 50);
            this.buttonDo.TabIndex = 3;
            this.buttonDo.Text = "do";
            this.buttonDo.UseVisualStyleBackColor = true;
            this.buttonDo.Click += new System.EventHandler(this.buttonDo_Click);
            // 
            // buttonOpenKanjisToLearn
            // 
            this.buttonOpenKanjisToLearn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenKanjisToLearn.Location = new System.Drawing.Point(12, 180);
            this.buttonOpenKanjisToLearn.Name = "buttonOpenKanjisToLearn";
            this.buttonOpenKanjisToLearn.Size = new System.Drawing.Size(274, 50);
            this.buttonOpenKanjisToLearn.TabIndex = 4;
            this.buttonOpenKanjisToLearn.Text = "Open KanjisToLearn";
            this.buttonOpenKanjisToLearn.UseVisualStyleBackColor = true;
            this.buttonOpenKanjisToLearn.Click += new System.EventHandler(this.buttonOpenKanjisToLearn_Click);
            // 
            // buttonLoadKyoReading
            // 
            this.buttonLoadKyoReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadKyoReading.Location = new System.Drawing.Point(12, 124);
            this.buttonLoadKyoReading.Name = "buttonLoadKyoReading";
            this.buttonLoadKyoReading.Size = new System.Drawing.Size(274, 50);
            this.buttonLoadKyoReading.TabIndex = 5;
            this.buttonLoadKyoReading.Text = "Open kyo words&readings";
            this.buttonLoadKyoReading.UseVisualStyleBackColor = true;
            this.buttonLoadKyoReading.Click += new System.EventHandler(this.buttonLoadKyoReading_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 516);
            this.Controls.Add(this.buttonLoadKyoReading);
            this.Controls.Add(this.buttonOpenKanjisToLearn);
            this.Controls.Add(this.buttonDo);
            this.Controls.Add(this.buttonSetSaveLoc);
            this.Controls.Add(this.buttonOpenKyopmiComemmtn);
            this.Controls.Add(this.buttonOpenShark);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenShark;
        private System.Windows.Forms.Button buttonOpenKyopmiComemmtn;
        private System.Windows.Forms.Button buttonSetSaveLoc;
        private System.Windows.Forms.Button buttonDo;
        private System.Windows.Forms.Button buttonOpenKanjisToLearn;
        private System.Windows.Forms.Button buttonLoadKyoReading;
    }
}


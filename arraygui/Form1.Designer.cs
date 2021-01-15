namespace arraygui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxpunktanzahl = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.labelzahler = new System.Windows.Forms.Label();
            this.checkBoxnum = new System.Windows.Forms.CheckBox();
            this.checkBoxVerbinden = new System.Windows.Forms.CheckBox();
            this.checkBoxhintergr = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonprint = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonfarbe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Punkte";
            // 
            // textBoxpunktanzahl
            // 
            this.textBoxpunktanzahl.Location = new System.Drawing.Point(59, 16);
            this.textBoxpunktanzahl.Name = "textBoxpunktanzahl";
            this.textBoxpunktanzahl.Size = new System.Drawing.Size(46, 20);
            this.textBoxpunktanzahl.TabIndex = 2;
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(15, 55);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(90, 29);
            this.buttonok.TabIndex = 3;
            this.buttonok.Text = "OK";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.buttonok_Click);
            // 
            // labelzahler
            // 
            this.labelzahler.AutoSize = true;
            this.labelzahler.Location = new System.Drawing.Point(12, 102);
            this.labelzahler.Name = "labelzahler";
            this.labelzahler.Size = new System.Drawing.Size(63, 13);
            this.labelzahler.TabIndex = 4;
            this.labelzahler.Text = "Punktzähler";
            this.labelzahler.Visible = false;
            // 
            // checkBoxnum
            // 
            this.checkBoxnum.AutoSize = true;
            this.checkBoxnum.Location = new System.Drawing.Point(17, 137);
            this.checkBoxnum.Name = "checkBoxnum";
            this.checkBoxnum.Size = new System.Drawing.Size(88, 17);
            this.checkBoxnum.TabIndex = 5;
            this.checkBoxnum.Text = "Nummerieren";
            this.checkBoxnum.UseVisualStyleBackColor = true;
            this.checkBoxnum.CheckedChanged += new System.EventHandler(this.checkBoxnum_CheckedChanged);
            // 
            // checkBoxVerbinden
            // 
            this.checkBoxVerbinden.AutoSize = true;
            this.checkBoxVerbinden.Location = new System.Drawing.Point(17, 160);
            this.checkBoxVerbinden.Name = "checkBoxVerbinden";
            this.checkBoxVerbinden.Size = new System.Drawing.Size(74, 17);
            this.checkBoxVerbinden.TabIndex = 6;
            this.checkBoxVerbinden.Text = "Verbinden";
            this.checkBoxVerbinden.UseVisualStyleBackColor = true;
            this.checkBoxVerbinden.CheckedChanged += new System.EventHandler(this.checkBoxVerbinden_CheckedChanged);
            // 
            // checkBoxhintergr
            // 
            this.checkBoxhintergr.AutoSize = true;
            this.checkBoxhintergr.Location = new System.Drawing.Point(17, 183);
            this.checkBoxhintergr.Name = "checkBoxhintergr";
            this.checkBoxhintergr.Size = new System.Drawing.Size(129, 17);
            this.checkBoxhintergr.TabIndex = 7;
            this.checkBoxhintergr.Text = "Hintergrund entfernen";
            this.checkBoxhintergr.UseVisualStyleBackColor = true;
            this.checkBoxhintergr.CheckedChanged += new System.EventHandler(this.checkBoxhintergr_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bild hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(15, 390);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(90, 29);
            this.buttonsave.TabIndex = 9;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttonprint
            // 
            this.buttonprint.Location = new System.Drawing.Point(17, 425);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(90, 29);
            this.buttonprint.TabIndex = 10;
            this.buttonprint.Text = "Print";
            this.buttonprint.UseVisualStyleBackColor = true;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // buttonfarbe
            // 
            this.buttonfarbe.Location = new System.Drawing.Point(15, 281);
            this.buttonfarbe.Name = "buttonfarbe";
            this.buttonfarbe.Size = new System.Drawing.Size(90, 29);
            this.buttonfarbe.TabIndex = 11;
            this.buttonfarbe.Text = "Farbeändern";
            this.buttonfarbe.UseVisualStyleBackColor = true;
            this.buttonfarbe.Click += new System.EventHandler(this.buttonfarbe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 476);
            this.Controls.Add(this.buttonfarbe);
            this.Controls.Add(this.buttonprint);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxhintergr);
            this.Controls.Add(this.checkBoxVerbinden);
            this.Controls.Add(this.checkBoxnum);
            this.Controls.Add(this.labelzahler);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxpunktanzahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxpunktanzahl;
        private System.Windows.Forms.Button buttonok;
        private System.Windows.Forms.Label labelzahler;
        private System.Windows.Forms.CheckBox checkBoxnum;
        private System.Windows.Forms.CheckBox checkBoxVerbinden;
        private System.Windows.Forms.CheckBox checkBoxhintergr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonfarbe;
    }
}


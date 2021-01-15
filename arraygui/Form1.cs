using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace arraygui
{
    public partial class Form1 : Form
    {
        int[] x;
        int[] y;
        int punkte=0;
        PrintDocument printDocument1 = new PrintDocument();
        Color farbe;
        public Form1()
        {
            farbe = Color.Red;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);//event um diese seite zu drucken
            InitializeComponent();
            bpm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        

        private void buttonok_Click(object sender, EventArgs e)
        {
            int anzahl = Convert.ToInt32(textBoxpunktanzahl.Text);
            punkte = 0;
            x = new int[anzahl];
            y = new int[anzahl];


        }

        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen stift = new Pen(farbe);
            Brush pinsel = new SolidBrush(farbe);
            Graphics dev = e.Graphics;
            Font schrift = new Font("Arial", 8);
            if (x == null)
                return;
            if (checkBoxhintergr.Checked)
            {
                dev.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);
            }
                //Alle Punkte markieren +
                for (int i = 0; i < punkte; i++)
            {
               
                    dev.DrawLine(stift, x[i], y[i] - 5, x[i], y[i] + 5);
                    dev.DrawLine(stift, x[i] - 5, y[i], x[i] + 5, y[i]);
                    //Beschriftung
                    if (checkBoxnum.Checked)
                    {
                        dev.DrawString((i + 1).ToString(), schrift, pinsel, x[i] - 5, y[i] - 18);
                    } 
                
                
            }
            if (checkBoxVerbinden.Checked)
            {
                for (int i = 0; i < punkte - 1; i++)
                {    //Verbinden
                  dev.DrawLine(stift, x[i], y[i], x[i + 1], y[i + 1]);
                }
                if (punkte == x.Length)
                {
                    dev.DrawLine(stift, x[x.Length - 1], y[x.Length - 1], x[0], y[0]);
                }
                
            }
          
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (x == null || punkte >= x.Length)
                return;
            int xmaus = e.X;
            int ymaus = e.Y;
            x[punkte] = xmaus;
            y[punkte]= ymaus;
            punkte++;
            labelzahler.Text = "Punkt" + punkte + "/" + x.Length;
            labelzahler.Visible = true;
            pictureBox1.Invalidate();

        }

        private void checkBoxnum_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void checkBoxVerbinden_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void checkBoxhintergr_CheckedChanged(object sender, EventArgs e)
        {
            
                pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titel;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"+"BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|";
            openFileDialog1.Title = "Select a Png File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                titel = openFileDialog1.FileName;
                //MessageBox.Show(titel);
                pictureBox1.BackgroundImage = Image.FromFile(titel);
                
            }

        }

        Bitmap bpm;
        private void buttonsave_Click(object sender, EventArgs e)
        {
           
            string speicherplatz;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            //Dialog anzeigen saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                speicherplatz = saveFileDialog1.FileName;
                //picturebox inhalt speichern  
                //picturebox speichern     
                pictureBox1.DrawToBitmap(bpm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                bpm.Save(speicherplatz,ImageFormat.Bmp);
                MessageBox.Show("Saved Successfully.....");
               
            }

        }
        
        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            pictureBox1.DrawToBitmap(bpm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bpm, 0, 0);//"auf drucker zeichnen"

        }

        

        private void buttonprint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

           
        }

        private void buttonfarbe_Click(object sender, EventArgs e)
        {
           
          if (colorDialog.ShowDialog() == DialogResult.OK)
            {
             
                farbe = colorDialog.Color;
                pictureBox1.Invalidate();
            }

        }
    }
}

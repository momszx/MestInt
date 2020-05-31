using MestIntBeadando.AlllapotTer;
using MestIntBeadando.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestIntBeadando
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        List<Allapot> megoldas = new List<Allapot>();
        int aktualisHely = 0;
        List<Kereso> keresok = new List<Kereso>();
        public Form1()
        {
            InitializeComponent();
            keresok.Add(new AgEsKorlat());
            foreach(Kereso kereso in keresok)
            {
                comboBox1.Items.Add(kereso.GetType().Name);
            }//üres a megoldás és e miatt null lesz a megoldás tömb
            megoldas = keresok[0].Utvonal;
            this.comboBox1.SelectedIndex = 0;
            Kirajzol();
        }
        private void picturebox1_paint(object sender,PaintEventArgs e)
        {
            Kirajzol();
        }
        private void Kirajzol()
        {
            Bitmap image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = image;
            graphics = Graphics.FromImage(image);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(i* 100+10/*X*/,j*100+10/*Y*/, 80,80));
                }
            }
            Babu[] babuk = megoldas[aktualisHely].Babuk;
            int x;
            int y;
            bool fekete;
            for (int i = 0; i < babuk.Length; i++)
            {
                x = babuk[i].X;
                y = babuk[i].X;
                fekete = babuk[i].SzinFekete;
                if (fekete)
                {
                    graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(x * 45/*X*/, y * 45 /*Y*/, 50, 50));
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(x * 45/*X*/, y * 45 /*Y*/, 50, 50));
                }
            }
            //string[] korongok = megoldas[aktualisHely];

            //for (int i = 0; i < korongok.Length; i++)
            //{
            //    int oszlopSzam = 0;
            //    if (korongok[i] == "Q")
            //    {
            //        oszlopSzam = 1;
            //    }
            //    else if (korongok[i] == "R")
            //    {
            //        oszlopSzam = 2;
            //    }

            //    int pozicio = 0;
            //    for (int j = i + 1; j < korongok.Length; j++)
            //    {
            //        if (korongok[j] == korongok[i]) pozicio++;
            //    }

            //    graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(40 + oszlopSzam * 150 - i * 15, 180 - pozicio * 30, 60 + i * 30, 30));
            //}
            label1.Text = "Lépések (Kezdő állapottal együtt): " + megoldas.Count();
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aktualisHely > 0)
            {
                aktualisHely--;
            }
            Kirajzol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aktualisHely + 1 < megoldas.Count)
            {
                aktualisHely++;
            }
            Kirajzol();
        }
    }
    
}

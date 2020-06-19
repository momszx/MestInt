using MestIntBeadando.AlllapotTer;
using MestIntBeadando.Keresok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            keresok.Add(new BackTrack());
            keresok.Add(new HibaProbaRandom());
            foreach(Kereso kereso in keresok)
            {
                comboBox1.Items.Add(kereso.GetType().Name);
            }//üres a megoldás és e miatt null lesz a megoldás tömb
            megoldas = keresok[1].Utvonal;
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
            graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0 /*X*/, 0 /*Y*/, 400, 5));
            //tábla kiralyzolása
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
            //Babuk felrajzolása a táblára
            for (int i = 0; i < babuk.Length; i++)
            {
                x = babuk[i].X;
                y = babuk[i].Y;
                fekete = babuk[i].SzinFekete;
                if (fekete)
                {
                    graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(x * 100 - 75/*X*/, y * 100 - 75 /*Y*/, 50, 50));
                }
                else
                {
                    graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(x * 100-75/*X*/, y * 100 - 75 /*Y*/, 50, 50));
                }
            }
            label1.Text = "Lépések (Kezdő állapottal együtt): " + megoldas.Count();
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-");
            if (aktualisHely > 0)
            {
                aktualisHely--;
                
            }
            Kirajzol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("+");
            if (aktualisHely + 1 < megoldas.Count)
            {
                aktualisHely++;
                
            }
            Kirajzol();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            megoldas = keresok[comboBox1.SelectedIndex].Utvonal;
            aktualisHely = 0;
            Kirajzol();
        }
    }
    
}

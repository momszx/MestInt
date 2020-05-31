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
            }
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
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(i* 30/*X*/,j*30/*Y*/, 30,30));
                    //graphics.FillRectangle(new SolidBrush(Color.Gray), new Rectangle(i * 150 + 60, 60, 20, 150));
                }
            }
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

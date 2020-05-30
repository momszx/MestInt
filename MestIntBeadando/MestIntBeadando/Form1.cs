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
        }
    }
    
}

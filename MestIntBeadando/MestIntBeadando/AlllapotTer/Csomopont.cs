using System;

namespace MestIntBeadando.AlllapotTer
{
    class Csomopont
    {
        private Allapot allapot;
        public Allapot Allapot
        {
            get { return allapot; }
            set { allapot = value; }
        }
        private int index;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        private Csomopont szulo;

        public Csomopont Szulo
        {
            get { return szulo; }
            set { szulo = value; }
        }

        private int koltseg;

        public int Koltseg { get => koltseg; set => koltseg = value; }
        public int Heurisztika { get => heurisztika; set => heurisztika = value; }
        public int OsszKoltseg { get => osszKoltseg; set => osszKoltseg = value; }

        public Csomopont(Allapot allap, int index)
        {
            this.index = index;
            this.allapot = allap;
        }

        

        private int osszKoltseg;

        public Csomopont(Allapot allap, int index, Csomopont szulo)
        {
            this.index = index;
            this.allapot = allap;
            this.szulo = szulo;
            if (szulo == null)
            {
                Koltseg = 1;
            }
            else
            {
                Koltseg = szulo.Koltseg + 1;
            }
            

            this.osszKoltseg = Koltseg + Heurisztika;
        }
        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return Allapot.ToString();
        }
    }

}

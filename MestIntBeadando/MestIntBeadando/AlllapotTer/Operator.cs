namespace MestIntBeadando.AlllapotTer
{
    class Operator
    {
        private int melyiket;
        public int Melyiket
        {
            get { return melyiket; }
            set { melyiket = value; }
        }


        private Babu hova;
        public Babu Hova
        {
            get { return hova; }
            set { hova = value; }
        }

        public Operator(int melyiket, Babu hova)
        {
            this.melyiket = melyiket;
            this.hova = hova;
        }
        public Allapot Mozgatas(Allapot allapot)
        {
            Allapot ujallapot = new Allapot();
            for (int i = 0; i < Allapot.BABUSZAM; i++)
            {
                ujallapot.Babuk[i] = allapot.Babuk[i];
            }
            ujallapot.Babuk[melyiket].X = hova.X;
            ujallapot.Babuk[melyiket].Y = hova.Y;
            return ujallapot;
            
        }
        public bool Elofeltetel(Allapot allapot)
        {
            if (allapot.Babuk[melyiket] == hova)
            {
                return false;
            }
            for (int i = 0; i < melyiket; i++)
            {
                if (allapot.Babuk[i] == allapot.Babuk[melyiket] || allapot.Babuk[i]==hova)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

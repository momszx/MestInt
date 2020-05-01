namespace MestIntBeadando.AlllapotTer
{
    class Operator
    {
        private int[] melyiket;
        public int[] Melyiket
        {
            get { return melyiket; }
            set { melyiket = value; }
        }


        private int[] hova;
        public int[] Hova
        {
            get { return hova; }
            set { hova = value; }
        }

        public Operator(int[] melyiket, int[] hova)
        {
            this.melyiket = melyiket;
            this.hova = hova;
        }
        public Allapot Mozgatas(Allapot allapot)
        {
            string seged = "";
            Allapot ujallapot = new Allapot();
            for (int i = 0; i < Allapot.feher; i++)
            {
                for (int k = 0; k < Allapot.feher; k++)
                {
                    ujallapot.Poziciok[i, k] = allapot.Poziciok[i, k];
                }
            }
            seged = ujallapot.Poziciok[hova[0], hova[1]];
            ujallapot.Poziciok[hova[0], hova[1]] = ujallapot.Poziciok[melyiket[0], melyiket[1]];
            ujallapot.Poziciok[melyiket[0], melyiket[1]] = seged;
            return ujallapot;
        }
        public bool Elofeltetel(Allapot allapot)
        {
            if (allapot.Poziciok[hova[0], hova[1]] == allapot.Poziciok[melyiket[0], melyiket[1]])
            {
                return false;
            }
            for (int i = 0; i < melyiket[0]; i++)
            {
                for (int j = 0; j < melyiket[1]; j++)
                {
                    if   (allapot.Poziciok[i,j]==allapot.Poziciok[melyiket[0],melyiket[1]]|| allapot.Poziciok[i, j] == allapot.Poziciok[hova[0], hova[1]])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

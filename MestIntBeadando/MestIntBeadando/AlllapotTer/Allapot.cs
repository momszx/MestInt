namespace MestIntBeadando.AlllapotTer
{
    class Allapot
    {
        public static int BABUSZAM = 6;
        private Babu[] babuk = new Babu[BABUSZAM];

        public Babu[] Babuk
        {
            get
            {
                return babuk;
            }
            set
            {
                babuk = value;
            }
        }
        public Allapot()
        {
            //fehér
            for (int i = 0; i < babuk.Length/2; i++)
            {
                for (int j = 1; j <babuk.Length/2; i++)
                {
                    babuk[i].X =j;
                    babuk[i].Y =1;
                    babuk[i].SzinFekete =false;
                }
            }
            //fekete
            for (int i = 3; i < babuk.Length; i++)
            {
                for (int j = 1; j < babuk.Length / 2; i++)
                {
                    babuk[i].X = j;
                    babuk[i].Y = 3;
                    babuk[i].SzinFekete = true;
                }
            }
        }
        public bool celAlllapot()
        {
            //fekete ellenörzés
            for (int i = 3; i < babuk.Length; i++)
            {
                if (babuk[i].SzinFekete == false && babuk[i].Y==1)
                {
                    return false;
                }
            }
            //fehér ellenörzés
            for (int i = 0; i < babuk.Length/2; i++)
            {
                if (babuk[i].SzinFekete == true && babuk[i].Y==3)
                {
                    return false;
                }
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            Allapot masikallapot = (Allapot)obj;
            for (int i = 0; i < babuk.Length; i++)
            {
                if (babuk[i] != masikallapot.babuk[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

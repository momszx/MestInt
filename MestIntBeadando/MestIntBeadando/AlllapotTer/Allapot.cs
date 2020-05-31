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
            for (int i = 0; i < babuk.Length / 2; i++)
            {
                Babu babu = new Babu();
                babu.X = i + 1;
                babu.Y = 1;
                babu.SzinFekete = false;
                Babuk[i] = babu;
            }
            //fekete
            for (int i = 3; i < babuk.Length; i++)
            {
                Babu babu = new Babu();
                babu.X = i - 2;
                babu.Y = 3;
                babu.SzinFekete = true;
                Babuk[i] = babu;
            }
        }
        public bool celFeltetel()
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

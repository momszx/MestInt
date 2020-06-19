using System.Text;

namespace MestIntBeadando.AlllapotTer
{
    class Allapot
    {
        public static int BABUSZAM = 6;
        private Babu[] babuk = new Babu[BABUSZAM];
        public static Babu[] poziciok = new Babu[] { };

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
            bool feherjo = false;
            bool feketejo = false;
            for (int i = 0; i < babuk.Length; i++)
            {
                if (babuk[i].SzinFekete)
                {
                    if (babuk[i].Y==1)
                    {
                        feketejo = true;
                    }
                    else
                    {
                        feketejo = false;
                    }
                }
                if (!babuk[i].SzinFekete)
                {
                    if (babuk[i].Y==3)
                    {
                        feherjo = true;
                    }
                    else
                    {
                        feherjo = false;
                    }
                } 
            }
            if (feherjo && feketejo)
            {
                return true;
            }
            else
            {
                return false;
            }
            ////fekete ellenörzés
            //for (int i = 3; i < babuk.Length; i++)
            //{
            //    if (babuk[i].SzinFekete == true && babuk[i].Y==1)
            //    {
            //        return false;
            //    }
            //}
            ////fehér ellenörzés
            //for (int i = 0; i < babuk.Length/2; i++)
            //{
            //    if (babuk[i].SzinFekete == false && babuk[i].Y==3)
            //    {
            //        return false;
            //    }
            //}
            //return true;
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
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("(");
            for (int i = 0; i < BABUSZAM; i++)
            {
                builder.Append("Y=");
                builder.Append(babuk[i].X);
                builder.Append(",Y=");
                builder.Append(babuk[i].Y);
                if (babuk[i].SzinFekete)
                {
                    builder.Append(",Fekete");
                }
                else
                {
                    builder.Append(",Fehér");
                }
                builder.Append("    ");
            }
            return base.ToString();
        }
    }
}

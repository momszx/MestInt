namespace MestIntBeadando.AlllapotTer
{
    class Allapot
    {
        public static int fekete = 3;
        public static int feher = 3;
        private string[,] poziciok = new string[3, 3];


        public string[,] Poziciok
        {
            get
            {
                return poziciok;
            }
            set
            {
                poziciok = value;
            }
        }
        public Allapot()
        {
            for (int i = 0; i < feher; i++)
            {
                poziciok[3, i] = "FehL";
            }
            for (int i = 0; i < feher; i++)
            {
                poziciok[2, i] = "0";
            }
            for (int i = 0; i < fekete; i++)
            {
                poziciok[1, i] = "FekL";
            }
        }
        public bool celAlllapot()
        {
            for (int i = 0; i < feher; i++)
            {
                if (poziciok[3, i] == "FehL")
                {
                    return false;
                }
            }
            for (int i = 0; i < fekete; i++)
            {
                if (poziciok[1, i] == "FekL")
                {
                    return false;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (poziciok[2, i] == "0")
                {
                    return false;
                }
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            Allapot masikallapot = (Allapot)obj;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (poziciok[j, i] != masikallapot.Poziciok[j, i])
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}

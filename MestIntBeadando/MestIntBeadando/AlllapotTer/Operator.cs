using System;

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
            Console.WriteLine(hova.X+"=X");
            Console.WriteLine(hova.Y + "=Y");

            //mindegyik hez le van generálva hova kerülhet
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
            //Console.WriteLine(allapot.Babuk.Length+" babuk száma");
            // Megviszgálom nem e ugyan oda tenném a bábut 
            // valamiért a hova értéke mindig 3 
            Console.WriteLine("------------");
            Console.WriteLine("|" + allapot.Babuk[melyiket].X + "->" + hova.X + "  " + allapot.Babuk[melyiket].Y + "->" + hova.Y + "|");
            Console.WriteLine("------------");
            if (allapot.Babuk[melyiket].X == hova.X && allapot.Babuk[melyiket].Y == hova.Y)
            {
                
                //Console.WriteLine("Elofelteltel 1. if hamis");
                
                return false;
            }
            // Megvizsgálom hogy ures e az a hely ahova lépnék
            for (int i = 0; i < Allapot.BABUSZAM; i++)
            {
                if(allapot.Babuk[i].X==hova.X && allapot.Babuk[i].Y == hova.Y)
                {
                    
                    Console.WriteLine("Elofelteltel 2. if hamis");
                    
                    return false;
                }
            }
            // Megvizsgálom hogy ahova lépnék "L" alakban helyezkedik e el ahol vagyok 
            if (!((allapot.Babuk[melyiket].X-hova.X)==1&&(allapot.Babuk[melyiket].Y-hova.Y)==2)|| ((allapot.Babuk[melyiket].X - hova.X) == 2 && (allapot.Babuk[melyiket].Y - hova.Y) == 1))
            {
                
                Console.WriteLine("Elofelteltel 3. if hamis");
                
                return false;
            }
            
            Console.WriteLine("!!!!!!Igazt adott vissza ");
            
            return true;
        }
    }
}

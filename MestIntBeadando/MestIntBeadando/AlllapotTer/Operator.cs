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
            //Console.WriteLine(hova.X+"=X");
            //Console.WriteLine(hova.Y + "=Y");
            //Console.WriteLine(" ");

            //Az a hiba hogy mindig felül írja és az utolsó lesz a 3x 3y
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
                    
                    //Console.WriteLine("Elofelteltel 2. if hamis");
                    
                    return false;
                }
            }
            // Megvizsgálom hogy ahova lépnék "L" alakban helyezkedik e el ahol vagyok 
            if (!(LAlak1(allapot)|| LAlak2(allapot)))
            {
                
                //Console.WriteLine("Elofelteltel 3. if hamis");
                
                return false;
            }

            //Console.WriteLine("----------------");
            //Console.WriteLine("|x=" + allapot.Babuk[melyiket].X + "->" + hova.X + "=" + (allapot.Babuk[melyiket].X - hova.X) + "  Y=" + allapot.Babuk[melyiket].Y + "->" + hova.Y + "=" + (allapot.Babuk[melyiket].Y - hova.Y) + "|");
            //Console.WriteLine("----------------");
            //Console.WriteLine("!!!!!!Igazt adott vissza ");
            Console.WriteLine("igaz lett");
            return true;
        }
        private bool LAlak1(Allapot allapot)
        {
            bool elsofeltetel = (allapot.Babuk[melyiket].X - hova.X) == 1;
            bool masodikfeltetel = (allapot.Babuk[melyiket].Y - hova.Y) == 2;
            if (elsofeltetel && masodikfeltetel ){
                return true;
            }
            return false;
        }
        private bool LAlak2(Allapot allapot)
        {
            bool elsofeltetel = (allapot.Babuk[melyiket].X - hova.X) == 2;
            bool masodikfeltetel = (allapot.Babuk[melyiket].Y - hova.Y) == 1;
            if ( elsofeltetel && masodikfeltetel){
                return true;
            }
            return false;
        }
    }
}

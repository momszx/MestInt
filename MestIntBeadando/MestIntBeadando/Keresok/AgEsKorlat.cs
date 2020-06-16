using MestIntBeadando.AlllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestIntBeadando.Keresok
{
    class AgEsKorlat : Kereso
    {
        public AgEsKorlat()
        {
            Kereses();
        }
        public override void Kereses()
        {
            Stack<Csomopont> ut = new Stack<Csomopont>();
            Csomopont kezdoAllapot = new Csomopont(new Allapot(), 0);
            ut.Push(kezdoAllapot);
            //Console.WriteLine(ut.Count);
            while (ut.Count > 0)
            {
                //Console.WriteLine(ut.Count);
                Csomopont aktualisCsomopont = ut.Peek();

                //Console.WriteLine(this.operatorok.Count +">"+ aktualisCsomopont.Index);

                if(this.operatorok.Count>aktualisCsomopont.Index){
                    //Console.WriteLine("if 1");


                    Operator aktualisOperator = operatorok[aktualisCsomopont.Index];

                    //for (int i = 0; i < 6; i++)
                    //{
                    //    Console.WriteLine(aktualisCsomopont.Allapot.Babuk[i].X);
                    //    Console.WriteLine(aktualisCsomopont.Allapot.Babuk[i].Y);
                    //    Console.WriteLine(aktualisCsomopont.Index);
                    //    Console.WriteLine(" ");
                    //}


                    if (aktualisOperator.Elofeltetel(aktualisCsomopont.Allapot)){//2 ide nem lép be elötte van a hiba


                        Console.WriteLine("if 2");
                        Allapot ujAllapot = aktualisOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);
                        if(!ut.Contains(ujCsomopont)&&(Utvonal.Count==0 || ut.Count < Utvonal.Count))
                        {
                            ut.Push(ujCsomopont);
                            Console.WriteLine("Pusholtam az uj csomopontot");
                        }
                    }
                    aktualisCsomopont.Index++;
                }
                else
                {
                    Csomopont torol = ut.Pop();
                    //Console.WriteLine(torol+" töröltem"); 
                }
                if(ut.Count>0&& ut.Peek().Allapot.celFeltetel())
                {
                    if(Utvonal.Count==0|| ut.Count < Utvonal.Count)
                    {
                        Utvonal.Clear();
                        for (int i = 0; i < ut.Count; i++)
                        {
                            Utvonal.Add(ut.ElementAt(i).Allapot);
                        }
                        Utvonal.Reverse();
                    }
                }
            }
        }
    }
}

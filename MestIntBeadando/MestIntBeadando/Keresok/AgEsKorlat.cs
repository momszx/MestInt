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


                    if (aktualisOperator.Elofeltetel(aktualisCsomopont.Allapot)){


                        //Console.WriteLine("if 2");
                        Allapot ujAllapot = aktualisOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);
                        //Console.WriteLine(ut.Count);
                        //Console.WriteLine(Utvonal.Count);
                        //Console.WriteLine(ut.Contains(ujCsomopont));
                        //Console.WriteLine(Utvonal.Count == 0);
                        if (!ut.Contains(ujCsomopont) && (Utvonal.Count == 0 || ut.Count < Utvonal.Count))
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
                    Console.WriteLine("1.if");
                    if(Utvonal.Count==0|| ut.Count < Utvonal.Count)
                    {
                        Console.WriteLine("2.if");
                        Utvonal.Clear();
                        for (int i = 0; i < ut.Count; i++)
                        {
                            Utvonal.Add(ut.ElementAt(i).Allapot);
                            Console.WriteLine("hozzá adtam egy útvonalat");
                        }
                        Utvonal.Reverse();
                    }
                }
            }
        }
    }
}

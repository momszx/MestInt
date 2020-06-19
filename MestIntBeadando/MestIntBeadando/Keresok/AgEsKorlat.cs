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
            int d = 0;
            while (ut.Count > 0)
            {
               
                Csomopont aktualisCsomopont = ut.Peek();
                //55 ször fut le
                d++;
                if (this.operatorok.Count>aktualisCsomopont.Index){
                    //54 szer fur fut le
                    //Eddig jónak tűnik mert az operatorok száma  54 (6*9) és úgy kezdi össze hasonlítani 
                    //Fura sokkal kevesebbszer futt le a cw mint az órai kódban 
                    
                    Operator aktualisOperator = operatorok[aktualisCsomopont.Index];
                    
                   
                    if (aktualisOperator.Elofeltetel(aktualisCsomopont.Allapot)){
                        //this.elötteMozgatottSzine = aktualisOperator.;
                        // itt valamiért felül lesz írva az aktuális csomopont szerintem memória címzési hiba 
                        Allapot ujAllapot = aktualisOperator.Mozgatas(aktualisCsomopont.Allapot);
                        Csomopont ujCsomopont = new Csomopont(ujAllapot, 0);
                        //!ut.Contains(ujCsomopont) valamiért false lesz és a utvonal .count nem nő
                        if (!ut.Contains(ujCsomopont) && (Utvonal.Count == 0 || ut.Count < Utvonal.Count))
                        {
                            //miért nem pushol elemet bele soha ?
                            ut.Push(ujCsomopont);
                        Console.WriteLine("Pusholtam az uj csomopontot");
                        }
                        else
                        {
                        Console.WriteLine("NEM Pusholtam ");
                        }  
                    }
                    else
                    {
                        Console.WriteLine( "elbuktam az előfeltételt");
                    }
                    aktualisCsomopont.Index++;
                }
                else
                {
                    Csomopont torol = ut.Pop();
                    
                }
                //megvizsgálom az a célfeltétel ahol vagyok
                if(ut.Count>0&& ut.Peek().Allapot.celFeltetel())
                {
                    //megvizsgálom hogy rividebbet találtam e 
                    //Console.WriteLine("1.if");
                    if(Utvonal.Count==0|| ut.Count < Utvonal.Count)
                    {
                        //Console.WriteLine("2.if");
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
            Console.WriteLine( d);
        }
    }
}

using MestIntBeadando.AlllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestIntBeadando.Keresok
{
    class HibaProbaRandom : Kereso
    {
        public HibaProbaRandom()
        {
            Kereses();

        }
        public override void Kereses()
        {
            Allapot kezdoAllapot = new Allapot();
            Stack<Allapot> ut = new Stack<Allapot>();

            ut.Push(kezdoAllapot);

            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int szam = rnd.Next(0, operatorok.Count);
                Operator aktualisOperator = operatorok[szam];

                if (aktualisOperator.Elofeltetel(ut.Peek()))
                {
                    Allapot ujAllapot = aktualisOperator.Mozgatas(ut.Peek());
                    ut.Push(ujAllapot);

                    if (ujAllapot.celFeltetel())
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < ut.Count; i++)
            {
                Utvonal.Add(ut.ElementAt(i));
            }
            Utvonal.Reverse();
        }
    }
}

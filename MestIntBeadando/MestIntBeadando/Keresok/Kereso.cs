using MestIntBeadando.AlllapotTer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MestIntBeadando.Keresok
{
    abstract class Kereso
    {
        private List<Allapot> utvonal = new List<Allapot>();
        public List<Allapot> Utvonal
        {
            get
            {
                return utvonal;
            }
            set
            {
                utvonal = value;
            }
        }
        protected List<Operator> operatorok = new List<Operator>();
        public Kereso()
        {
            operatorokGenaralasa();
        }
        private void operatorokGenaralasa()
        {
            for (int i = 0; i < Allapot.BABUSZAM; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    operatorok.Add(new Operator(i,Allapot.))
                }
            }
        }
        public abstract void Kereses();
    }
}

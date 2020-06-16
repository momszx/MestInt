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
            Babu babu =new Babu();
            for (int i = 0; i < Allapot.BABUSZAM; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    babu.X = j;
                    for (int k = 1; k < 4; k++)
                    {
                        
                        babu.Y = k;
                        operatorok.Add(new Operator(i, babu));
                    }
                }
            }
        }
        public abstract void Kereses();
    }
}

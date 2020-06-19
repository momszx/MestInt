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
        public bool elötteMozgatottSzine;
        public Kereso()
        {
            operatorokGenaralasa();
        }
        private void operatorokGenaralasa()
        {
            
            for (int i = 0; i < Allapot.BABUSZAM; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    
                    for (int k = 1; k < 4; k++)
                    {
                        Babu babu = new Babu();
                        babu.Y = k;
                        babu.X = j;
                        Operator operators = new Operator(i, babu);
                        operatorok.Add(operators);
                    }
                }
            }
        }
        public abstract void Kereses();
    }
}

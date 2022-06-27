using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15_Checkpoint
{
    internal class ListaDeMoedas
    {

        public Dictionary<double, double> moedas = new Dictionary<double, double>()
        {

        };


    public ListaDeMoedas()
        {
            moedas.Add(1, 4.50);   // 1 Dolar
            moedas.Add(2, 6.20);   // 2 Euro
            moedas.Add(3, 0.052);  // 3 Iene
            moedas.Add(4, 6.95);   // 4 Libra
        }
    }
}




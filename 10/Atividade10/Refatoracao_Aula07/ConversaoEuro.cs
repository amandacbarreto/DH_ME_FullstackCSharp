using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao_Aula07
{
    internal class ConversaoEuro: Conversao
    {
        public override double cotacaoDaMoedaHoje
        {
            get { return 5.46; }
            set { }
        }

        public override double VALOR_MINIMO_DE_COMPRA_NA_MOEDA
        {
            get { return 50; }
            set { }
        }
        public override double VALOR_MAXIMO_DE_COMPRA_NA_MOEDA
        {
            get { return 150; }
            set { }
        }
        public override string moeda
        {
            get { return "Euro"; }
            set { }
        }
        public override string simboloMoeda
        {
            get { return "EUR"; }
            set { }
        }

    }
}

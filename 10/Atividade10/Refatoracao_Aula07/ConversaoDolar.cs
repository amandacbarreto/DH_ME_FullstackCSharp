using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao_Aula07
{
    internal class ConversaoDolar: Conversao
    {

        public override double cotacaoDaMoedaHoje
        {
            get { return 5.20; }
            set { }
        }

        public override double VALOR_MINIMO_DE_COMPRA_NA_MOEDA
        {
            get { return 100; }
            set { }
        }
        public override double VALOR_MAXIMO_DE_COMPRA_NA_MOEDA
        {
            get { return 250; }
            set { }
        }
        public override string moeda
        {
            get { return "Dólar"; }
            set { }
        }
        public override string simboloMoeda
        {
            get { return "$"; }
            set { }
        }

    }
}

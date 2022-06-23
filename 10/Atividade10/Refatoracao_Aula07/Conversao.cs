using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao_Aula07
{
    internal abstract class Conversao
    {
        abstract public double cotacaoDaMoedaHoje { get; set; }
        abstract public double VALOR_MINIMO_DE_COMPRA_NA_MOEDA { get; set; }
        abstract public double VALOR_MAXIMO_DE_COMPRA_NA_MOEDA { get; set; }
        abstract public string moeda { get; set; }
        abstract public string simboloMoeda { get; set; }
        public double valorConvertido { get; set; }

        public virtual double ConversaoCompra(double valorCompra)
        {
            return valorCompra / cotacaoDaMoedaHoje;
        }
        public virtual void VerificarCompra(double valorCompra)
        {
            valorConvertido = ConversaoCompra(valorCompra);

            string mensagem;
            if (valorConvertido < VALOR_MINIMO_DE_COMPRA_NA_MOEDA)
            {
                mensagem = $"A compra mínima permitida em {moeda} é de {simboloMoeda}{VALOR_MINIMO_DE_COMPRA_NA_MOEDA}";
            }
            else if (valorConvertido > VALOR_MAXIMO_DE_COMPRA_NA_MOEDA)
            {
                mensagem = $"A compra máxima permitida em {moeda} é de {simboloMoeda}{VALOR_MAXIMO_DE_COMPRA_NA_MOEDA}";
            }
            else
            {
                mensagem = $"Você pode comprar {simboloMoeda}{valorConvertido.ToString("F2")}";
            }
            Console.WriteLine(mensagem + Environment.NewLine);
        }

    }
}

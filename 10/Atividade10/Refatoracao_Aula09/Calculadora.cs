using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao_Aula09
{
    class Calculadora
    {
        private string[] Opcoes = new string[6] { "somar", "subtrair", "multiplicar", "dividir", "zerar calculadora", "sair da calculadora" }; 


        private double HistoricoCalculadora { get; set; }
   
        public double Calcular (double valor, string operacao)
        {
            try
            {

                return operacao switch
                {
                    "1" => HistoricoCalculadora += valor,
                    "2" => HistoricoCalculadora -= valor,
                    "3" => HistoricoCalculadora *= valor,
                    "4" => DividirValor(valor),
                    "5" => HistoricoCalculadora = 0,
                    _ => HistoricoCalculadora
                };
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(Environment.NewLine + "CodError001 - Divisão por 0 não é possível.");
                Console.WriteLine(erro.GetType());
                Console.WriteLine("Localização do erro." + Environment.NewLine);
                Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
            }

            return HistoricoCalculadora;
        }

        public double ValidarValor(double valorIndiferente)
        {
            double operando = valorIndiferente;
            try
            {
                operando = Double.Parse(Console.ReadLine()!);
            }
            catch (Exception erro)
            {
                Console.WriteLine(Environment.NewLine + "CodError002 - O usuário não pode inserir qualquer valor além de números.");
                Console.WriteLine(erro.GetType());
                Console.WriteLine("Localização do erro." + Environment.NewLine);
                Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
            }
            return operando;
        }

        double DividirValor(double valor)
        {
            if (valor == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return HistoricoCalculadora /= valor;
            }
        }

        public string ObterOpcaoUsuario()
        {
            Console.WriteLine("Escolha qual operação deseja realizar: ");
            for (int i = 0; i < Opcoes.Length; i++)
            {
                Console.WriteLine($"{i+1} - {Opcoes[i].ToUpper()}");
            }

            return Console.ReadLine()!;
        }
    }
}

namespace Refatoracao_Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha = "1";
            while (escolha == "1" || escolha == "2")
            {
                Console.WriteLine($"Informe qual conversão deseja fazer: {Environment.NewLine}1 - Dólar {Environment.NewLine}2 - Euro {Environment.NewLine}Digite qualquer outro valor para encerrar o programa.{Environment.NewLine}");
                escolha = Console.ReadLine()!;
                if (escolha == "1")
                {
                    ConversaoDolar conversaoDolar = new ConversaoDolar();
                    Console.WriteLine($"{Environment.NewLine}CONVERSÃO EM DÓLAR");
                    conversaoDolar.VerificarCompra(ValorCompraReais());
                }
                else if (escolha == "2")
                {
                    ConversaoEuro conversaoEuro = new ConversaoEuro();
                    Console.WriteLine($"{Environment.NewLine}CONVERSÃO EM EURO");
                    conversaoEuro.VerificarCompra(ValorCompraReais());
                } 
            }
            Console.WriteLine("Obrigada por utilizar nossos serviços!");
        }

        static public double ValorCompraReais()
        {
            double valorCompraReais = 0;
            Console.WriteLine("Informe o valor da compra em reais");
            double.TryParse(Console.ReadLine(), out valorCompraReais);
            while (valorCompraReais <= 0)
            {
                Console.WriteLine("Por favor, informe um valor em reais válido (acima de 0)");
                double.TryParse(Console.ReadLine(), out valorCompraReais);
            }
            return valorCompraReais;
        }
    }
}

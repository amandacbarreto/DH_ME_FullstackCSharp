namespace Refatoracao_Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, elementoNeutro = 0;
            Calculadora calculadora = new Calculadora();
            string opcaoUsuario = calculadora.ObterOpcaoUsuario();

            while (opcaoUsuario != "0")
            {
                if(opcaoUsuario == "1" || opcaoUsuario == "2" || opcaoUsuario == "3" || opcaoUsuario == "4" || opcaoUsuario == "5")
                {
                    switch (opcaoUsuario)
                    {
                        case "1":
                            Console.WriteLine("Você digitou 1 - Somar. Qual valor deseja somar?");
                            elementoNeutro = 0;
                            break;
                        case "2":
                            Console.WriteLine("Você digitou 2 - Subtrair. Qual valor deseja subtrair?");
                            elementoNeutro = 0;
                            break;
                        case "3":
                            Console.WriteLine("Você digitou 3 - Multiplicar. Qual valor deseja multiplicar?");
                            elementoNeutro = 1;
                            break;
                        case "4":
                            Console.WriteLine("Você digitou 4 - Dividir. Qual valor deseja dividir?");
                            elementoNeutro = 1;
                            break;
                        case "5":
                            Console.WriteLine("Você digitou 5 - Zerar calculadora.");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                    valor = calculadora.ValidarValor(elementoNeutro);
                    Console.WriteLine(calculadora.Calcular(valor, opcaoUsuario));
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

                opcaoUsuario = calculadora.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços");

        }
    }
}


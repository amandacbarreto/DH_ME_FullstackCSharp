double resultado = 0;
string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario != "0")
{
    switch (opcaoUsuario)
    {
        case "1":
            Console.WriteLine("Você digitou 1 - Somar. Qual valor deseja somar?");
            break;
        case "2":
            Console.WriteLine("Você digitou 2 - Subtrair. Qual valor deseja subtrair?");
            break;
        case "3":
            Console.WriteLine("Você digitou 3 - Multiplicar. Qual valor deseja multiplicar?");
            break;
        case "4":
            Console.WriteLine("Você digitou 4 - Dividir. Qual valor deseja dividir?");
            break;
        case "5":
            Console.WriteLine("Você digitou 5 - Zerar calculadora.");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine(Calcular(opcaoUsuario));

    opcaoUsuario = ObterOpcaoUsuario();
}

Console.WriteLine("Obrigado por utilizar nossos serviços");

double Calcular (string opcao)
{
    try { 

        return (opcao) switch
        {
            "1" => somarValor(validaValor(0)),
            "2" => subtrairValor(validaValor(0)),
            "3" => multiplicarValor(validaValor(1)),
            "4" => dividirValor(validaValor(1)),
            "5" => zerarResultado(),
            _ => 0
        };
    }
    catch (DivideByZeroException erro)
    {
        Console.WriteLine(Environment.NewLine + "CodError001 - Divisão por 0 não é possível.");
        Console.WriteLine(erro.GetType());
        Console.WriteLine("Localização do erro." + Environment.NewLine);
        Console.WriteLine("Por favor, digite um numero." + Environment.NewLine);
    }

    return pegarResultadoDaUltimaOperacaoMatematica();
}

double validaValor(int valorIndiferente)
{
    double operando = valorIndiferente;
    try
    {
        operando = Double.Parse(Console.ReadLine());
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

double somarValor(double valor)
{
    double resultadoSoma = pegarResultadoDaUltimaOperacaoMatematica() + valor;
    definirResultadoDaUltimaOperacaoMatematica(resultadoSoma);
    return resultadoSoma;
}

double subtrairValor(double valor)
{
    double resultadoSubtração = pegarResultadoDaUltimaOperacaoMatematica() - valor;
    definirResultadoDaUltimaOperacaoMatematica(resultadoSubtração);
    return resultadoSubtração;
}

double dividirValor(double valor)
{
    if (valor == 0)
    {
        throw new DivideByZeroException("CodError001 - Divisão por 0 não é possível.");
    }
    else
    {
        double resultadoDivisao = pegarResultadoDaUltimaOperacaoMatematica() / valor;
        definirResultadoDaUltimaOperacaoMatematica(resultadoDivisao);
        return resultadoDivisao;
    }
}

double multiplicarValor(double valor)
{
    double resultadoMultiplicação = pegarResultadoDaUltimaOperacaoMatematica() * valor;
    definirResultadoDaUltimaOperacaoMatematica(resultadoMultiplicação);
    return resultadoMultiplicação;
}

double zerarResultado()
{
    double zerar = resultado * 0;
    definirResultadoDaUltimaOperacaoMatematica(zerar);
    return zerar;
}

double pegarResultadoDaUltimaOperacaoMatematica()
{
    return resultado;
}

void definirResultadoDaUltimaOperacaoMatematica(double resultadoOperacao)
{
    resultado = resultadoOperacao;
}


string ObterOpcaoUsuario()
{
    Console.WriteLine("Escolha qual operação deseja realizar: ");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Zerar calculadora");
    Console.WriteLine("0 - Para sair da calculadora");

    return Console.ReadLine();
}



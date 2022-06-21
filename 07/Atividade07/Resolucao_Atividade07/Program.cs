double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
Console.WriteLine("Insira o valor da compra em reais: ");
Double.TryParse(Console.ReadLine(), out double valorDaCompraEmReais);


string converterRealParaDolar(double valorDaCompraEmReais)
{
    double valorDaCompraEmDolar = valorDaCompraEmReais / cotacaoDoDolarHoje;
    if (valorDaCompraEmDolar < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
    {
        return $"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}";
    }
    else if (valorDaCompraEmDolar > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
    {
        return $"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
    }
    else
    {
        return $"Você pode comprar $ {valorDaCompraEmDolar.ToString("F3")}";
    }
}
Console.WriteLine(converterRealParaDolar(valorDaCompraEmReais));

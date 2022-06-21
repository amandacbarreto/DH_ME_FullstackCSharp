double IMC, peso, altura;
string entrada;
Console.WriteLine("Informe o seu peso em quilos: ");
entrada = Console.ReadLine()!;
if (entrada.Contains("."))
{
    entrada = entrada.Replace(".", ",");
}
Double.TryParse(entrada, out peso);

Console.WriteLine("Informe a sua altura em metros: ");
entrada = Console.ReadLine()!;
if (entrada.Contains("."))
{
    entrada = entrada.Replace(".", ",");
}
Double.TryParse(entrada, out altura);


string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    IMC = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);
    Console.WriteLine(alturaDoUsuario);
    Console.WriteLine(pesoDoUsuario);
    Console.WriteLine(IMC);



    /* 
     * SWITCH EXPRESSION
     */
    return IMC switch
    {
        < 18.5 => "Anêmico",
        >= 18.5 and < 25 => "Normal",
        >= 25 and < 30 => "Sobrepeso",
        >= 30 and < 40 => "Obesidade",
        >= 40 => "Obesidade Mórbida",
        _ => "Valor não faz sentido"
    };


    /* 
     * IF E ELSE
     
    if (IMC < 18.5)
    {
        return "Abaixo do peso.";
    }
    else if (IMC <= 24.9)
    {
        return "Peso Normal.";
    }
    else if (IMC <= 30)
    {
        return "Sobrepeso";
    }
    else if (IMC <= 40)
    {
        return "Obesidade";
    }
    else
    {
        return "Obesidade grave";
    }
    */


    /*
     * SWITCH STATEMENT
     
    switch (IMC)
    {
        case < 18.5:
            return "Abaixo do peso.";
        case <= 25:
            return "Peso Normal.";
        case <= 30:
            return "Sobrepeso";
        case <= 40:
            return "Obesidade";
        case > 40:
            return "Obesidade grave";
        default:
            return "Valor não faz sentido";
    }
    
     */
}


Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(altura, peso)}");

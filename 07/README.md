# Aula 07 (09/06/2022) - Função e condicionais

## If

```c#
Console.WriteLine("Informe o IMC: ");
Double.TryParse(Console.ReadLine()!, out double imc);
Console.WriteLine(retornarDiagnosticoDoUsuario(imc);
string retornarDiagnosticoDoUsuario(double IMC)
{
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
}
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/blob/main/07/README.md)
- [Atividade entregue](https://github.com/mairaholi/aula07-funcoes_e_condicionais)
- [Nova resolução](./Atividade07/)

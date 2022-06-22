# Aula 09 (13/06/2022) - Tratamento de Erro

## ### Tratando uma Excessão com `try`/`catch`/`finally`

```cs
try
{
    // Forçamos o erro ao tentar dividir um valor inteiro por 0.
    int calculo = 10 / 0;
    Console.WriteLine(calculo);
}
catch (Exception error) when (calculo != 10)
{
    Console.WriteLine(error.GetType());
}
catch(Exception error)
{
    // No bloco de tratamento do erro capturamos...
    Console.WriteLine("Código do Error AbCd123");
    // Tipo do Erro nesse techo do código.
    Console.WriteLine(error.GetType());
}
finally
{
    // Definimos uma instrução que deverá ser executada após o bloco try/catch.
    // Nota: Esse trecho de código será executado independente de existir uma excessão ou não.
    Console.WriteLine("Reinicie o programa...");
}
```

> **Note**
>
> É possível aninhar vários Catches, deixando casos mais gerais por último.

### Criando uma Excessão com `throw`

```cs
int capturaDaIdadeDoUsuario = Console.ReadLine();
bool valorCapturadoForValido = int.TryParse(capturaDaIdadeDoUsuario, out idadeDoUsuario);
if(valorCapturadoForValido) {
    Console.WriteLine(idadeDoUsuario);
}
else {
    // Uma Excessão é cadastrada para tratamento.
    throw new Exception("Valor inserido é inválido.");
}
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/blob/main/09/README.md)
- [Atividade entregue](https://github.com/lanyarag/calculadora)
- [Nova resolução](./Atividade09/Resolucao_Atividade09/Program.cs)

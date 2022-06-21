# Aula 08 (10/06/2022) - Estrutura de repetição e vetores

## Estrutura de repetição

### Sintaxe do ciclo for...for

```c#
for(int contador = 0; contador < 5; contador++)
{
    Console.WriteLine($"1.1. for: {contador} Sextou");
}
```

### Sintaxe do ciclo while...

```c#

// Contador
int _contador = 0;

while (_contador < 5)
{
    Console.WriteLine($"1.2. while: {_contador} Sextou!");

    // Modificador
    _contador++;
}
```

### Sintaxe do ciclo do...while...

```c#

// Contador
int __contador = 0;

do
{
    Console.WriteLine("1.3. do...while: Sextou!");

    // Modificador
    __contador++;

}
// Condição
while (__contador < 5);
```

## Vetores

### Declarando um vetor

```c#

string[] frutas = new string[4];
frutas[0] = "Banana";
frutas[1] = "Maçã";
frutas[2] = "Pêra";
frutas[3] = "Morango";

string[] carros = { "Volvo", "BMW", "Ford" };

int[] numeros = { 10, 20, 30, 40 };
```

### Acessando valor a partir de índice/posição no vetor.

```c#
string primeiroIndiceDoVetor = frutas[0];

// Irá retornar o valor do indice 1 da lista.
// Nota: O primeiro indice de uma array é 0, portanto, o indice um é o seguindo indice do vetor.
Console.WriteLine($"Qual o primeiro indice da lista?, {primeiroIndiceDoVetor}");
```

### Atualizar valor a partir de índice/posição no vetor

```c#
string[] nomes = { "Willian", "Hugo", "Luana" };
nomes[2] = "Monique";
```

### Retornar a quantidade de itens existe no vetor

```c#
int quantidadeDeItensNoVetor = carros.Length;

Console.WriteLine($"Qual a quantidade de itens no meu vetor? {quantidadeDeItensNoVetor}");
```

### Retornar o indice do valor procurado

```c#
int indiceDoCarroFord = Array.IndexOf(carros, "Ford");
Console.WriteLine($"Qual o índice do carro Ford? {indiceDoCarroFord}");
```

## Estrutura de repetição em vetores

### Sintaxe do ciclo for em vetores

```c#
for(int indice = 0; indice < carros.Length; indice++)
{
    // 3.1.2. Vou retornando cada valor a partir do índice.
    Console.WriteLine($"{indice} - {carros[indice]}");
}
```

### Sintaxe do ciclo foreach

```c#
int ___contador = 0;

foreach(string carro in carros)
{
    // Vai retornando cada valor de cada indice.
    Console.WriteLine(carro);

    // Indices do vetor.
    Console.WriteLine(Array.IndexOf(carros, carro));
    Console.WriteLine(___contador);
    ___contador++;
}
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/blob/main/08/README.md)
- [Atividade entregue](https://github.com/isabelalvescatao/aula08-Ciclos_e_Vetores)
- [Nova resolução](./Atividade08/Resolucao_Atividade08/Program.cs)

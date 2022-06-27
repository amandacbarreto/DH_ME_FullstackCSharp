# Aula 13 (21/06/2022) - Coleção: Enum, Dictionary, Hashtable, SortedList e Iterador

## Enum: Enumeradores

###### [Tipos de enumeração (referência C#)](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/enum)

Um tipo de enumeração é um tipo de valor definido por um **conjunto de constantes nomeadas com o tipo numérico integral subjacente**. Para definir um tipo de enumeração, use a palavra-chave `enum` e especifique os nomes dos enum.
Por padrão, os valores constantes associados de membros de enumeração são do tipo int e começam com zero e aumentam em um, seguindo a ordem de texto de definição. Você pode especificar explicitamente qualquer outro tipo numérico integral como um tipo subjacente de um tipo de enumeração. Você também pode especificar explicitamente os valores constantes associados.

`Declarar / Popular`

```cs
enum Dias { Segunda, Terca, Quarta, Quinta, Sexta };
enum Cores
{
	Verde = 0xFF0000,
	Azul = 0x000FF,
    Amarelo = 0xFFFF00,
    Laranja = 0xFFA500,
    Roxo = 0xA020F0
}
```

`Acessar`

```cs
Dias Disponibilidade = Dias.Segunda;
Cores Hexadecimal = Cores.Azul;
```

`Iterar`

```cs
Array NomesDasCores = Enum.GetNames(typeof(Cores));
Array Hexadecimais = Enum.GetValues(typeof(Cores));
foreach (string cor in NomesDasCores)
{
	Console.WriteLine($"Nome da cor: {cor}");
}
foreach (string herexadecimal in Hexadecimais)
{
	Console.WriteLine($"Valor do código da cor: {herexadecimal}");
}
```

## Dictionary: Coleção de chave e valor

###### [Dictionary<TKey,TValue> Classe](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0)

Representa uma coleção de chaves e valores.

### Parâmetros de tipo

`TKey`: O tipo das chaves no dicionário.

`TValue`: O tipo dos valores no dicionário.

`Declarar`

```cs
Dictionary<string, string> UF = new Dictionary<string, string>();
```

`Adicionar chave e valor`

```cs
UF.Add("RJ", "Rio de Janeiro");
UF.Add("SP", "São Paulo");
UF.Add("MG", "Minas Gerais");
```

`Acessar`

```cs
string Estado = UF["RJ"];
UF.TryGetValue("RJ", out string Estado);

Estado = UF["RS"]; // Retornará uma exceção, pois não encontra a referência.
```

`Remover`

```cs
UF.Remove("MG");
```

`Verificar se a Key existe`

```cs
bool ValidarTemUF = UF.ContainsKey("RJ"); // true
```

`Verificar se a Value existe`

```cs
bool ValidarTemValor = UF.ContainsValue("Carioca"); // true
```

`Validar se existe, se não existir adicionar a coleção`

```cs
UF.TryAdd("MG", "Mineiro");
UF.TryAdd("RJ", "Carioca"); //Se a chave existir, não irá adicionar (mesmo que o 'value' seja diferente)
```

`Iterar`

```cs
foreach (KeyValuePair<string, string> local in UF)
{
    Console.WriteLine($"{local.Key} {local.Value}");
}
```

## Hashtable: Coleção de chave e valor

###### [Hashtable Classe](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.hashtable?view=net-6.0)

Representa uma coleção de pares chave-valor organizados com base no código hash da chave.

```cs
Hashtable _UF = new Hashtable();

//Adicionar chave/valor
_UF.Add("RJ", "Rio de Janeiro");
_UF.Add("SP", "São Paulo");
_UF.Add("MG", "Minas Gerais");

// Remover chave/valor
_UF.Remove("MG");

// Iterar
foreach (DictionaryEntry local in _UF)
{
    Console.WriteLine($"{local.Key} {local.Value}");
}

// Consultar o HashCode (o código Hash padrão é um Int32)
UF.GetHashCode("RJ"); // 4390979

```

### Diferenças entre `Dictionary` e `Hashtable`

###### [Fonte: Slide professor "Coleção: Enum, Dictionary, Hashtable, SortedList e Iterador"](https://docs.google.com/presentation/d/1b2XABKOt22lPtaIyr6gZdPTaMjxT2tcO/edit#slide=id.g135cdb9b37b_0_646)

| Hashtable                                                                                        | Dictionary                                                                             |
| ------------------------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------- |
| pode armazenar pares de chave/valor do mesmo tipo ou de tipos diferentes                         | pode armazenar pares de chave/valor do mesmo tipo                                      |
| não há necessidade de especificar o tipo de chave e valor                                        | precisa especificar o tipo da chave e valor                                            |
| se você tentar acessar uma chave que não está presente na Hashtable, ela fornecerá valores nulos | se você tentar acessar uma chave que não está presente no dicionário, ocorrerá um erro |
| não mantém a ordem dos valores armazenados                                                       | sempre mantém a ordem dos valores armazenados                                          |

### SortedList: Coleção de chave e valor ordenada

###### [SortedList Classe](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.sortedlist?view=net-6.0)

Representa uma coleção de pares chave/valor que são classificados pelas chaves e são acessíveis por chave e por índice.

```cs
// Declarar
SortedList __UF = new SortedList();

// Adicionar
__UF.Add("BA", "Bahia");
__UF.Add("TO", "Tocantins");
__UF.Add("AC", "Acre");
// OBSERVAÇÃO: As chaves são ordenadas em sequência, conforme o que fizer mais sentido pelo tipo.
// Por exemplo, nesse caso, tratam-se de valores do tipo String, então as chaves serão organizadas em ordem alfabética:
// 0 - AC: Acre
// 1 - BA: Bahia
// 2 - TO: Tocantins

//Acessar
string Estado = __UF["TO"];
Estado = __UF["RS"]; // Retornará uma exceção, pois não encontra a referência.

// Remover
__UF.Remove("BA");

// Capturar valor pelo Indice
__UF.GetByIndex(0); // Acre

// Capturar
__UF.GetKey("AC"); // CONFERIR O RETORNO

// Definir valor
__UF.SetByIndex(0, "Acreano");
__UF.SetByIndex(1, "Baiano");
__UF.SetByIndex(2, "Tocantinense");
// ou ainda:
__UF["AC"] = "Acreano";
__UF["BA"] = "Baiano";
__UF["TO"] = "Tocantinense";

// Validar se existe Chave
__UF.ContainsKey("AC"); // true

// Validar se existe Valor
__UF.ContainsKey("Acreano"); // true

// Iterar
for(int i = 0; i < __UF.Count(); i++) 
{
    Console.WriteLine(
$"{__UF.Key(i)} - {__UF.Value(i)}"
);
}
```

### Diferenças entre `Dictionary` e `SortedList`

###### [Fonte: Slide professor "Coleção: Enum, Dictionary, Hashtable, SortedList e Iterador"](https://docs.google.com/presentation/d/1b2XABKOt22lPtaIyr6gZdPTaMjxT2tcO/edit#slide=id.g135cdb9b37b_0_1105)

| SortedList | Dictionary |
| ---------- | ---------- |
| pode armazenar pares de chave/valor do mesmo tipo ou de tipos diferentes | pode armazenar pares de chave/valor do mesmo tipo |
| não há necessidade de especificar o tipo de chave e valor | precisa especificar o tipo da chave e valor |
| é possível acessar e atualizar valores a partir de seu índice | essas operações só podem ser realizadas a partir de uma chave |
| reordena os valores sequencialmente utilizando a chave como referência | sempre mantém a ordem original dos valores armazenados|


---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/tree/main/13)
- [Atividade entregue](https://github.com/lanyarag/enumDictionary.git)
- [Resolução professor](./Atividade13_ResolucaoProfessor.cs)

# Aula 12 (20/06/2022) - Coleção: Array, ArrayList e List

## Array: Vetor unidimensional

```cs
String[] Frutas;
Frutas = new String[5];
Frutas[0] = "Abacaxi";
Frutas[1] = "Pêra";
Frutas[2] = "Maçã";
Frutas[3] = "Banana";
Frutas[4] = "Mamão";
```

## Array: Vetor multidimensional

```cs
String[,] Coordenada;
Coordenada = new String[2,2];
Coordenada[0,0] = "⭐";
Coordenada[0,1] = "2";
Coordenada[1,0] = "3";
Coordenada[1,1] = "4";

/*
A visualização desse vetor seria da seguinte forma:

             COLUNAS
             0     1
LINHA 0    [0,0] [0,1]
LINHA 1    [1,0] [1,1]

Ou seja:

           COLUNAS
            0   1

LINHA 0     ⭐  2
LINHA 1     3   4
*/
```

## List: Lista de valores

```cs
List<String> Frutas;
Frutas = new List<String>();
Frutas[0] = "Abacaxi";
Frutas[1] = "Pêra";
Frutas[2] = "Maçã";
Frutas[3] = "Banana";

Frutas.Add("Mamão");
Frutas.Remove("Pêra");
Frutas.IndexOf("Abacaxi");  //retorna 0
Frutas.Contains("Banana");  //retorna true
Frutas.Contains("Pêra");    //retorna false, pois "Pêra" foi retirado da lista
Frutas.Count();             // retorna 4
```

## ArrayList: Coleção de valores

```cs
ArrayList Gaveta;
Gaveta = new ArrayList();
Gaveta[0] = "string";
Gaveta[1] = null;
Gaveta[2] = 1;
Gaveta[3] = 2.5;
Gaveta[4] = true;
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/tree/main/12)
- [Atividade entregue](https://github.com/beatrizfriso/aula12-listas.git)

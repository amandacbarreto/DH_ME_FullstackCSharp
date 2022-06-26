# Aula 10 (14/06/2022) - Introdução a Orientação a Objeto

## Encapsulamento

Agrupamento das variáveis e funções em uma classe.
Podemos dizer que separamos em `atributos` (variáveis) e `métodos` (funções).

```c#
public class Lampada
{
    // Propriedade (variáveis)
    public string Fabricante = String.Empty;
    private int Voltagem;

    // Métodos (funções)
    public virtual bool LigarOuDesligar()
    {

    }
}
```

`public` propriedade ou método público, acessível fora dda classe.
`private` propriedade ou método privado, escopo local, acessível apenas dentro da classe.

## Abstração

Abstraimos atributos e métodos através de controladores de acesso, separando os recursosque poderão ser acessados externamente.

```c#
public class Lampada
{
    // Propriedade (variáveis)
    public string Fabricante = { get; set; };

    // Definimos propriedades que serão Abstraídas/Privados de acesso.
    private int Voltagem = 110;

    // Definimos método que serão Abstraídos/Privados de acesso.
    private void GerarRelatorioDeUso() { }

    // Método Acessível/Público - Funções
    public virtual bool LigarOuDesligar()
    {
        return true;
    }
}
```

> **Note**
>
> Quando não especificamos o controlador de acesso, entende-se que o acesso é do tipo `private`. Ou seja, caso precisemos que o acesso a(o) propriedade/método seja público, precisamos declarar isso para o programa através do controlador `public`.

## Herança

É possível herdar as características (atributos e métodos) de outro objeto e continuar a implementação de novos recursos em um novo escopo.

```c#
class Lampada
{
    public string Fabricante = { get; set; };
    private int Voltagem = 110;
    private void GerarRelatorioDeUso() { }
    public virtual bool LigarOuDesligar()  { }
}

// Herdamos os atributos e métodos da classe Lampada.
class Hue : Lampada {
    public void VariarIluminosidade() { }
}

```

## Polimorfismo

A partir de uma herança, podemos sobrescrever da classe herdada, sobrescrevendo alguns recursos herdados, ou seja, gerando novas formas de realizar a tarefa.

```c#
class Lampada
{
    public string Fabricante = { get; set; };
    private int Voltagem = 110;
    private void GerarRelatorioDeUso() { }
    public virtual bool LigarOuDesligar() { }
}

class Hue : Lampada
{
    public void VariarIluminosidade() { }

    // Sobrescrevemos a funcionalidade de ligar/Desligar.
    public override bool LigarOuDesligar() { }
}
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/blob/main/10/README.md)
- [Atividade entregue](https://github.com/amandacbarreto/aula10_orientacao-a-objetos/tree/main/mesa-de-trabalho)
- [Nova resolução](./Atividade10/)

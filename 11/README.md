# Aula 11 (15/06/2022) - Controladores de acesso

`Modificador de Classe` define a visibilidade/comportamento da Classe.

`Controlador de Acesso` especifica em que momento um membro (atributos e métodos) da Classe poderá ser acessível.

```c#
[Modificador Classe] class Lampada
{

    [Controlador de Acesso] string Fabricante = { get; set; };

    [Controlador de Acesso] virtual bool LigarOuDesligar()
    {

    }
}
```

## Modificadores de visibilidade/comportamento da classe

- **`public`**: sem restrições de visibilidade. Objetos dessa classe poderão acessar todos os membros (atributos e métodos) que também forem do tipo público.

- **`abstract`**: classe-base para outras classes, não podem ser instânciadas. Métodos do tipo abstrato não podem ser definidos na própria classe abstrata, podem apenas ser declarados e posteriormente reescritos nas classes que herdam seus membros.

```c#
namespace Aula11
{
    public abstract class Conversao
    {
        abstract public double cotacaoDaMoedaHoje { get; set; }
        abstract public string moeda { get; set; }
        abstract public string simboloMoeda { get; set; }
        public abstract void ConversaoCompra(double valorCompra);
        public abstract void VerificarCompra(double valorCompra);
    }
}
```

- **`sealed`**: classe não permite herança.

- **`static`**: Classe pode ser utilizanda sem a necessidade de instânciá-la. Um exemplo de classe estática é a classe Console, que permite a chamada de seus métodos diretamente pelo nome da classe, sem ser preciso instanciar um objeto do tipo console antes.

```c#
Console.WriteLine("Não foi preciso declarar um objeto do tipo Console para utilizarmos esse método.");
```

## Lista de controladores de acesso dos membros da classe

- **`public`**: Sem restrição de acesso.

- **`private`**: Só podem ser acessados pela própria classe.

- **`protected`**: Podem ser acessados pela própria classe e por classes derivadas/herdeiras.

- **`virtual`**: permite que o método seja redefinido por classes derivadas/herdeiras. Ou seja, diferente da classe do tipo `abstract` que só permite a declaração de métodos, sem permitir a criação de um escopo, os métodos do tipo `virtual` permitem que além de declarado, esse método já tenha algum código, o qual **poderá ser reescrito** (mas não é obrigatório) nas classes derivadas, através do uso de `override`. Inclusive, é possível criar métodos virtuais dentro de uma classe abstrata.

```c#

// Nesse exemplo, uma classe do tipo abstrata (Conversao),
// possui propriedades abstratas (referentes às informações das moedas)
// e métodos virtuais que serão aproveitados completamente pelas classes derivadas.
// Assim, nas classes derivadas (ConversaoDolar e ConversaoEuro) só será necessário
// atualizar as informações referentes às moedas.

namespace Refatoracao_Aula07
{
    internal abstract class Conversao
    {
        abstract public double cotacaoDaMoedaHoje { get; set; }
        abstract public string simboloMoeda { get; set; }
        public double valorConvertido { get; set; }

        public virtual double ConversaoCompra(double valorCompra)
        {
            return valorCompra / cotacaoDaMoedaHoje;
        }
        public virtual void VerificarCompra(double valorCompra)
        {
            valorConvertido = ConversaoCompra(valorCompra);

            string mensagem;
            mensagem = $"Você pode comprar {simboloMoeda}{valorConvertido.ToString("F2")}";
            Console.WriteLine(mensagem + Environment.NewLine);
        }
    }

    // CLASSE DERIVADA
    internal class ConversaoDolar: Conversao
    {

        public override double cotacaoDaMoedaHoje
        {
            get { return 5.20; }
            set { }
        }
        public override string simboloMoeda
        {
            get { return "$"; }
            set { }
        }

    }

    // CLASSE DERIVADA
    internal class ConversaoEuro: Conversao
    {
        public override double cotacaoDaMoedaHoje
        {
            get { return 5.46; }
            set { }
        }
        public override string simboloMoeda
        {
            get { return "EUR"; }
            set { }
        }

    }
}
```

- **`static`**: Permite que os membros da classe possam ser acessados sem a necessidade de instanciar a classe.

```c#
namespace aula11_controladores_de_acesso
{

    class Cotar
    {
        // Variável
        private string nome;
        public string Nome { get; set; }
        private const int ANO_ATUAL = 2022;

        public static int retornarDataDeNascimento(int idadeDoUsuario)
        {
            int dataNascimento = ANO_ATUAL - idadeDoUsuario;
            return dataNascimento;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Cotar cotacao = new Cotar();

            // Utilize a mensagem a seguir como base do retorno esperado:
            // Olá João, você nasceu em XXXX.
            Console.WriteLine("Digite seu nome:");
            string nomeDoUsuario = Console.ReadLine();

            cotacao.Nome = nomeDoUsuario;

            Console.WriteLine("Digite sua idade:");
            int idadeDoUsuario = int.Parse(Console.ReadLine());

            int dataDeNascimentoDoUsuario = Cotar.retornarDataDeNascimento(idadeDoUsuario);
            // Repare que o método retornarDataDeNascimento() foi chamado diretamente
            // pela classe Cotar, apesar de ter um objeto instanciado (cotacao)

            Console.WriteLine($"Olá {cotacao.Nome}, você nasceu em {dataDeNascimentoDoUsuario}.");

        }
    }
}
```

---

- [Repositório oficial](https://github.com/wssantanna/mercado-eletr-nico-0522cdmencn01bred/tree/main/11)
- [Atividade entregue](https://github.com/ArielLopes888/Aula11)

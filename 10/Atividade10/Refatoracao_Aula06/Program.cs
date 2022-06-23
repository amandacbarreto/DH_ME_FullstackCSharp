namespace Refatoracao_Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira o nome do usuario");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Insira o ano de nascimento do usuario");
            int.TryParse(Console.ReadLine(), out int anoNascimento);

            Usuario usuario = new Usuario(nome,anoNascimento);
            Console.WriteLine($"A idade do usuário é {usuario.CalcularIdade()}");
            Console.WriteLine($"A idade do usuário é {usuario.Idade}");

            Usuario usuario2 = new Usuario();
            Console.WriteLine("Insira o nome do usuario 2");

            usuario2.Nome = Console.ReadLine()!;

            Console.WriteLine("Insira o ano de nascimento do usuario");
            int.TryParse(Console.ReadLine(), out int anoNascimento2);
            usuario2.AnoNascimento = anoNascimento2;

            Console.WriteLine($"A idade do usuário 2 é {usuario2.CalcularIdade()}");
            Console.WriteLine($"A idade do usuário 2 é {usuario2.Idade}");

        }
    }
}
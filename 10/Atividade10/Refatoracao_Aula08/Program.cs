namespace Refatoracao_Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Locadora locadora = new Locadora();
            locadora.adicionaUmNovoFilmePeloSeuNome("Clube dos Cinco");
            locadora.adicionaUmNovoFilmePeloSeuNome("A Hora do Pesadelo");
            locadora.adicionaUmNovoFilmePeloSeuNome("Karatê Kid");
            locadora.adicionaUmNovoFilmePeloSeuNome("Rocky IV");
            locadora.adicionaUmNovoFilmePeloSeuNome("Conan, o Bárbaro");
            locadora.adicionaUmNovoFilmePeloSeuNome("Highlander");

            Console.WriteLine("------ Resultados da Atividade ------");

            // Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander
            Console.WriteLine($"1. Lista de todos os filmes separados por ponto e vírgula {locadora.apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");

            // Retorna o número 7.
            Console.WriteLine($"2. Retorna a quantidade de filmes da lista {locadora.quantidadeTotalDeFilmes()}");

            // Se o índice for 0, retorna Clube dos Cinco;
            Console.WriteLine($"3. Buscar um filme pelo indice {locadora.buscarNomeDoFilmePeloIndice(0)}");

            // Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th
            Console.WriteLine($"4. Adiciona um filme pelo nome {string.Join("; ", locadora.adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th"))}");


            // Se o índice for 3 e o nome for atualizado para Rocky III, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky III; Conan, o Bárbaro; Highlander, Sexta-feira 13th
            Console.WriteLine($"5. Atualizar um filme pelo seu índice {string.Join("; ", locadora.atualizarUmFilmePeloSeuIndice(3, "Rocky III"))}");

            // Retorna 
            // 0 - Clube dos Cinco 
            // 1 - A Hora do Pesadelo 
            // 2 - Karatê Kid
            // 3 - Rocky III
            // 4 - Conan, o Bárbaro
            // 5 - Highlander
            // 6 - Sexta-feira 13th
            Console.WriteLine($"6. Listar todos os filmes com seu indice/posicao na lista. {string.Join(Environment.NewLine, locadora.listarTodosOsFilmesComSeuIndiceNaLista())}");

        }
    }
}

/*
 * // Essa é a lista de filmes disponibilizada pelo professor inicialmente.
string[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.


// 2. Resultado esperado em sua solução.
*/
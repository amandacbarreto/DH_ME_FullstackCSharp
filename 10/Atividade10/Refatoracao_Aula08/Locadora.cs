using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao_Aula08
{
    public class Locadora
    {
        string[] ListaDeFilmes = new string [0];

        // Apresenta todos os filmes da lista separados por ponto e vírgula.
        public string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {
            return string.Join("; ", this.ListaDeFilmes);
        }

        // Apresentar quantidade de filmes da lista.
        public int quantidadeTotalDeFilmes()
        {
            return this.ListaDeFilmes.Length;
        }

        // Buscar o nome do filme de acordo com seu índice.
        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return this.ListaDeFilmes[indiceDoFilme];
        }

        // Adiciona um novo filme a lista pelo seu nome.
        public string[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            this.ListaDeFilmes = this.ListaDeFilmes.Append(nomeDoFilme).ToArray();
            return this.ListaDeFilmes;
        }

        // Atualiza um filme a partir do seu índice na lista.
        public string[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string novoNome)
        {
            this.ListaDeFilmes[indiceDoFilme] = novoNome;
            return this.ListaDeFilmes;
        }

        // Listar todos os filmes com seu índice/posição na lista.
        public String[] listarTodosOsFilmesComSeuIndiceNaLista()
        {
            string[] listaComIndice = new string[this.ListaDeFilmes.Length];
            int count;
            for (count = 0; count < this.ListaDeFilmes.Length; count++)
            {
                listaComIndice[count] = $"{count} - {this.ListaDeFilmes[count]}";
            }
            return listaComIndice;
        }


    }
}

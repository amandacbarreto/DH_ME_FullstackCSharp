using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refatoracao_Aula06
{
    internal class Usuario
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public int AnoNascimento { get; set; }

        public int AnoAtual = DateTime.Now.Year;

        public Usuario(string nome, int anoNascimento)
        {
            Nome = nome;
            AnoNascimento = anoNascimento;
        }

        public Usuario() { }



        public int CalcularIdade()
        {
            Idade = AnoAtual - AnoNascimento;
            return Idade;
        }

    }
}

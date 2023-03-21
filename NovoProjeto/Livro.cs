using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{
    internal class Livro
    {
        private int Id { get; set; }
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private string Editora { get; set; }
        private int QuantidadeExemplares { get; set; }

        public Livro(int id, string nome, string autor, string editora)
        {
            Id = id;
            Nome = nome;
            Autor = autor;
            Editora = editora;
        }

        public void EmprestarLivro(int quantidadeEmprestada)
        {
            if (quantidadeEmprestada > 0 && quantidadeEmprestada <= QuantidadeExemplares)
            {
                QuantidadeExemplares -= quantidadeEmprestada;
                Console.WriteLine($"Livro emprestado com sucesso! Restam {QuantidadeExemplares} exemplares.");
            }
            else
            {
                Console.WriteLine("Não é possível emprestar essa quantidade de exemplares.");
            }
        }

        public void AlterarNomeLivro(string novoNome)
        {
            Nome = novoNome;
        }

        public void AlterarAutorLivro(string novoAutor)
        {
            Autor = novoAutor;
        }

        public string ObterNomeLivro()
        {
            return Nome;
        }

        public string ObterAutorLivro()
        {
            return Autor;
        }

        public int ObterIdLivro()
        {
            return Id;
        }
    }

}


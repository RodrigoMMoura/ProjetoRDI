using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarro
{
    internal class Biblioteca
    {
        private List<Livro> Livros { get; set; }

        public void AdicionarNovoLivro(Livro livro)
        {
            if (Livros == null)
                Livros = new List<Livro>();
            Livros.Add(livro);
        }

        public void ImprimirRelatorioLivros()
        {
            foreach (var livro in Livros)
            {
                Console.WriteLine($"Livro: {livro.ObterNomeLivro()} Autor: {livro.ObterAutorLivro()}");
            }
        }

        public Livro ConsultarLivroPorId(int id)
        {
            return
                Livros.Where(idLivro =>
                    idLivro.ObterIdLivro() == id).FirstOrDefault();
        }

    }
}


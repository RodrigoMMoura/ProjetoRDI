using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{
    public class Pessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Cpf { get; set; }
        string Telefone { get; set; }
        public object LivrosEmprestados { get; private set; }

        List<string> livrosEmprestados = new List<string>();
        


        public void AdicionarLivroLista(Livro livro)
        {
            LivrosEmprestados.Add(livro);
        }

        public object GetLivrosEmprestados()
        {
            return LivrosEmprestados;
        }

        public void RemoverLivroLista(int idLivro, object livrosEmprestados)
        {
            Livro livro = livrosEmprestados.Find(l => l.Id == idLivro);
            LivrosEmprestados.Remove(livro);
        }
        public void CadastrarPessoa()
{
         Console.WriteLine("Digite o Id da pessoa:");
         int id = int.Parse(Console.ReadLine());

    // Verifica se a pessoa já está cadastrada na lista de pessoas
    if (listaPessoas.Any(p => p.Id == id))
    {
        Console.WriteLine("Pessoa já cadastrada");
        return;
    }

    Console.WriteLine("Digite o nome da pessoa:");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o CPF da pessoa:");
    string cpf = Console.ReadLine();

    Console.WriteLine("Digite o telefone da pessoa:");
    string telefone = Console.ReadLine();

    // Cria um novo objeto Pessoa com as informações fornecidas e adiciona à lista de pessoas
    Pessoa novaPessoa = new Pessoa()
    {
        Id = id,
        Nome = nome,
        Cpf = cpf,
        Telefone = telefone
    };
    listaPessoas.Add(novaPessoa);

    Console.WriteLine("Pessoa cadastrada com sucesso!");

    // Zera a lista de livros emprestados da pessoa recém cadastrada
    novaPessoa.LivrosEmprestados.Clear();

    // Retorna ao menu principal
    MostrarMenu();
}
    }
}

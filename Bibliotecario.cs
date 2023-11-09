using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Bibliotecario
    {
        public string NomeB;
        public int Id;


        public void EmprestarLivro(Livro livro)
        {
            if (livro.EstadoEmprestimo == false)
            {
                livro.EstadoEmprestimo = true;
                Console.WriteLine("livro emprestado");
            }
            else
            {
                Console.WriteLine("este livro já foi emprestado");
            }
        }

        public void DevolverLivro(Livro livro)
        {
            if (livro.EstadoEmprestimo == true)
            {
                Console.WriteLine("livro devolvido");
                livro.EstadoEmprestimo = false;
            }
            else
            {
                Console.WriteLine("livro não emprestado || livro ja devolvido");
            }

        }
        public Livro CriarLivro(string nlivro, string alivro)
        {
                
            return new Livro { Titulo = nlivro, Autor = alivro };

        }

    }
}

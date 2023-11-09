using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //polimorfismo sobrescrita
            Boleto b = new Boleto();
            b.Pagacao(45);

            //polimorfismo sobrecarga
            Calculadora calc = new Calculadora();
            calc.Somar(12.0,19.0);
            calc.Somar(53, 5);
            calc.Subtrair(12.0, 19.0);
            calc.Subtrair(5, 5);
            calc.Dividir(3, 23.4);
            calc.Dividir(21, 32);
            calc.Multiplicar(25, 5);
            calc.Multiplicar(23.4, 5);
            

            //assosiacao
            Bibliotecario b1 = new Bibliotecario();
            Console.WriteLine("faça um livro (bibliotecario)");
            Console.WriteLine("nome do autor");
            string autor = Console.ReadLine();
            Console.WriteLine("nome do livro");
            string nomelivro = Console.ReadLine();
            Livro livro = b1.CriarLivro(autor, nomelivro);

            Console.WriteLine("Digite o seu nome (cliente) ");
            string nomecliente = Console.ReadLine();
            Cliente cliente = new Cliente(nomecliente);

            voltar:
            Console.WriteLine("digite 1 para pedir um livro emrpestado");
            Console.WriteLine("digite 2 para devolver o livro");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                cliente.EmprestarLivro(livro);
               
                goto voltar;
                
            }
            else
            {
                cliente.DevolverLivro(livro);
                
                goto voltar;
            }

        }
    }
}

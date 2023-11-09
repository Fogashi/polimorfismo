using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Calculadora
    {
        public void Somar(int n1, int n2)
        {
            int r = n1 + n2;
            Console.WriteLine(r);
        }
        public void Somar(double n1, double n2)
        {
            double r = n1 + n2;
            Console.WriteLine(r + " voce caiu na sobrecarga");
        }


        public void Subtrair(int n1, int n2)
        {
            int r = n1 - n2;
            Console.WriteLine(r);
        }


        public void Subtrair(double n1, double n2)
        {
            double r = n1 - n2;
            Console.WriteLine(r + " você caiu na sobrecarga");
        }

        public void Dividir(float n1, float n2)
        {
            float r = n1 % n2;
            Console.WriteLine(r);
        }

        public void Dividir(double n1, double n2)
        {
            double r = n1 % n2;
            Console.WriteLine(r + " você caiu na sobrecarga");
        }

        public void Multiplicar(double n1, double n2)
        {
            double r = n1 % n2;
            Console.WriteLine(r);
        }

        public void Multiplicar(float n1, float n2)
        {
            float r = n1 % n2;
            Console.WriteLine(r + " você caiu na sobrecarga");
        }
    }
}

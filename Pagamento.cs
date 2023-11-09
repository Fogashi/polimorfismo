using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Pagamento
    {
        public int ValorProduto = 15;

        public virtual int Pagacao(int valor)
        {
          Console.WriteLine("você chamou o metodo da superclasse");
          return  valor - this.ValorProduto;            
        }
    }
}

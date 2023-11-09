using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Boleto : Pagamento
    {

        public override int Pagacao(int valor)
        {
            int valorp = this.ValorProduto;
            int boleto = valor - this.ValorProduto;
            Console.WriteLine("Boleto da compra , Valor do produto: {0} " +
                "valor pago  {1} " +
                "troco {2} " ,valorp,valor,boleto);
            return boleto;

        }       

    }
}

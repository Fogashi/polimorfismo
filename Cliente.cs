using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Cliente : Bibliotecario
    {
        public string nome;

        public Cliente(string nome)
        {
            this.nome = nome;
        }


    }
}

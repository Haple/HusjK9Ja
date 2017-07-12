using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caixa1
{
    class conta
    {

        public int conta_corrente;
        public double saldo;


        public void Sacar(double valor)
        {
            saldo -= valor;

        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }
    }

}


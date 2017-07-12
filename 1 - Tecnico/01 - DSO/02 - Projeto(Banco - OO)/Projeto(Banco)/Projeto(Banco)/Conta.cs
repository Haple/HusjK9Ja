using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco_
{
    class Conta
    {

        //Atributos/ variáveis da classe
        public int conta_corrente;
        public double saldo;
        

        // Função para sacar dinheiro da conta corrente
        public void sacar(double valor)
        {
            saldo -= valor;
        }


        //Função para depositar dinheiro na conta corrente
        public void depositar(double valor)
        {
            saldo += valor;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Heranca_
{
    //Classe Pai
    class Pessoa
    {
        private string nome;

        //Construtor simples
        public Pessoa()
        {

        }

        //Método GET/SET para OBTER/MUDAR a variável nome
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}

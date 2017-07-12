using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Heranca_
{
    class PessoaFisica: Pessoa
    {
        private string cpf;

        //Construtor simples
        public PessoaFisica()
        {

        }

        /*Construtor da classe pessoa física
         *Possui 2 parâmetros 
          A variável 'nome' veio como HERANÇA da classe Pessoa*/
        public PessoaFisica(string parametro_cpf, string parametro_nome)
        {
            //Atributo da classe Pessoa Física
            cpf = parametro_cpf;
            //Atributo herdado da classe Pessoa
            Nome = parametro_nome;
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

    }
}

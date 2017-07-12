using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Heranca_
{
    class PessoaJuridica: Pessoa
    {

        private string cnpj;

        //Construtor simples
        public PessoaJuridica()
        {

        }

        /*Construtor da classe pessoa jurídica
         *Possui 2 parâmetros 
          A variável 'nome' veio como HERANÇA da classe Pessoa*/
        public PessoaJuridica(string parametro_cpf, string parametro_nome)
        {
            //Atributo da classe Pessoa Física
            cnpj = parametro_cpf;
            //Atributo herdado da classe Pessoa
            Nome = parametro_nome;
        }

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

    }
}

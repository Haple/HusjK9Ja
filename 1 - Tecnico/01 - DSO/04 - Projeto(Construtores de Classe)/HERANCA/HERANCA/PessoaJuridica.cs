using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERANCA
{
    class PessoaJuridica: Pessoa
    {
        private string cnpj;

        public PessoaJuridica()
        {

        }

        // CONSTRUTOR DA CLASSE PESSOA JURIDICA
        // CONSTRUTOR POSSUI 2 PARAMETROS DE ENTRADA
        // NOTE QUE O NOME VEIO DA CLASSE PAI (PESSOA)
        public PessoaJuridica(string parametro_cnpj, string parametro_nome)
        {
            // CNPJ É UM ATRIBUTO DA CLASSE PESSOA JURIDICA
            cnpj = parametro_cnpj;

            // NOME É UM ATRIBUTO DA CLASSE PESSOA, OU SEJA, HERANCA            
            Nome = parametro_nome;
        }

        // METODO GET/SET PARA OBTER/MUDAR O CNPJ DA PESSOA JURIDICA
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}


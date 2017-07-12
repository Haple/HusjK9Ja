using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERANCA
{
    class PessoaFisica: Pessoa
    {
        private string cpf;

        public PessoaFisica()
        {

        }
        // CONSTRUTOR DA CLASSE PESSOA FISICA
        // CONSTRUTOR POSSUI 2 PARAMETROS DE ENTRADA
        // NOTE QUE O NOME VEIO DA CLASSE PAI (PESSOA)
        public PessoaFisica(string parametro_cpf, string parametro_nome)
        {
            // CPF É UM ATRIBUTO DA CLASSE PESSOA FISICA
            cpf = parametro_cpf;

            // NOME É UM ATRIBUTO DA CLASSE PESSOA, OU SEJA, HERANCA            
            Nome = parametro_nome;
        }

        // METODO GET/SET PARA OBTER/MUDAR O CPF DA PESSOA FISICA
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        
    }
}

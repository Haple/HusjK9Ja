using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERANCA
{

    // CLASSE PAI
    class Pessoa
    {

        // ATRIBUTO NOME É COMUM ENTRE AS CLASSES PESSOA FISICA E JURIDICA
        private string nome;

        public Pessoa()
        {

        }       

        // METODO GET/SET SERVE PARA MUDAR/OBTER O NOME DE UMA PESSOA
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}

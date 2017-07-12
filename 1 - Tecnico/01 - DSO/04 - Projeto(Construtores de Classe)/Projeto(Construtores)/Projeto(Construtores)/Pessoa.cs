using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Construtores_
{
    //CLASSE: Pessoa
    public class Pessoa
    {
        public string corCabelo;
        public  double altura;

        public Pessoa()
        {

        }

        public Pessoa(string cabelo, double alt)
        {
            corCabelo = cabelo;
            altura = alt;
        }


    }

}

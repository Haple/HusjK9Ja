using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Heranca___Veiculo_
{
    class Carro: Veiculo
    {

        private string x;

        public Carro()
        {

        }

        public Carro(string xx, string motor)
        {
            x = xx;

            Motor = motor;
        }


        public string X
        {
            get { return x; }
            set { x = value; }
        }

            
    }
}

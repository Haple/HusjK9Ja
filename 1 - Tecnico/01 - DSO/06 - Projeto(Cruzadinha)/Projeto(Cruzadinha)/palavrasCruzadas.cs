using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cruzadinha_
{
    class palavrasCruzadas
    {
        private string[] palavras = 
            {
            "CADERNO", "MOCHILA", "LÁPIS",
            "TESOURA", "RÉGUA", "ESTOJO",
            "LIVRO", "BORRACHA", "COLA", "CANETA"
            };

        //verificar se o usuário acertou a palavra
        public bool estaCerto(string palavraAtual, int numeroPalavra) {
            if (palavraAtual == palavras[numeroPalavra]) return true;
            else return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cruzadinha_
{
    public partial class Form1 : Form
    {
        //palavras cruzadas
        palavrasCruzadas palavrasCruzadas = new palavrasCruzadas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            string palavra1Usuario;
        }

        private void verificar(TextBox sender, KeyEventArgs e)
        {
            string palavra1Usuario = sender.Tag.ToString();
        }
    }
}

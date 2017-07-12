using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Construtores_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pessoa p = new Pessoa(txt_cabelo.Text, Convert.ToDouble(txt_altura.Text));
            txt_resultado.AppendText("Cabelo: " + p.corCabelo + "; Altura: " + p.altura.ToString() + ".\n");
        }
    }
}

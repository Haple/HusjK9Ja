using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERANCA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // BOTAO INCLUIR PESSOA FISICA
        private void button1_Click(object sender, EventArgs e)
        {
            PessoaFisica pf = new PessoaFisica(txt_cpf.Text, txt_nome_fisico.Text);

            txt_areadetexto.AppendText("NOME = " + pf.Nome);
            txt_areadetexto.AppendText("      ");
            txt_areadetexto.AppendText("CPF = " + pf.Cpf);
            txt_areadetexto.AppendText("\n");
            txt_areadetexto.AppendText("---------------------------------------------------------------");
            txt_areadetexto.AppendText("---------------------------------------------------------------");
            txt_areadetexto.AppendText("\n");

        }
        // BOTAO INCLUIR PESSOA JURIDICA
        private void button2_Click(object sender, EventArgs e)
        {
            PessoaJuridica pj = new PessoaJuridica(txt_cnpj.Text, txt_nome_juridico.Text);

            txt_areadetexto.AppendText("NOME = " + pj.Nome);
            txt_areadetexto.AppendText("      ");
            txt_areadetexto.AppendText("CNPJ = " + pj.Cnpj);
            txt_areadetexto.AppendText("\n");
            txt_areadetexto.AppendText("---------------------------------------------------------------");
            txt_areadetexto.AppendText("---------------------------------------------------------------");
            txt_areadetexto.AppendText("\n");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Banco_
{
    public partial class Form1 : Form
    {
        Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            if (txt_operacao.SelectedItem.ToString() == "Depositar")
            {
                c.depositar(Double.Parse(txt_valor.Text));
            }

            if (txt_operacao.SelectedItem.ToString() == "Sacar")
            {
                c.sacar(Double.Parse(txt_valor.Text));
            }

            //Mostrar o saldo atual
            txt_extrato.AppendText("\n");
            txt_extrato.AppendText("SALDO ATUAL: ");
            txt_extrato.AppendText(c.saldo.ToString());
            txt_extrato.AppendText("\n******************************************************************");

        }


        //Evento LOAD, carregamento do formulário
        private void Form1_Load(object sender, EventArgs e)
        {
            //Criando uma nova conta
            c = new Conta();

            //Iniciar saldo da conta
            c.saldo = 1000;

            //Mostrar o saldo atual
            txt_extrato.AppendText("\n");
            txt_extrato.AppendText("SALDO ATUAL: ");
            txt_extrato.AppendText(c.saldo.ToString());
            txt_extrato.AppendText("\n******************************************************************");
        }

    }
}

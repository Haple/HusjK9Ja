using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa1
{
    public partial class Form1 : Form
    {
        conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_operacao.SelectedItem.ToString() == "Depositar")
            {
                c.Depositar(Double.Parse(valor.Text));
            }
            {
                if (cb_operacao.SelectedItem.ToString() == "Sacar") ;

            }
            {
                c.Sacar(Double.Parse(valor.Text));

            }
            estrato.AppendText("/n");
            estrato.AppendText("SALDO ATUAL");
            estrato.AppendText(c.saldo.ToString());
            estrato.AppendText("==========================================");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new conta();

            c.saldo = 1000;


            estrato.AppendText("SALDO ATUAL");
            estrato.AppendText(c.saldo.ToString());
            estrato.AppendText("==========================================");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

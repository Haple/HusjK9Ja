using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Seguradora_
{
    public partial class cadastrar_apolice : Form
    {
        public cadastrar_apolice()
        {
            InitializeComponent();
        }

        private void cadastrarImóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro_cliente cliente = new cadastro_cliente();
            cliente.Show();
            this.Hide();
        }
    }
}

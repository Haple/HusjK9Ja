using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastrarSeriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_seriado cadastrar_seriado = new Cad_seriado();
            
            cadastrar_seriado.Show();
            this.Hide();
        }

        private void cadastrarTemporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_temporada cadastrar_temporada = new Cad_temporada();
            cadastrar_temporada.Show();
            this.Hide();
        }

        private void consultarSeriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_Seriado con_seriado = new Con_Seriado();
            con_seriado.Show();
            this.Hide();
        }

        private void consultarTemporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_episodio con_episodio = new Con_episodio();
            con_episodio.Show();
            this.Hide();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

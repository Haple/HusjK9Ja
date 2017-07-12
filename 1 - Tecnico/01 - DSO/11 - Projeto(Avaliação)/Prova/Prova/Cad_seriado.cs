using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prova
{
    public partial class Cad_seriado : Form
    {
        public Cad_seriado()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //1
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=prova;uid=root;pwd=;");
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "INSERT INTO seriados (seriado, temporada, tema) VALUES (?seriado, ?temporada, ?tema)";
            //5
            comando.Parameters.Add("?seriado", txt_seriado.Text);
            comando.Parameters.Add("?temporada", txt_temporada.Text);
            comando.Parameters.Add("?tema", txt_tema.Text);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void cadastrarTemporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_temporada cadastrar_temporada = new Cad_temporada();
            cadastrar_temporada.Show();
            this.Hide();
        }

        private void consultarSeriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_Seriado consultar_seriado = new Con_Seriado();
            consultar_seriado.Show();
            this.Hide();
        }

        private void consultarTemporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_Seriado consultar_seriado = new Con_Seriado();
            consultar_seriado.Show();
            this.Hide();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

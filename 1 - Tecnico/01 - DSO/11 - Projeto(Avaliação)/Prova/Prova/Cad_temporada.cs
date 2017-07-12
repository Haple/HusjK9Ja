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
    public partial class Cad_temporada : Form
    {
        public Cad_temporada()
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
            comando.CommandText = "INSERT INTO temporadas (seriado, temporada , episodio , resumo) VALUES (?seriado, ?temporada , ?episodio , ?resumo)";
            //5
            comando.Parameters.Add("?seriado", txt_seriado.Text);
            comando.Parameters.Add("?temporada", txt_temporada.Text);
            comando.Parameters.Add("?episodio", txt_episodio.Text);
            comando.Parameters.Add("?resumo", txt_resumo.Text);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void cadastrarSeriadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cad_seriado con_ser = new Cad_seriado();
            con_ser.Show();
            this.Hide();
        }

        private void consultarSeriadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Con_Seriado con_seriado = new Con_Seriado();
            con_seriado.Show();
            this.Hide();
        }

        private void consultarTemporadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Con_episodio con_episodio = new Con_episodio();
            con_episodio.Show();
            this.Hide();
        }
    }
}

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
    public partial class Con_episodio : Form
    {
        public Con_episodio()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //1. Criar conexao
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=prova;uid=root;pwd=;");
            //2. Abrir conexao
            conexao.Open();
            //3. Criar o comando
            MySqlCommand cmd = conexao.CreateCommand();
            //4. Adicionar comando
            cmd.CommandText = "SELECT * FROM temporadas WHERE episodio = ?episodio";
            //5. ADICIONAR PARAMETROS
            cmd.Parameters.Add("?episodio", txt_episodio.Text);
            //6. Obtem os dados da consulta
            MySqlDataAdapter resultado_consulta = new MySqlDataAdapter(cmd);
            //7. Ligar a tabela e a grade
            DataSet DS = new DataSet();
            //8. Preencher a grade com os dados da tabela
            resultado_consulta.Fill(DS);
            //9.
            dataGridView1.DataSource = DS.Tables[0];
            //10.
            conexao.Close();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarSeriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_seriado cadastrar_seriado = new Cad_seriado();
            cadastrar_seriado.Show();
            this.Close();
        }

        private void cadastrarTemporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_temporada cadastrar_temporada = new Cad_temporada();
            cadastrar_temporada.Show();
            this.Close();
        }

        private void consultarSeriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_Seriado con_seriado = new Con_Seriado();
            con_seriado.Show();
            this.Close();
        }

        private void consultarTemporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Con_episodio con_episodio = new Con_episodio();
            con_episodio.Show();
            this.Close();
        }

        private void cadastrarSeriadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cad_temporada cadastrar_temporada = new Cad_temporada();
            cadastrar_temporada.Show();
            this.Close();
        }

        private void consultarTemporadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Con_Seriado con_seriado = new Con_Seriado();
            con_seriado.Show();
            this.Hide();
        }

        private void cadastrarTemporadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cad_seriado cadastrar_temporada = new Cad_seriado();
            cadastrar_temporada.Show();
            this.Hide();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }
    }
}

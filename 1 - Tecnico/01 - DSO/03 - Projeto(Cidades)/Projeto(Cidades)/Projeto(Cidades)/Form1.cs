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

namespace Projeto_Cidades_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            //1. Criar conexao
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=projeto_cidade;uid=root;pwd=;");
            //2. Abrir conexao
            conexao.Open();
            //3. Criar o comando
            MySqlCommand cmd = conexao.CreateCommand();
            //4. Adicionar comando
            cmd.CommandText = "SELECT * FROM POSTOS WHERE CIDADE = ?CIDADE";
            //5. ADICIONAR PARAMETROS
            cmd.Parameters.Add("?CIDADE", txt_cidade.Text);
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
    }
}

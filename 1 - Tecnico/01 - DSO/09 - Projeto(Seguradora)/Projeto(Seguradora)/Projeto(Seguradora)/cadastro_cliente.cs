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

namespace Projeto_Seguradora_
{
    public partial class cadastro_cliente : Form
    {
        public cadastro_cliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //1
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=seguradora;uid=root;pwd=;");
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "INSERT INTO CLIENTES (CPF, NOME, EMAIL, CEP, ESTADO, CIDADE, TELEFONE) VALUES (?cpf, ?nome, ?email, ?cep, ?estado, ?cidade, ?telefone)";
            //5
            comando.Parameters.Add("?cpf", txt_cpf.Text);
            comando.Parameters.Add("?nome", txt_nome.Text);
            comando.Parameters.Add("?email", txt_email.Text);
            comando.Parameters.Add("?cep", txt_cep.Text);
            comando.Parameters.Add("?estado", cb_estado.SelectedItem.ToString());
            comando.Parameters.Add("?cidade", txt_cidade.Text);
            comando.Parameters.Add("?telefone", txt_telefone.Text);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //1
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=seguradora;uid=root;pwd=;");
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "SELECT * FROM CLIENTES WHERE CPF = ?";
            //5
            comando.Parameters.Add("?", txt_cpf_pesquisa.Text);
            //6
            MySqlDataReader dados_consulta = comando.ExecuteReader();
            //7
            while (dados_consulta.Read())
            {
                //8
                txt_nome.Text = dados_consulta.GetString("NOME");
                txt_cpf.Text = dados_consulta.GetString("CPF");
                txt_email.Text = dados_consulta.GetString("EMAIL");
                txt_cep.Text = dados_consulta.GetString("CEP");
                txt_cidade.Text = dados_consulta.GetString("CIDADE");
                cb_estado.Text = dados_consulta.GetString("ESTADO");
                txt_telefone.Text = dados_consulta.GetString("TELEFONE");
            }
            //9
            conexao.Close();
        }

        private void cadastrarImóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar_apolice apolice = new cadastrar_apolice();
            apolice.Show();
            this.Hide();
        }
    }
}

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

namespace Projetos_Vendas_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            //1
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=shapeshop;uid=root;pwd=;");
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "INSERT INTO VENDA (NOME, CPF, SHAPE, QUANTIDADE) VALUES (?nome, ?cpf, ?shape, ?quantidade)";
            //5
            comando.Parameters.Add("?nome", txt_nome.Text);
            comando.Parameters.Add("?cpf", txt_cpf.Text);
            comando.Parameters.Add("?shape", cb_shape.SelectedItem.ToString());
            comando.Parameters.Add("?quantidade", numUD_quantidade.Value.ToString());
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            MessageBox.Show("Cadastrado com sucesso!");

        }
    }
}

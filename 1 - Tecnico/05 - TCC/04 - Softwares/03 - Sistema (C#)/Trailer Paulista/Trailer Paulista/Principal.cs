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
using System.Net;

namespace Trailer_Paulista
{
    public partial class Principal : Form
    {
        //VARIÁVEIS GLOBAIS
        int numPedido = 0;
        string bancoDeDados = "trailer_paulista";
        string servidor = "localhost";
        string user = "root";
        string pass = "";
        MySqlConnection conexao;


        public Principal()
        {
            InitializeComponent();
            //Criar conexão
            conexao = new MySqlConnection("server=" + servidor + ";database=" + bancoDeDados + ";uid=" + user + ";pwd=" + pass + ";");
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            txt_pesquisa_TextChanged(null, null);
            txtPesquisaProduto_TextChanged(null, null);
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_nomeLanche_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        //CADASTRAR LANCHES
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeLanche.Text;
            string preco = txtPrecoLanche.Text;
            string ingredientes = txtIngredientesLanche.Text;

            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "INSERT INTO lanches ( nome , preco , ingredientes) VALUES (?nome, ?preco , ?ingredientes );";
            //5
            comando.Parameters.AddWithValue("?nome", nome);
            comando.Parameters.AddWithValue("?preco", preco);
            comando.Parameters.AddWithValue("?ingredientes", ingredientes);

            //comando.Parameters.Add("?nome", nome);
            //comando.Parameters.Add("?preco", preco);
            //comando.Parameters.Add("?ingredientes", ingredientes);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            txt_pesquisa_TextChanged(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //SELECIONA LACHES
        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            //1. Criar conexao
            //MySqlConnection conexao = new MySqlConnection("server=" + servidor + ";database=" + bancoDeDados + ";uid=" + user + ";pwd=" + pass + ";");
            //2. Abrir conexao
            conexao.Open();
            //3. Criar o comando
            MySqlCommand cmd = conexao.CreateCommand();
            //4. Adicionar comando
            cmd.CommandText = "SELECT cod as Codigo, nome as Lanche, preco as Preco , ingredientes as Ingredientes FROM lanches WHERE nome like ?pesquisa or cod like ?pesquisa";
            //5. ADICIONAR PARAMETROS
            cmd.Parameters.AddWithValue("?pesquisa", "%" + txtPesquisaLanche.Text.TrimStart() +"%");
            //6. Obtem os dados da consulta
            MySqlDataAdapter resultado_consulta = new MySqlDataAdapter(cmd);
            //7. Ligar a tabela e a grade
            DataSet DS = new DataSet();
            //8. Preencher a grade com os dados da tabela
            resultado_consulta.Fill(DS);
            //9.
            gridDadosLanches.DataSource = DS.Tables[0];
            //10.
            conexao.Close();
        }

        //EXCLUIR LANCHES
        private void btnExcluirLanche_Click(object sender, EventArgs e)
        {
            string cod = txtCodigoLanche.Text;

            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "DELETE FROM lanches WHERE cod = ?cod;";
            //5
            comando.Parameters.AddWithValue("?cod", cod);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            txtPesquisaProduto_TextChanged(null, null);

            txtCodigoLanche.Text = "";
            txtNomeLanche.Text = "";
            txtPrecoLanche.Text = "";
            txtIngredientesLanche.Text = "";

            txt_pesquisa_TextChanged(null, null);


        }

        //ALTERAR LANCHE
        private void btnAlterarLanche_Click(object sender, EventArgs e)
        {

            string cod = txtCodigoLanche.Text;
            string nome = txtNomeLanche.Text;
            string preco = txtPrecoLanche.Text;
            string ingredientes = txtIngredientesLanche.Text;

            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "UPDATE lanches SET nome = ?nome, preco = ?preco, ingredientes = ?ingredientes WHERE cod = ?cod;";
            //5
            comando.Parameters.AddWithValue("?cod", cod);
            comando.Parameters.AddWithValue("?nome", nome);
            comando.Parameters.AddWithValue("?preco", preco);
            comando.Parameters.AddWithValue("?ingredientes", ingredientes);

            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            txt_pesquisa_TextChanged(null, null);

        }

        //CARREGAR DADOS DOS LANCHES PARA AS CAIXAS DE TEXTO
        private void gridDadosLanches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoLanche.Text = gridDadosLanches[0, gridDadosLanches.CurrentRow.Index].Value.ToString();
            txtNomeLanche.Text = gridDadosLanches[1, gridDadosLanches.CurrentRow.Index].Value.ToString();
            txtPrecoLanche.Text = gridDadosLanches[2, gridDadosLanches.CurrentRow.Index].Value.ToString();
            txtIngredientesLanche.Text = gridDadosLanches[3, gridDadosLanches.CurrentRow.Index].Value.ToString();
        }





        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adicionarPedido_Click(object sender, EventArgs e)
        {
            listaPedidos.Items.Add("Pedido " + numPedido++);
        }








        //CADASTRAR PRODUTO
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text;
            string categoria = txtCategoriaProduto.Text;
            string marca = txtMarcaProduto.Text;
            string preco = txtPrecoProduto.Text;
            string fornecedor = txtFornecedorProduto.Text;

            //1
            //MySqlConnection conexao = new MySqlConnection("server=" + servidor + ";database=" + bancoDeDados + ";uid=" + user + ";pwd=" + pass + ";");
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "INSERT INTO produtos ( nome , preco , marca, categoria, fornecedor) VALUES (?nome, ?preco , ?marca, ?categoria, ?fornecedor );";
            //5
            comando.Parameters.AddWithValue("?nome", nome);
            comando.Parameters.AddWithValue("?preco", preco);
            comando.Parameters.AddWithValue("?marca", marca);
            comando.Parameters.AddWithValue("?categoria", categoria);
            comando.Parameters.AddWithValue("?fornecedor", fornecedor);

            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();
            txtPesquisaProduto_TextChanged(null, null);
        }

        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        //SELECIONAR PRODUTOS
        private void txtPesquisaProduto_TextChanged(object sender, EventArgs e)
        {
            
            //2. Abrir conexao
            conexao.Open();
            //3. Criar o comando
            MySqlCommand cmd = conexao.CreateCommand();
            //4. Adicionar comando
            cmd.CommandText = "SELECT cod as Codigo, nome as Produto, preco as Preco, marca as Marca, categoria as Categoria, fornecedor as Fornecedor FROM produtos WHERE nome like ?pesquisa or cod like ?pesquisa";
            //5. ADICIONAR PARAMETROS
            cmd.Parameters.AddWithValue("?pesquisa", "%" + txtPesquisaProduto.Text.TrimStart() + "%");
            //6. Obtem os dados da consulta
            MySqlDataAdapter resultado_consulta = new MySqlDataAdapter(cmd);
            //7. Ligar a tabela e a grade
            DataSet DS = new DataSet();
            //8. Preencher a grade com os dados da tabela
            resultado_consulta.Fill(DS);
            //9.
            gridDadosProdutos.DataSource = DS.Tables[0];
            
            //10.
            conexao.Close();

        }

        //CARREGAR DADOS DOS PRODUTOS PARA AS CAIXAS DE TEXTO
        private void gridDadosProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoProduto.Text = gridDadosProdutos[0, gridDadosProdutos.CurrentRow.Index].Value.ToString();
            txtNomeProduto.Text = gridDadosProdutos[1, gridDadosProdutos.CurrentRow.Index].Value.ToString();
            txtPrecoProduto.Text = gridDadosProdutos[2, gridDadosProdutos.CurrentRow.Index].Value.ToString();
            txtMarcaProduto.Text = gridDadosProdutos[3, gridDadosProdutos.CurrentRow.Index].Value.ToString();
            txtCategoriaProduto.Text = gridDadosProdutos[4, gridDadosProdutos.CurrentRow.Index].Value.ToString();
            txtFornecedorProduto.Text = gridDadosProdutos[5, gridDadosProdutos.CurrentRow.Index].Value.ToString();
        }

        private void gridDadosProdutos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void gridDadosProdutos_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        //ALTERAR PRODUTO
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string cod = txtCodigoProduto.Text;
            string nome = txtNomeProduto.Text;
            string categoria = txtCategoriaProduto.Text;
            string marca = txtMarcaProduto.Text;
            string preco = txtPrecoProduto.Text;
            string fornecedor = txtFornecedorProduto.Text;

            //1
            //MySqlConnection conexao = new MySqlConnection("server=" + servidor + ";database=" + bancoDeDados + ";uid=" + user + ";pwd=" + pass + ";");
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "UPDATE produtos SET nome = ?nome, preco = ?preco , marca = ?marca, categoria = ?categoria, fornecedor = ?fornecedor WHERE cod = ?cod;";
            //5
            comando.Parameters.AddWithValue("?cod", cod);
            comando.Parameters.AddWithValue("?nome", nome);
            comando.Parameters.AddWithValue("?preco", preco);
            comando.Parameters.AddWithValue("?marca", marca);
            comando.Parameters.AddWithValue("?categoria", categoria);
            comando.Parameters.AddWithValue("?fornecedor", fornecedor);

            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            txtPesquisaProduto_TextChanged(null, null);
        }


        //EXCLUIR PRODUTO
        private void btnExcluir_Click(object sender, EventArgs e)
        {

            string cod = txtCodigoProduto.Text;

            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "DELETE FROM produtos WHERE cod = ?cod;";
            //5
            comando.Parameters.AddWithValue("?cod", cod);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            txtPesquisaProduto_TextChanged(null, null);

            txtCodigoProduto.Text = "" ;
            txtNomeProduto.Text = "" ;
            txtPrecoProduto.Text = "" ;
            txtMarcaProduto.Text = "" ;
            txtCategoriaProduto.Text = "" ;
            txtFornecedorProduto.Text = "" ;

            txt_pesquisa_TextChanged(null, null);

        }









        //CADASTRAR FORNECEDOR
        private void btnCadastroFornecedor_Click(object sender, EventArgs e)
        {


            string fornecedor = txtFornecedor.Text;
            string telefone = txtTelefoneFornecedor.Text;
            string cpf = txtCpfFornecedor.Text;
            string cnpj = txtCnpjFornecedor.Text;
  
            
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "INSERT INTO fornecedores ( fornecedor , telefone , cpf, cnpj) VALUES (?fornecedor, ?telefone , ?cpf, ?cnpj);";
            //5
            comando.Parameters.AddWithValue("?fornecedor", fornecedor);
            comando.Parameters.AddWithValue("?telefone", telefone);
            comando.Parameters.AddWithValue("?cpf", cpf);
            comando.Parameters.AddWithValue("?cnpj", cnpj);

            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();
            txtPesquisaFornecedores_TextChanged(null, null);
        }

        //SELECIONAR FORNECEDORES
        private void txtPesquisaFornecedores_TextChanged(object sender, EventArgs e)
        {

            //2. Abrir conexao
            conexao.Open();
            //3. Criar o comando
            MySqlCommand cmd = conexao.CreateCommand();
            //4. Adicionar comando
            cmd.CommandText = "SELECT cod as Codigo, fornecedor as Fornecedor, telefone as Telefone, cpf as CPF, cnpj as CNPJ FROM fornecedores WHERE fornecedor like ?pesquisa or cod like ?pesquisa";
            //5. ADICIONAR PARAMETROS
            cmd.Parameters.AddWithValue("?pesquisa", "%" + txtPesquisaFornecedor.Text.TrimStart() + "%");
            //6. Obtem os dados da consulta
            MySqlDataAdapter resultado_consulta = new MySqlDataAdapter(cmd);
            //7. Ligar a tabela e a grade
            DataSet DS = new DataSet();
            //8. Preencher a grade com os dados da tabela
            resultado_consulta.Fill(DS);
            //9.
            gridDadosFornecedor.DataSource = DS.Tables[0];

            //10.
            conexao.Close();

        }
        //CARREGAR DADOS DOS FORNECEDORES PARA AS CAIXAS DE TEXTO
        private void gridDadosFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoFornecedor.Text = gridDadosFornecedor[0, gridDadosFornecedor.CurrentRow.Index].Value.ToString();
            txtFornecedor.Text = gridDadosFornecedor[1, gridDadosFornecedor.CurrentRow.Index].Value.ToString();
            txtTelefoneFornecedor.Text = gridDadosFornecedor[2, gridDadosFornecedor.CurrentRow.Index].Value.ToString();
            txtCpfFornecedor.Text = gridDadosFornecedor[3, gridDadosFornecedor.CurrentRow.Index].Value.ToString();
            txtCnpjFornecedor.Text = gridDadosFornecedor[4, gridDadosFornecedor.CurrentRow.Index].Value.ToString();
            
        }

        //ALTERAR FORNECEDOR
        private void btnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            string cod = txtCodigoFornecedor.Text;
            string fornecedor = txtFornecedor.Text;
            string telefone = txtTelefoneFornecedor.Text;
            string cpf = txtCpfFornecedor.Text;
            string cnpj = txtCnpjFornecedor.Text;

            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "UPDATE fornecedores SET fornecedor = ?fornecedor, telefone = ?telefone , cpf = ?cpf, cnpj = ?cnpj WHERE cod = ?cod;";
            //5
            comando.Parameters.AddWithValue("?fornecedor", fornecedor);
            comando.Parameters.AddWithValue("?telefone", telefone);
            comando.Parameters.AddWithValue("?cpf", cpf);
            comando.Parameters.AddWithValue("?cnpj", cnpj);
            comando.Parameters.AddWithValue("?cod", cod);

            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            txtPesquisaFornecedores_TextChanged(null, null);
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            string cod = txtCodigoFornecedor.Text;

            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "DELETE FROM fornecedores WHERE cod = ?cod;";
            //5
            comando.Parameters.AddWithValue("?cod", cod);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();


            txtCodigoFornecedor.Text = "";
            txtFornecedor.Text = "";
            txtTelefoneFornecedor.Text = "";
            txtCpfFornecedor.Text = "";
            txtCnpjFornecedor.Text = "";

            txtPesquisaFornecedores_TextChanged(null, null);
        }
    }
}

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

namespace Projeto_Login_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=signin;uid=root;pwd=;");
            //2
            conexao.Open();
            //3
            MySqlCommand comando = conexao.CreateCommand();
            //4
            comando.CommandText = "INSERT INTO USER (USERNAME, PASS, PROFILE) VALUES (?username, ?pass, ?profile)";
            //5
            comando.Parameters.Add("?username", txt_username.Text);
            comando.Parameters.Add("?pass", txt_pass.Text);
            comando.Parameters.Add("?profile", txt_profile.Text);
            //6
            comando.ExecuteNonQuery();
            //7
            conexao.Close();

            MessageBox.Show("SUCCESS");
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1._2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)


        {
            // Conexão com o banco de dados
            MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=;database=casaracao");
            conexao.Open();

            // Preparar o comando
            using (MySqlCommand cmd = conexao.CreateCommand())
            {

                string senha = Funcoes.Criptografar("123");


                cmd.CommandText = @$"INSERT INTO Cliente (Email , Senha) VALUES ('laura','{senha}')";

                senha = Funcoes.Criptografar("123");


            }


        }
    } 
}

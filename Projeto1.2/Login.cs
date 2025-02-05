using MySql.Data.MySqlClient;
using Projeto1._2.Properties;
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
            using (MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=;database=casaracao"))
            {
                conexao.Open();

                using (MySqlCommand cmd = conexao.CreateCommand())
                {
                    
                    

                    // Corrigindo a Query (agora filtra por Email e Senha)
                    cmd.CommandText = "SELECT * FROM cliente WHERE Email = @Email AND Senha = @Senha";
                    cmd.Parameters.AddWithValue("@Email", txtlogin.Text);
                    cmd.Parameters.AddWithValue("@Senha", TxtSenha.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())  //  Se encontrou um registro
                        {
                            MessageBox.Show("Login realizado com sucesso!");

                            // Criando instância antes de exibir a tela
                            MenuClientes menuClientes = new MenuClientes();
                            menuClientes.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("E-mail ou senha incorretos!");
                        }
                    }
                }
            }

        }






        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btversenha_MouseDown(object sender, MouseEventArgs e)
        {
            TxtSenha.UseSystemPasswordChar = false;
            btversenha.Image = Resources.visível;
        }

        private void btversenha_MouseUp(object sender, MouseEventArgs e)
        {
            TxtSenha.UseSystemPasswordChar = true;
            btversenha.Image = Resources.invisível;
        }

        private void btversenha_Click(object sender, EventArgs e)
        {

        }

        private void hand(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

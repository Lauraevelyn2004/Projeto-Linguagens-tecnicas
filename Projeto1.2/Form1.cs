using System;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Data;
using System.Security.Cryptography;

namespace Projeto1._2
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        string server = @"server=localhost;user id=root;password=;database=casaracao";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Funcoes.BuscaSql("SELECT * FROM Cliente");
            if (txtcod.Text == "")
            {
                return;
            }
            else
            {

                btncadastro.Text = "     Alterar";
            }


            //alterar
            DataTable dt = new DataTable();
            dt = Funcoes.BuscaSql("SELECT * FROM Cliente WHERE Cliente_ID = " + txtcod.Text);

            txtnome.Text = dt.Rows[0]["Nome"].ToString();
            txtemail.Text = dt.Rows[0]["Email"].ToString();
            txttel.Text = dt.Rows[0]["Telefone"].ToString();
            txtend.Text = dt.Rows[0]["Endereco"].ToString();
            txtsenha.Text = dt.Rows[0]["Senha"].ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(txtend);
        }


        private void FrmCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) // Se os campos **não** são válidos
            {
                return; // Para a execução
            }
            
            SalvarCliente(); // Chama o método para salvar o cliente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            {
                txtcod.Text = "";
                txtnome.Text = "";
                txtemail.Text = "";
                txttel.Text = "";
                txtend.Text = "";
                txtsenha.Text = "";

                btncadastro.Text = " Cadastrar";
            }

            return;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Close();

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(txtnome);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Funcoes.PriMaiuscula(txtend);
        }


        //------------------------------------------------------------------------------------------------------------------
        //   Funções

        //Salvar Cliente
        private void SalvarCliente()
        {
            try
            {
                // Conexão com o banco de dados
                MySqlConnection conexao = new MySqlConnection(server);
                conexao.Open();

                // Preparar o comando
                using (MySqlCommand cmd = conexao.CreateCommand())
                {


                    if (txtcod.Text == "")//salva
                    {
                        cmd.CommandText = "INSERT INTO Cliente (Nome, Email, Telefone, Endereco, Senha) VALUES (@nome, @email, @telefone, @endereco, @senha)";

                    }//fim salva
                    else//altera
                    {
                        cmd.CommandText = "UPDATE Cliente SET Nome = @nome, Email = @email, Telefone = @telefone, Endereco = @endereco, Senha = @senha WHERE Cliente_ID = @cod";
                        cmd.Parameters.AddWithValue("@cod", txtcod.Text);

                    }//fim altera


                    cmd.Parameters.AddWithValue("@nome", txtnome.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txttel.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtend.Text);
                    cmd.Parameters.AddWithValue("@senha", txtsenha.Text);


                    cmd.ExecuteNonQuery();
                    // Executar comando
                    if (txtcod.Text == "")
                    {
                        cmd.CommandText = "SELECT @@IDENTITY";
                        txtcod.Text = cmd.ExecuteScalar().ToString();
                    }

                }
                // Mensagem de sucesso
                Funcoes.MsgOK("Registro inserido com sucesso!");
            }
            catch (MySqlException ex)
            {
                // Mensagem de erro
                Funcoes.MsgErro($"Erro ao inserir registro: {ex.Message}");
            }
        }//Fim SalvarCliente


        //Validar Campos
        private bool ValidarCampos()
        {
            if (txtnome.Text == "")
            {
                Funcoes.MsgAlerta("Campo Nome é obrigatório!");
                txtnome.Focus();
                return false;
            }
            else if (txtemail.Text == "")
            {
                Funcoes.MsgAlerta("Campo Email é obrigatório!");
                txtemail.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txttel.Text) || !txttel.MaskFull) // Verifica se a máscara foi preenchida corretamente
            {
                Funcoes.MsgAlerta("Campo Telefone é obrigatório e deve estar no formato (XX) XXXXX-XXXX!");
                txttel.Focus();
                return false;
            }
            else if (txtend.Text == "")
            {
                Funcoes.MsgAlerta("Campo Endereço é obrigatório!");
                txtend.Focus();
                return false;
            }
            else if (txtsenha.Text == "")
            {
                Funcoes.MsgAlerta("Campo Senha é obrigatório!");
                txtsenha.Focus();
                return false;
            }
            return true;
        }//Fim ValidarCampos

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            string senha = Funcoes.Criptografar(txtsenha.Text);

        }
    }
}

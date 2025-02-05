using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1._2
{
    internal class Funcoes
    {
        string server = @"server=localhost;user id=root;password=;database=casaracao";

        public static DataTable DtLogin;

        //Memsagem de erro
        public static void MsgErro(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Funcoes.MsgErro("");
        }//Fim MsgErro


        //Mensagem de alerta
        public static void MsgAlerta(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Funcoes.MsgAlerta("");
        }//Fim MsgAlerta

        //Mensagem de informação
        public static void MsgOK(string Msg)
        {
            MessageBox.Show(Msg, "Cadastro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Funcoes.MsgOK("");
        }//Fim MsgOK

        //Mensagem de pergunta
        public static bool Pergunta(string Msg)
        {
            if (MessageBox.Show(Msg, "Cadastro de clientes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
                //Funcoes.Pergunta("");
            }
        }//Fim Pergunta

        //primeira letra maiuscula
        public static void PriMaiuscula(Control ctr)
        {
            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            String nome = ctr.Text;
            nome = textInfo.ToTitleCase(nome);

            nome = nome.Replace("Das", "das")
                       .Replace("Da", "da")
                       .Replace("Dos", "dos")
                       .Replace("Do", "do")
                       .Replace("De", "de");

            ctr.Text = nome;

            if (ctr is TextBox txt)
            {
                txt.SelectionStart = txt.Text.Length;
            }
            else if (ctr is ComboBox cb)
            {
                cb.SelectionStart = cb.Text.Length;
            }

            // Funcoes.PriMaiuscula(txt ou cb);

        }//Fim PriMaiuscula



        public static DataTable BuscaSql(string ComandoSql)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conexao = new MySqlConnection(@"server=localhost;user id=root;password=;database=casaracao"))
            {

                conexao.Open();
                using MySqlCommand cmd = conexao.CreateCommand();
                {
                    cmd.CommandText = ComandoSql;

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);

                        return dt;
                    }



                }
            }
        }

        public static void CarregarCombobox(ComboBox cb, string tabela, string campo)
        {

            cb.DataSource = Funcoes.BuscaSql("SELECT DISTINCT " + campo + "  FROM " + tabela + "WHERE " + campo + "<> ''");
            cb.DisplayMember = campo;
            cb.SelectedIndex = -1;


        }

        public static string Criptografar(string senha)
        {
            string chaveSecreta = "minhaChaveSecreta123"; // Chave secreta fixa (24 bytes)

            using (TripleDES tdes = TripleDES.Create())
            {
                tdes.Key = Encoding.UTF8.GetBytes(chaveSecreta.PadRight(24, ' ')); // A chave deve ter 24 bytes
                tdes.IV = new byte[8]; // Vetor de inicialização com 8 bytes (pode ser ajustado)

                ICryptoTransform encryptor = tdes.CreateEncryptor(tdes.Key, tdes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(senha);
                        }
                    }

                    return Convert.ToBase64String(ms.ToArray()); // Retorna a senha criptografada em Base64
                }
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1._2
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {

            dglista.DataSource = Funcoes.BuscaSql("SELECT Cliente_ID,Nome,Email,Telefone,Endereco,Senha FROM Cliente");

            dglista.ClearSelection();
            bteditar.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FrmCadCliente CadCliente = new FrmCadCliente();
            CadCliente.ShowDialog();

        }

        private void dglista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bteditar.Enabled = true;

        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            FrmCadCliente CadCliente = new FrmCadCliente();
            CadCliente.txtcod.Text = dglista.CurrentRow.Cells["Cliente_ID"].Value.ToString();
            CadCliente.ShowDialog();
            dglista.DataSource = Funcoes.BuscaSql("SELECT Cliente_ID,Nome,Email,Telefone,Endereco,Senha FROM Cliente");

        }

        private void pesqcod_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();


        }


        private void BuscarClientes()
        {
            dglista.DataSource = Funcoes.BuscaSql("SELECT * FROM Cliente WHERE 1 " + GerarCreiterios());

            if ((dglista.RowCount * 25) + 50 > 400)
            {
                dglista.Height = 400;
            }
            else
            {
                dglista.Height = ((dglista.RowCount * 25)+ 50);
            }


            ReorganizarDataGridView(dglista);

            Rodape();

            if (dglista.RowCount == 0)
            {
                lblaviso.Visible = true;
            }
            else 
            {
                lblaviso.Visible = false;
            }
        }
        private string GerarCreiterios()
        {
            string criterios = "";
            if (pesqcod.Text != string.Empty)
            {
                criterios += "AND Cliente_ID = " + pesqcod.Text;
            }
            if (pesqnome.Text != string.Empty)
            {
                criterios += $" AND Nome LIKE '%{pesqnome.Text}%' OR Email LIKE '%{pesqnome.Text}%' ";
            }

            if (pesqtel.Text != string.Empty)
            {
                criterios += $" AND Telefone LIKE '%{pesqtel.Text}%'";
            }

            if (pesqend.Text != string.Empty)
            {
                criterios += $" AND Endereco LIKE '%{pesqend.Text}%'";
            }
            return criterios;

        }










        private void ReorganizarDataGridView(DataGridView dataGridView)
        {
            if (dataGridView == null)
            {
                throw new ArgumentNullException(nameof(dataGridView), "O DataGridView não foi inicializado.");
            }

            // Ordenar os dados pela primeira coluna (se ela existir)
            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Sort(dataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }

            // Configurar larguras específicas para as colunas
            if (dataGridView.Columns.Contains("Código"))
            {
                dataGridView.Columns["Código"].Width = 106;
            }
            if (dataGridView.Columns.Contains("Nome do Cliente"))
            {
                dataGridView.Columns["Nome do Cliente"].Width = 301;
            }
            if (dataGridView.Columns.Contains("Email"))
            {
                dataGridView.Columns["Email"].Width = 280;
            }
            if (dataGridView.Columns.Contains("Telefone"))
            {
                dataGridView.Columns["Telefone"].Width = 173;
            }
            if (dataGridView.Columns.Contains("Endereço"))
            {
                dataGridView.Columns["Endereço"].Width = 183;
            }

            // Alterar o estilo da grade
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView.DefaultCellStyle.ForeColor = Color.Blue;

            // Ocultar uma coluna específica, se necessário
            if (dataGridView.Columns.Contains("Id"))
            {
                dataGridView.Columns["Id"].Visible = false;
            }
        }



        private void Rodape()
        {
            lbltotallocalizado.Text = "Total de registros localizados: " + dglista.Rows.Count;


        }

        private void dglista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

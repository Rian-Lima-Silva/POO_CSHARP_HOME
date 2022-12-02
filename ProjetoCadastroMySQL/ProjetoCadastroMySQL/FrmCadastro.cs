using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ProjetoCadastroMySQL
{
    public partial class FrmCadastro : Form
    {

        /// <summary>
        /// Instruções do SQL
        /// </summary>
        string sql;

        /// <summary>
        /// Id Selecionado
        /// </summary>
        int id = 0;

        /// <summary>
        /// Caminha da imagem
        /// </summary>
        string foto;

        /// <summary>
        /// Verifica-se está sendo alterada
        /// </summary>
        bool alterarFoto;

        MySQL conexao = new MySQL();
        MySqlCommand cmd;

        public FrmCadastro()
        {
            InitializeComponent();
        }
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
           LimparFoto();
           ConfigurarGrid(ClienteController.Ver());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparFoto();
            LimparForm();
            txtNome.Focus();
            Habilitar_Button(false, true, false, false, true, true);
            Habilitar_TextBox(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
               if (ClienteController.Salvar(txtNome.Text, txtEndereco.Text, txtCPF.Text, txtTelefone.Text,Img()))
               {
                   Habilitar_Button(true,false,true,true,true,false);
                   Habilitar_TextBox(true);
                   LimparForm();
                   LimparFoto();
               }
            }

            ConfigurarGrid(ClienteController.Ver());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                if (ClienteController.Editar(this.id, txtNome.Text, txtEndereco.Text, txtCPF.Text, txtTelefone.Text, Img(),alterarFoto))
                {
                    LimparForm();
                    LimparFoto();
                    Habilitar_Button(true, false, false, true, true, false);
                    Habilitar_TextBox(true);
                }
            }

            ConfigurarGrid(ClienteController.Ver());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {           
          if (ClienteController.Excluir(this.id))
          {
             LimparForm();
             Habilitar_Button(true, false, false, false, false, false);
             Habilitar_TextBox(false);
          }
            ConfigurarGrid(ClienteController.Ver());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparForm();
            this.id = 0;
            Habilitar_Button(true, false, false, false, false, false);
            Habilitar_TextBox(false);
            btnNovo.Focus();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Imagens(*.jpg;*.png) | *.jpg;*png";//Mostrar jpg e png

            if (file.ShowDialog() == DialogResult.OK)
            {
                //pegar caminho da imagem selecionada
                foto = file.FileName.ToString();
                pictureBox.ImageLocation = foto;
                alterarFoto = true;

            }
            else
            {
                alterarFoto = false;
            }
         
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ConfigurarGrid(ClienteController.Buscar(txtBuscar.Text));
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                alterarFoto = false;
               // LimparFoto();
                Habilitar_Button(false, false, true, true, true, true);
                Habilitar_TextBox(true);

                this.id = Convert.ToInt32(Grid.CurrentRow.Cells[0].Value.ToString());
                txtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
                txtEndereco.Text = Grid.CurrentRow.Cells[2].Value.ToString();
                txtCPF.Text = Grid.CurrentRow.Cells[3].Value.ToString();
                txtTelefone.Text = Grid.CurrentRow.Cells[4].Value.ToString();

                //Pegar Foto
                //DBNull.Value - se o valor do banco de dados(database) veio nulo

                
                
                if(Grid.CurrentRow.Cells[5].Value != DBNull.Value)
                {
                    byte[] imagem_grid = (byte[])Grid.Rows[e.RowIndex].Cells[5].Value;

                    MemoryStream ms = new MemoryStream(imagem_grid);

                    pictureBox.Image = Image.FromStream(ms);  

                }
                else 
                {
                    pictureBox.Image = Properties.Resources.baseline_group_black_48dp;
                }

            }else
            {
                return;
            }
        }




        /// <summary>
        /// Controla ativação ou desativação dos botões
        /// </summary>
        /// <param name="novo"></param>
        /// <param name="salvar"></param>
        /// <param name="editar"></param>
        /// <param name="excluir"></param>
        /// <param name="cancelar"></param>
        private void Habilitar_Button(bool novo, bool salvar, bool editar, bool excluir, bool cancelar, bool imagem)
        {
            btnNovo.Enabled = novo;
            btnSalvar.Enabled = salvar;
            btnEditar.Enabled = editar;
            btnExcluir.Enabled = excluir;
            btnCancelar.Enabled = cancelar;
            btnImagem.Enabled = imagem;

        }

        /// <summary>
        /// Limpa todos os campos do formulario
        /// </summary>
        private void LimparForm()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtCPF.Clear();
            txtTelefone.Clear();
        }

        /// <summary>
        /// Habilita(true) ou desabilita(false) todas as textBox do formulario
        /// </summary>
        /// <param name="ativo"></param>
        /// <param name="Id_Visible"> controla a visibilidade e habilitação de id</param>
        private void Habilitar_TextBox(bool ativo)
        {
            txtNome.Enabled = ativo;
            txtEndereco.Enabled = ativo;
            txtCPF.Enabled = ativo;
            txtTelefone.Enabled = ativo;

        }

        /// <summary>
        /// Verifica se todos os TextBox tem algum valor
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidarDados()
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite um Nome!", "Tela de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                txtNome.Clear();
                return false;
            }
            else if (txtEndereco.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Digite seu Endereço!", "Tela de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Focus();
                txtEndereco.Clear();
                return false;
            }
            else if (txtCPF.Text == "   .   .   -" && txtCPF.Text.Length < 14)
            {
                MessageBox.Show("Digite um CPF!", "Tela de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus();
                return false;
            }
            else if (txtTelefone.Text == "(  )      -" && txtTelefone.Text.Length < 14)
            {
                MessageBox.Show("Digite um Telefone!", "Tela de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Configura o DataGridView
        /// </summary>
        private void ConfigurarGrid(DataTable tabela)
        {
            Grid.DataSource = tabela;

            //Id
            Grid.Columns[0].HeaderText = "Código";
            Grid.Columns[0].Width = 80;
            Grid.Columns[0].Visible = false;

            //Nome
            Grid.Columns[1].HeaderText = "Nome";
            Grid.Columns[1].Width = 150;

            //Endereco
            Grid.Columns[2].HeaderText = "Endereço";
            Grid.Columns[2].Width = 230;

            //CPF
            Grid.Columns[3].HeaderText = "CPF";
            Grid.Columns[3].Width = 150;

            //Telefone
            Grid.Columns[4].HeaderText = "Telefone";
            Grid.Columns[4].Width = 150;

            //Imagem
            Grid.Columns[5].HeaderText = "Imagem";
            Grid.Columns[5].Visible = false;
        }

        /// <summary>
        /// Metodo para enviar imagem para o banco de dados
        /// </summary>
        /// <returns></returns>
        private byte[] Img()
        {
            byte[] imagem_byte = null;

            if (foto == "")
            {
                return null;
            }

            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);

            return imagem_byte;

        }

        private void LimparFoto()
        {
            pictureBox.Image = Properties.Resources.baseline_group_black_48dp;
            foto = "ft/baseline_group_black_48dp.png";
        }

    }//Partial Class

}//Namespace
    

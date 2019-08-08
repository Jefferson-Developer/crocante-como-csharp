using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCliente : Form
    {
        int RegistroAtual = 0; // Variável para guardar o número do registro onde o usuário está.
        string CadastroFlag; // Variável para marcar qual
        // Método sem retorno que irá habilitar edição de usuário.
        private void HabilitarEdicao()
        {
            NomeClienteTextBox.Enabled = true; // Ativa a caixa de texto de nome do cliente.
            DataNascClienteTextBox.Enabled = true; // Ativa a caixa de texto de data de nascimento do cliente.
            EnderecoClienteTextBox.Enabled = true; // Ativa a caixa de texto do endereço do cliente.
            CEPClienteTextBox.Enabled = true; // Ativa a caixa de texto do CEP do cliente.
            TelefoneClienteTextBox.Enabled = true; // Ativa a caixa de texto de telefone do cliente.
            EmailClienteTextBox.Enabled = true; // Ativa a caixa de texto de telefone do cliente.

            AnteriorButton.Enabled = false; // Desativa o botão 'Anterior'.
            ProximoButton.Enabled = false;
            NovoButton.Enabled = false;
            AlterarButton.Enabled = false;
            ExcluirButton.Enabled = false;
            SalvarButton.Enabled = true;
            CancelarButton.Enabled = true;
            PesquisarButton.Enabled = false;
            ImprimirButton.Enabled = false;
            SairButton.Enabled = false;
        }

        private void DesabilitarEdicao()
        {
            NomeClienteTextBox.Enabled = false; // Ativa a caixa de texto de nome do cliente.
            DataNascClienteTextBox.Enabled = false; // Ativa a caixa de texto de data de nascimento do cliente.
            EnderecoClienteTextBox.Enabled = false; // Ativa a caixa de texto do endereço do cliente.
            CEPClienteTextBox.Enabled = false; // Ativa a caixa de texto do CEP do cliente.
            TelefoneClienteTextBox.Enabled = false; // Ativa a caixa de texto de telefone do cliente.
            EmailClienteTextBox.Enabled = false; // Ativa a caixa de texto de telefone do cliente.

            AnteriorButton.Enabled = true; // Ativa o botão 'Anterior'.
            ProximoButton.Enabled = true; // Ativa o botão 'Próximo'.
            NovoButton.Enabled = true; // Ativa o botão 'Novo'.
            AlterarButton.Enabled = true; // Ativa o botão 'Alterar'.
            ExcluirButton.Enabled = true; // Ativa o botão 'Excluir'.
            SalvarButton.Enabled = false; // Desativa o botão 'Salvar'.
            CancelarButton.Enabled = false; // Desativa o botão 'Cancelar'.
            PesquisarButton.Enabled = true; // Ativa o botão 'Pesquisar'.
            ImprimirButton.Enabled = true; // Ativa o botão 'Imprimir'.
            SairButton.Enabled = true; // Ativa o botão 'Sair'.
        }
        public FormCliente()
        {
            InitializeComponent();
        }
        // Quando for clicado, executa um método para habilitar certos componentes.
        private void NovoButton_Click(object sender, EventArgs e)
        {
            if (FormPrincipal.ContadorCliente < 10)
            {
                HabilitarEdicao();
                CodigoTextBox.Text = (FormPrincipal.ContadorUsuario + 1).ToString();
                NomeClienteTextBox.Text = "";
                DataNascClienteTextBox.Text = "";
                EnderecoClienteTextBox.Text = "";
                CEPClienteTextBox.Text = "";
                TelefoneClienteTextBox.Text = "";
                NomeClienteTextBox.Focus(); // Move o foco para o campo de nome de usuário.
                CadastroFlag = "Novo";
            }
        }
        // Quando for clicado, executa um método para habilitar certos componentes.
        private void AlterarButton_Click(object sender, EventArgs e)
        {
            if (FormPrincipal.ContadorCliente > 0)
            {
                HabilitarEdicao();
                NomeClienteTextBox.Focus();
                CadastroFlag = "Alterar";
                //MessageBox.Show();
            }
        }
        // Quando for clicado, executa um método para habilitar certos componentes.
        private void SalvarButton_Click(object sender, EventArgs e)
        {
            DesabilitarEdicao();
            if (CadastroFlag == "Novo")
            {
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].CodigoCliente = Convert.ToInt32(CodigoTextBox.Text);
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].NomeCliente = NomeClienteTextBox.Text;
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].DataNascCliente = DataNascClienteTextBox.Text;
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].EnderecoCliente = EnderecoClienteTextBox.Text;
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].CEPCliente = CEPClienteTextBox.Text;
                RegistroAtual = FormPrincipal.ContadorUsuario++;
            }
            else
            {
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].NomeCliente = NomeClienteTextBox.Text;
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].DataNascCliente = DataNascClienteTextBox.Text;
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].EnderecoCliente = EnderecoClienteTextBox.Text;
                FormPrincipal.GuardarCliente[FormPrincipal.ContadorCliente].CEPCliente = CEPClienteTextBox.Text;
            }
        }
        // Quando for clicado, executa um método para habilitar certos componentes.
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarEdicao();
            MostrarRegistro();
        }
        // Quando clicado, fecha a janela acessada.
        private void SairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            if (RegistroAtual > 0)
            {
                RegistroAtual--;
                MostrarRegistro();
            }
        }
        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            FormPrincipal.GuardarUsuario[RegistroAtual].NomeUsuario = "";
            FormPrincipal.GuardarUsuario[RegistroAtual].SiglaNivel = "";
            FormPrincipal.GuardarUsuario[RegistroAtual].NomeLogin = "";
            FormPrincipal.GuardarUsuario[RegistroAtual].SenhaUsuario = "";
        }
        private void ProximoButton_Click(object sender, EventArgs e)
        {
            // Contador -1 um pq vetor buga
            if (RegistroAtual < FormPrincipal.ContadorUsuario - 1)
            {
                RegistroAtual++;
                MostrarRegistro();
            }
        }

        private void MostrarRegistro()
        {
            CodigoTextBox.Text = FormPrincipal.GuardarCliente[RegistroAtual].CodigoCliente.ToString();
            NomeClienteTextBox.Text = FormPrincipal.GuardarCliente[RegistroAtual].NomeCliente;
            DataNascClienteTextBox.Text = FormPrincipal.GuardarCliente[RegistroAtual].DataNascCliente;
            EnderecoClienteTextBox.Text = FormPrincipal.GuardarCliente[RegistroAtual].EnderecoCliente;
            CEPClienteTextBox.Text = FormPrincipal.GuardarCliente[RegistroAtual].CEPCliente;
        }

        // Quando entramos no formulário, no carregamento, defini um método para desabilitar alguns componentes.
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            DesabilitarEdicao();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

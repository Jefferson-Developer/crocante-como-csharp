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
    public partial class FormUsuario : Form
    {
        int RegistroAtual = 0; // Variável para guardar o número do registro onde o usuário está.
        string CadastroFlag; // Variável para marcar qual
        // Método sem retorno que irá habilitar edição de usuário.
        private void HabilitarEdicao()
        {
            NomeTextBox.Enabled = true; // Ativa a caixa de texto de nome de usuário.
            NivelTextBox.Enabled = true; // Ativa a caixa de texto...
            LoginTextBox.Enabled = true;
            SenhaTextBox.Enabled = true;

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
            NomeTextBox.Enabled = false; // Desativa a caixa de texto de nome de usuário.
            NivelTextBox.Enabled = false; // Desativa a caixa de texto...
            LoginTextBox.Enabled = false;
            SenhaTextBox.Enabled = false;

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
        public FormUsuario()
        {
            InitializeComponent();
        }
        // Quando for clicado, executa um método para habilitar certos componentes.
        private void NovoButton_Click(object sender, EventArgs e)
        {
            if(FormPrincipal.ContadorUsuario < 10)
            {
                HabilitarEdicao();
                CodigoTextBox.Text = (FormPrincipal.ContadorUsuario + 1).ToString();
                NomeTextBox.Text = "";
                NivelTextBox.Text = "";
                LoginTextBox.Text = "";
                SenhaTextBox.Text = "";
                NomeTextBox.Focus(); // Move o foco para o campo de nome de usuário.
                CadastroFlag = "Novo";
            }
        }
        // Quando for clicado, executa um método para habilitar certos componentes.
        private void AlterarButton_Click(object sender, EventArgs e)
        {
            if (FormPrincipal.ContadorUsuario > 0)
            {
                HabilitarEdicao();
                NomeTextBox.Focus();
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
                FormPrincipal.GuardarUsuario[FormPrincipal.ContadorUsuario].CodigoUsuario = Convert.ToInt32(CodigoTextBox.Text);
                FormPrincipal.GuardarUsuario[FormPrincipal.ContadorUsuario].NomeUsuario = NomeTextBox.Text;
                FormPrincipal.GuardarUsuario[FormPrincipal.ContadorUsuario].SiglaNivel = NivelTextBox.Text;
                FormPrincipal.GuardarUsuario[FormPrincipal.ContadorUsuario].NomeLogin = LoginTextBox.Text;
                FormPrincipal.GuardarUsuario[FormPrincipal.ContadorUsuario].SenhaUsuario = SenhaTextBox.Text;
                RegistroAtual = FormPrincipal.ContadorUsuario++;
            }
            else
            {
                FormPrincipal.GuardarUsuario[RegistroAtual].NomeUsuario = NomeTextBox.Text;
                FormPrincipal.GuardarUsuario[RegistroAtual].SiglaNivel = NivelTextBox.Text;
                FormPrincipal.GuardarUsuario[RegistroAtual].NomeLogin = LoginTextBox.Text;
                FormPrincipal.GuardarUsuario[RegistroAtual].SenhaUsuario = SenhaTextBox.Text;
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
            if(RegistroAtual > 0)
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
            if(RegistroAtual < FormPrincipal.ContadorUsuario - 1)
            {
                RegistroAtual++;
                MostrarRegistro();
            } 
        }

        private void MostrarRegistro()
        {
            CodigoTextBox.Text = FormPrincipal.GuardarUsuario[RegistroAtual].CodigoUsuario.ToString();
            NomeTextBox.Text = FormPrincipal.GuardarUsuario[RegistroAtual].NomeUsuario;
            NivelTextBox.Text = FormPrincipal.GuardarUsuario[RegistroAtual].SiglaNivel;
            LoginTextBox.Text = FormPrincipal.GuardarUsuario[RegistroAtual].NomeLogin;
            SenhaTextBox.Text = FormPrincipal.GuardarUsuario[RegistroAtual].SenhaUsuario;
        }

        // Quando entramos no formulário, no carregamento, defini um método para desabilitar alguns componentes.
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            DesabilitarEdicao();
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
        }

        private void btnSairPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (PesquisaTxt.Text != "")
            {
                for (i = 0; i < FormPrincipal.ContadorUsuario; i++)
                {
                    if (FormPrincipal.GuardarUsuario[i].NomeUsuario == PesquisaTxt.Text)
                    {
                        RegistroAtual = i;
                        MostrarRegistro();
                        break;
                    }
                    if (i >= FormPrincipal.ContadorUsuario)
                    {
                        MessageBox.Show("Não encontrado!");
                    }
                    pnlPesquisa.Visible = false;
                }
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class FormPrincipal : Form
    {
        // Declaração de variáveis globais.
        public static int ContadorUsuario = 0; // Contador de usuário, onde são contados quantos usuários tem no sistema, ou guardar o usuário atual.
        public static int ContadorCliente = 0; // Contador de usuário, onde são contados quantos usuários tem no sistema, ou guardar o usuário atual.
        public static int ContadorFornecedor = 0; // Contador de usuário, onde são contados quantos usuários tem no sistema, ou guardar o usuário atual.
        public struct Usuario // Estrutura de um usuário.
        {
            public int CodigoUsuario;
            public string NomeUsuario;
            public string SiglaNivel;
            public string NomeLogin;
            public string SenhaUsuario;
        }
        public struct Cliente // Estrutura de um cliente.
        {
            public int CodigoCliente; // Código para referência do cliente.
            public string NomeCliente; // Nome do cliente
            public string DataNascCliente; // Data de Nascimento do cliente.
            public string EnderecoCliente; // Endereço do cliente.
            public string CEPCliente; // CEP do cliente.
            public string TelefoneCliente; // Telefone do cliente.
            public string EmailCliente; // E-mail do cliente.
        }
        // Vetor para guardar cadastros de usuários.
        public static Usuario[] GuardarUsuario = new Usuario[5];
        // Vetor para guardar cadastros de clientes.
        public static Cliente[] GuardarCliente = new Cliente[5];
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void UsuarioMenuStrip_Click(object sender, EventArgs e)
        {
            FormUsuario FormularioUsuario = new FormUsuario();
            FormularioUsuario.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente FormularioCliente = new FormCliente();
            FormularioCliente.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

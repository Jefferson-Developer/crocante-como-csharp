using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text=="adm"&& txtSenha.Text=="123")
            {
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
        }
    }
}

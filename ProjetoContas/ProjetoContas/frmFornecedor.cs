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
    public partial class frmFornecedor : Form
    {
        private void Habilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }
        private void Desabilita()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;

            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.contasDataSet.tbFornecedor);

        }

        private void ds_enderecoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ds_emailLabel_Click(object sender, EventArgs e)
        {

        }
        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveLast();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.AddNew();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbFornecedorBindingSource.EndEdit();
            tbFornecedorTableAdapter.Update(this.contasDataSet.tbFornecedor);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFornecedorBindingSource.Count > 0)
            {
                tbFornecedorBindingSource.RemoveCurrent();
                tbFornecedorTableAdapter.Update(contasDataSet.tbFornecedor);
            }
            else
            {
                MessageBox.Show("NÃO HÁ REGISTRO A EXCLUIR");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

namespace ProjetoCadastro
{
    partial class FormUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Codigo = new System.Windows.Forms.Label();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.NomeUsuario = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.Nivel = new System.Windows.Forms.Label();
            this.NivelTextBox = new System.Windows.Forms.TextBox();
            this.LoginUsuario = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.SenhaUsuario = new System.Windows.Forms.Label();
            this.SenhaTextBox = new System.Windows.Forms.TextBox();
            this.AnteriorButton = new System.Windows.Forms.Button();
            this.ProximoButton = new System.Windows.Forms.Button();
            this.NovoButton = new System.Windows.Forms.Button();
            this.AlterarButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.SairButton = new System.Windows.Forms.Button();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.PesquisaTxt = new System.Windows.Forms.TextBox();
            this.txtPesquisa = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSairPesquisa = new System.Windows.Forms.Button();
            this.pnlPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(35, 56);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(43, 13);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Código:";
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Location = new System.Drawing.Point(98, 54);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoTextBox.TabIndex = 1;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.AutoSize = true;
            this.NomeUsuario.Location = new System.Drawing.Point(40, 110);
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(38, 13);
            this.NomeUsuario.TabIndex = 2;
            this.NomeUsuario.Text = "Nome:";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NomeTextBox.Location = new System.Drawing.Point(98, 106);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NomeTextBox.TabIndex = 3;
            // 
            // Nivel
            // 
            this.Nivel.AutoSize = true;
            this.Nivel.Location = new System.Drawing.Point(43, 155);
            this.Nivel.Name = "Nivel";
            this.Nivel.Size = new System.Drawing.Size(34, 13);
            this.Nivel.TabIndex = 4;
            this.Nivel.Text = "Nivel:";
            // 
            // NivelTextBox
            // 
            this.NivelTextBox.Location = new System.Drawing.Point(98, 147);
            this.NivelTextBox.Name = "NivelTextBox";
            this.NivelTextBox.Size = new System.Drawing.Size(100, 20);
            this.NivelTextBox.TabIndex = 5;
            // 
            // LoginUsuario
            // 
            this.LoginUsuario.AutoSize = true;
            this.LoginUsuario.Location = new System.Drawing.Point(46, 196);
            this.LoginUsuario.Name = "LoginUsuario";
            this.LoginUsuario.Size = new System.Drawing.Size(36, 13);
            this.LoginUsuario.TabIndex = 6;
            this.LoginUsuario.Text = "Login:";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(98, 196);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 7;
            // 
            // SenhaUsuario
            // 
            this.SenhaUsuario.AutoSize = true;
            this.SenhaUsuario.Location = new System.Drawing.Point(46, 236);
            this.SenhaUsuario.Name = "SenhaUsuario";
            this.SenhaUsuario.Size = new System.Drawing.Size(41, 13);
            this.SenhaUsuario.TabIndex = 8;
            this.SenhaUsuario.Text = "Senha:";
            // 
            // SenhaTextBox
            // 
            this.SenhaTextBox.Location = new System.Drawing.Point(98, 234);
            this.SenhaTextBox.Name = "SenhaTextBox";
            this.SenhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.SenhaTextBox.TabIndex = 9;
            // 
            // AnteriorButton
            // 
            this.AnteriorButton.Location = new System.Drawing.Point(43, 309);
            this.AnteriorButton.Name = "AnteriorButton";
            this.AnteriorButton.Size = new System.Drawing.Size(75, 23);
            this.AnteriorButton.TabIndex = 10;
            this.AnteriorButton.Text = "Anterior";
            this.AnteriorButton.UseVisualStyleBackColor = true;
            this.AnteriorButton.Click += new System.EventHandler(this.AnteriorButton_Click);
            // 
            // ProximoButton
            // 
            this.ProximoButton.Location = new System.Drawing.Point(147, 309);
            this.ProximoButton.Name = "ProximoButton";
            this.ProximoButton.Size = new System.Drawing.Size(75, 23);
            this.ProximoButton.TabIndex = 11;
            this.ProximoButton.Text = "Próximo";
            this.ProximoButton.UseVisualStyleBackColor = true;
            this.ProximoButton.Click += new System.EventHandler(this.ProximoButton_Click);
            // 
            // NovoButton
            // 
            this.NovoButton.Location = new System.Drawing.Point(258, 309);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(75, 23);
            this.NovoButton.TabIndex = 12;
            this.NovoButton.Text = "Novo";
            this.NovoButton.UseVisualStyleBackColor = true;
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // AlterarButton
            // 
            this.AlterarButton.Location = new System.Drawing.Point(385, 309);
            this.AlterarButton.Name = "AlterarButton";
            this.AlterarButton.Size = new System.Drawing.Size(75, 23);
            this.AlterarButton.TabIndex = 13;
            this.AlterarButton.Text = "Alterar";
            this.AlterarButton.UseVisualStyleBackColor = true;
            this.AlterarButton.Click += new System.EventHandler(this.AlterarButton_Click);
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(517, 308);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 14;
            this.ExcluirButton.Text = "Excluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Location = new System.Drawing.Point(43, 356);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(75, 23);
            this.SalvarButton.TabIndex = 15;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(147, 355);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 16;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Location = new System.Drawing.Point(258, 356);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(75, 23);
            this.PesquisarButton.TabIndex = 17;
            this.PesquisarButton.Text = "Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(385, 355);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 23);
            this.ImprimirButton.TabIndex = 18;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // SairButton
            // 
            this.SairButton.Location = new System.Drawing.Point(517, 355);
            this.SairButton.Name = "SairButton";
            this.SairButton.Size = new System.Drawing.Size(75, 23);
            this.SairButton.TabIndex = 19;
            this.SairButton.Text = "Sair";
            this.SairButton.UseVisualStyleBackColor = true;
            this.SairButton.Click += new System.EventHandler(this.SairButton_Click);
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.Controls.Add(this.PesquisaTxt);
            this.pnlPesquisa.Controls.Add(this.txtPesquisa);
            this.pnlPesquisa.Location = new System.Drawing.Point(385, 27);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(287, 82);
            this.pnlPesquisa.TabIndex = 20;
            this.pnlPesquisa.Visible = false;
            // 
            // PesquisaTxt
            // 
            this.PesquisaTxt.Location = new System.Drawing.Point(62, 3);
            this.PesquisaTxt.Name = "PesquisaTxt";
            this.PesquisaTxt.Size = new System.Drawing.Size(201, 20);
            this.PesquisaTxt.TabIndex = 0;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AutoSize = true;
            this.txtPesquisa.Location = new System.Drawing.Point(6, 3);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(50, 13);
            this.txtPesquisa.TabIndex = 21;
            this.txtPesquisa.Text = "Pesquisa";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(447, 75);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSairPesquisa
            // 
            this.btnSairPesquisa.Location = new System.Drawing.Point(573, 75);
            this.btnSairPesquisa.Name = "btnSairPesquisa";
            this.btnSairPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnSairPesquisa.TabIndex = 23;
            this.btnSairPesquisa.Text = "Sair";
            this.btnSairPesquisa.UseVisualStyleBackColor = true;
            this.btnSairPesquisa.Click += new System.EventHandler(this.btnSairPesquisa_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSairPesquisa);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.SairButton);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.PesquisarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.SalvarButton);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.AlterarButton);
            this.Controls.Add(this.NovoButton);
            this.Controls.Add(this.ProximoButton);
            this.Controls.Add(this.AnteriorButton);
            this.Controls.Add(this.SenhaTextBox);
            this.Controls.Add(this.SenhaUsuario);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginUsuario);
            this.Controls.Add(this.NivelTextBox);
            this.Controls.Add(this.Nivel);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.NomeUsuario);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.Codigo);
            this.Name = "FormUsuario";
            this.Text = "Formulário de Usuário";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label NomeUsuario;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label Nivel;
        private System.Windows.Forms.TextBox NivelTextBox;
        private System.Windows.Forms.Label LoginUsuario;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label SenhaUsuario;
        private System.Windows.Forms.TextBox SenhaTextBox;
        private System.Windows.Forms.Button AnteriorButton;
        private System.Windows.Forms.Button ProximoButton;
        private System.Windows.Forms.Button NovoButton;
        private System.Windows.Forms.Button AlterarButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Button SairButton;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.TextBox PesquisaTxt;
        private System.Windows.Forms.Label txtPesquisa;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSairPesquisa;
    }
}
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Valor1 = new System.Windows.Forms.Label();
            this.Valor1Txt = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.Valor2Txt = new System.Windows.Forms.TextBox();
            this.Soma = new System.Windows.Forms.Button();
            this.Multiplicação = new System.Windows.Forms.Button();
            this.Subtração = new System.Windows.Forms.Button();
            this.Divisão = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.ResultadoTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Valor1
            // 
            this.Valor1.AutoSize = true;
            this.Valor1.Location = new System.Drawing.Point(185, 125);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(37, 13);
            this.Valor1.TabIndex = 0;
            this.Valor1.Text = "Valor1";
            // 
            // Valor1Txt
            // 
            this.Valor1Txt.Location = new System.Drawing.Point(242, 118);
            this.Valor1Txt.Name = "Valor1Txt";
            this.Valor1Txt.Size = new System.Drawing.Size(88, 20);
            this.Valor1Txt.TabIndex = 1;
            // 
            // Valor2
            // 
            this.Valor2.AutoSize = true;
            this.Valor2.Location = new System.Drawing.Point(183, 162);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(37, 13);
            this.Valor2.TabIndex = 2;
            this.Valor2.Text = "Valor2";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(183, 214);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(55, 13);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Resultado";
            // 
            // Valor2Txt
            // 
            this.Valor2Txt.Location = new System.Drawing.Point(242, 160);
            this.Valor2Txt.Name = "Valor2Txt";
            this.Valor2Txt.Size = new System.Drawing.Size(87, 20);
            this.Valor2Txt.TabIndex = 4;
            // 
            // Soma
            // 
            this.Soma.Location = new System.Drawing.Point(360, 118);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(60, 37);
            this.Soma.TabIndex = 5;
            this.Soma.Text = "Soma";
            this.Soma.UseVisualStyleBackColor = true;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Multiplicação
            // 
            this.Multiplicação.Location = new System.Drawing.Point(359, 169);
            this.Multiplicação.Name = "Multiplicação";
            this.Multiplicação.Size = new System.Drawing.Size(77, 29);
            this.Multiplicação.TabIndex = 6;
            this.Multiplicação.Text = "Multiplicação";
            this.Multiplicação.UseVisualStyleBackColor = true;
            this.Multiplicação.Click += new System.EventHandler(this.Multiplicação_Click);
            // 
            // Subtração
            // 
            this.Subtração.Location = new System.Drawing.Point(426, 118);
            this.Subtração.Name = "Subtração";
            this.Subtração.Size = new System.Drawing.Size(79, 37);
            this.Subtração.TabIndex = 7;
            this.Subtração.Text = "Subtração";
            this.Subtração.UseVisualStyleBackColor = true;
            this.Subtração.Click += new System.EventHandler(this.Subtração_Click);
            // 
            // Divisão
            // 
            this.Divisão.Location = new System.Drawing.Point(442, 169);
            this.Divisão.Name = "Divisão";
            this.Divisão.Size = new System.Drawing.Size(63, 29);
            this.Divisão.TabIndex = 8;
            this.Divisão.Text = "Divisão";
            this.Divisão.UseVisualStyleBackColor = true;
            this.Divisão.Click += new System.EventHandler(this.Divisão_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(300, 264);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(69, 35);
            this.Sair.TabIndex = 9;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // ResultadoTxt
            // 
            this.ResultadoTxt.Location = new System.Drawing.Point(244, 211);
            this.ResultadoTxt.Name = "ResultadoTxt";
            this.ResultadoTxt.Size = new System.Drawing.Size(105, 20);
            this.ResultadoTxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(713, 571);
            this.Controls.Add(this.ResultadoTxt);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Divisão);
            this.Controls.Add(this.Subtração);
            this.Controls.Add(this.Multiplicação);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Valor2Txt);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1Txt);
            this.Controls.Add(this.Valor1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Valor1;
        private System.Windows.Forms.TextBox Valor1Txt;
        private System.Windows.Forms.Label Valor2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox Valor2Txt;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Multiplicação;
        private System.Windows.Forms.Button Subtração;
        private System.Windows.Forms.Button Divisão;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.TextBox ResultadoTxt;
    }
}


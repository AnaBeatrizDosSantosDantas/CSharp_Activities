namespace WindowsForms_Atividades_06Novembro
{
    partial class FrmSegundoExercicio
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
            this.lblNomeDupla = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtImposto = new System.Windows.Forms.TextBox();
            this.lstPrimeiroResultado = new System.Windows.Forms.ListBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.lstResultadoFinal = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.CalcularAumento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeDupla
            // 
            this.lblNomeDupla.AutoSize = true;
            this.lblNomeDupla.Location = new System.Drawing.Point(280, 9);
            this.lblNomeDupla.Name = "lblNomeDupla";
            this.lblNomeDupla.Size = new System.Drawing.Size(216, 13);
            this.lblNomeDupla.TabIndex = 0;
            this.lblNomeDupla.Text = "Ana Beatriz e Karen Amanda - 06-Novembro";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 74);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(69, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário bruto:";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(12, 112);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(47, 13);
            this.lblImposto.TabIndex = 3;
            this.lblImposto.Text = "Imposto:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(87, 71);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // txtImposto
            // 
            this.txtImposto.Location = new System.Drawing.Point(87, 109);
            this.txtImposto.Name = "txtImposto";
            this.txtImposto.Size = new System.Drawing.Size(100, 20);
            this.txtImposto.TabIndex = 6;
            // 
            // lstPrimeiroResultado
            // 
            this.lstPrimeiroResultado.FormattingEnabled = true;
            this.lstPrimeiroResultado.Location = new System.Drawing.Point(15, 150);
            this.lstPrimeiroResultado.Name = "lstPrimeiroResultado";
            this.lstPrimeiroResultado.Size = new System.Drawing.Size(322, 30);
            this.lstPrimeiroResultado.TabIndex = 7;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(12, 200);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(224, 13);
            this.lblPorcentagem.TabIndex = 8;
            this.lblPorcentagem.Text = "Digite a porcentagem para aumentar o salário:";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(237, 197);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentagem.TabIndex = 9;
            // 
            // lstResultadoFinal
            // 
            this.lstResultadoFinal.FormattingEnabled = true;
            this.lstResultadoFinal.Location = new System.Drawing.Point(15, 238);
            this.lstResultadoFinal.Name = "lstResultadoFinal";
            this.lstResultadoFinal.Size = new System.Drawing.Size(322, 30);
            this.lstResultadoFinal.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(434, 112);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(79, 39);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(434, 238);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 39);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(434, 301);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(79, 39);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // CalcularAumento
            // 
            this.CalcularAumento.Location = new System.Drawing.Point(434, 174);
            this.CalcularAumento.Name = "CalcularAumento";
            this.CalcularAumento.Size = new System.Drawing.Size(79, 39);
            this.CalcularAumento.TabIndex = 14;
            this.CalcularAumento.Text = "Calcular com Aumento";
            this.CalcularAumento.UseVisualStyleBackColor = true;
            this.CalcularAumento.Click += new System.EventHandler(this.CalcularAumento_Click);
            // 
            // FrmSegundoExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcularAumento);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstResultadoFinal);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lstPrimeiroResultado);
            this.Controls.Add(this.txtImposto);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNomeDupla);
            this.Name = "FrmSegundoExercicio";
            this.Text = "FrmSegundoExercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDupla;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtImposto;
        private System.Windows.Forms.ListBox lstPrimeiroResultado;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.ListBox lstResultadoFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button CalcularAumento;
    }
}
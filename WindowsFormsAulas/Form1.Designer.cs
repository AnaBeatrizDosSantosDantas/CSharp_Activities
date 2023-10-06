namespace WindowsFormsAulas
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAlemao = new System.Windows.Forms.RadioButton();
            this.rdbEspanhol = new System.Windows.Forms.RadioButton();
            this.rdbIngles = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Digite seu nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(12, 31);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(112, 13);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Digite seu sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(136, 32);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(22, 113);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 4;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(12, 63);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(105, 63);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(199, 63);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAlemao);
            this.groupBox1.Controls.Add(this.rdbEspanhol);
            this.groupBox1.Controls.Add(this.rdbIngles);
            this.groupBox1.Location = new System.Drawing.Point(15, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Curso";
            // 
            // rdbAlemao
            // 
            this.rdbAlemao.AutoSize = true;
            this.rdbAlemao.Location = new System.Drawing.Point(10, 31);
            this.rdbAlemao.Name = "rdbAlemao";
            this.rdbAlemao.Size = new System.Drawing.Size(60, 17);
            this.rdbAlemao.TabIndex = 9;
            this.rdbAlemao.TabStop = true;
            this.rdbAlemao.Text = "Alemão";
            this.rdbAlemao.UseVisualStyleBackColor = true;
            // 
            // rdbEspanhol
            // 
            this.rdbEspanhol.AutoSize = true;
            this.rdbEspanhol.Location = new System.Drawing.Point(10, 68);
            this.rdbEspanhol.Name = "rdbEspanhol";
            this.rdbEspanhol.Size = new System.Drawing.Size(69, 17);
            this.rdbEspanhol.TabIndex = 10;
            this.rdbEspanhol.TabStop = true;
            this.rdbEspanhol.Text = "Espanhol";
            this.rdbEspanhol.UseVisualStyleBackColor = true;
            // 
            // rdbIngles
            // 
            this.rdbIngles.AutoSize = true;
            this.rdbIngles.Location = new System.Drawing.Point(10, 105);
            this.rdbIngles.Name = "rdbIngles";
            this.rdbIngles.Size = new System.Drawing.Size(53, 17);
            this.rdbIngles.TabIndex = 11;
            this.rdbIngles.TabStop = true;
            this.rdbIngles.Text = "Inglês";
            this.rdbIngles.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(231, 161);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 36);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(231, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAlemao;
        private System.Windows.Forms.RadioButton rdbEspanhol;
        private System.Windows.Forms.RadioButton rdbIngles;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
    }
}


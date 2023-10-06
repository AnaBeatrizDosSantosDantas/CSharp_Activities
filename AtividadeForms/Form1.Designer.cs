namespace AtividadeForms
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblCivil = new System.Windows.Forms.Label();
            this.cboCivil = new System.Windows.Forms.ComboBox();
            this.ckbFilhos = new System.Windows.Forms.CheckBox();
            this.lstCadastro = new System.Windows.Forms.ListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gpxSexo = new System.Windows.Forms.GroupBox();
            this.gpxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(302, 20);
            this.txtNome.TabIndex = 1;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(7, 19);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 3;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(121, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 4;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 80);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(15, 106);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(381, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(428, 80);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(431, 106);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(12, 152);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(15, 181);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(159, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(196, 152);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(199, 181);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(152, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(383, 152);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(386, 180);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 14;
            // 
            // lblCivil
            // 
            this.lblCivil.AutoSize = true;
            this.lblCivil.Location = new System.Drawing.Point(12, 226);
            this.lblCivil.Name = "lblCivil";
            this.lblCivil.Size = new System.Drawing.Size(65, 13);
            this.lblCivil.TabIndex = 15;
            this.lblCivil.Text = "Estado Civil:";
            // 
            // cboCivil
            // 
            this.cboCivil.FormattingEnabled = true;
            this.cboCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Divorciado(a)",
            "Separado(a)"});
            this.cboCivil.Location = new System.Drawing.Point(15, 252);
            this.cboCivil.Name = "cboCivil";
            this.cboCivil.Size = new System.Drawing.Size(121, 21);
            this.cboCivil.TabIndex = 16;
            // 
            // ckbFilhos
            // 
            this.ckbFilhos.AutoSize = true;
            this.ckbFilhos.Location = new System.Drawing.Point(199, 256);
            this.ckbFilhos.Name = "ckbFilhos";
            this.ckbFilhos.Size = new System.Drawing.Size(53, 17);
            this.ckbFilhos.TabIndex = 17;
            this.ckbFilhos.Text = "Filhos";
            this.ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // lstCadastro
            // 
            this.lstCadastro.FormattingEnabled = true;
            this.lstCadastro.Location = new System.Drawing.Point(16, 304);
            this.lstCadastro.Name = "lstCadastro";
            this.lstCadastro.Size = new System.Drawing.Size(410, 134);
            this.lstCadastro.TabIndex = 18;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(495, 226);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 47);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(495, 304);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 46);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(495, 382);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(88, 44);
            this.btnFechar.TabIndex = 21;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gpxSexo
            // 
            this.gpxSexo.Controls.Add(this.rdbFeminino);
            this.gpxSexo.Controls.Add(this.rdbMasculino);
            this.gpxSexo.Location = new System.Drawing.Point(383, 9);
            this.gpxSexo.Name = "gpxSexo";
            this.gpxSexo.Size = new System.Drawing.Size(200, 45);
            this.gpxSexo.TabIndex = 22;
            this.gpxSexo.TabStop = false;
            this.gpxSexo.Text = "Sexo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.gpxSexo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lstCadastro);
            this.Controls.Add(this.ckbFilhos);
            this.Controls.Add(this.cboCivil);
            this.Controls.Add(this.lblCivil);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpxSexo.ResumeLayout(false);
            this.gpxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblCivil;
        private System.Windows.Forms.ComboBox cboCivil;
        private System.Windows.Forms.CheckBox ckbFilhos;
        private System.Windows.Forms.ListBox lstCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox gpxSexo;
    }
}


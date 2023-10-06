namespace WindowsFormsAulas
{
    partial class FrmListBox
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSelecionado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(104, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Entre com um nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.Location = new System.Drawing.Point(15, 91);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(120, 160);
            this.lstNome.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(172, 37);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(172, 75);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 4;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(172, 113);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(172, 152);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar Lista";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSelecionado
            // 
            this.btnSelecionado.Location = new System.Drawing.Point(172, 193);
            this.btnSelecionado.Name = "btnSelecionado";
            this.btnSelecionado.Size = new System.Drawing.Size(75, 36);
            this.btnSelecionado.TabIndex = 7;
            this.btnSelecionado.Text = "Nome Selecionado";
            this.btnSelecionado.UseVisualStyleBackColor = true;
            this.btnSelecionado.Click += new System.EventHandler(this.btnSelecionado_Click);
            // 
            // FrmListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelecionado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmListBox";
            this.Text = "FrmListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSelecionado;
    }
}
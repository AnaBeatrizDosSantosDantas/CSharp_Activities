namespace WindowsForms_Atividades_06Novembro
{
    partial class FrmTerceiroExercicio
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
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeDupla
            // 
            this.lblNomeDupla.AutoSize = true;
            this.lblNomeDupla.Location = new System.Drawing.Point(286, 9);
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
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do aluno:";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(12, 67);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(144, 13);
            this.lblNotas.TabIndex = 2;
            this.lblNotas.Text = "Digite as três notas do aluno:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(243, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(15, 92);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 4;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(15, 127);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(15, 163);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 6;
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(15, 208);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(234, 95);
            this.lstResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(322, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 41);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(322, 208);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 41);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(322, 262);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(84, 41);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmTerceiroExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNomeDupla);
            this.Name = "FrmTerceiroExercicio";
            this.Text = "FrmTerceiroExercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDupla;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}
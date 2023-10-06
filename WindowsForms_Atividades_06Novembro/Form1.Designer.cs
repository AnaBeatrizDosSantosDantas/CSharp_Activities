namespace WindowsForms_Atividades_06Novembro
{
    partial class Form1
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
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtEnunciadoLargura = new System.Windows.Forms.TextBox();
            this.txtEnunciadoAltura = new System.Windows.Forms.TextBox();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeDupla
            // 
            this.lblNomeDupla.AutoSize = true;
            this.lblNomeDupla.Location = new System.Drawing.Point(297, 9);
            this.lblNomeDupla.Name = "lblNomeDupla";
            this.lblNomeDupla.Size = new System.Drawing.Size(216, 13);
            this.lblNomeDupla.TabIndex = 0;
            this.lblNomeDupla.Text = "Ana Beatriz e Karen Amanda - 06-Novembro";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(12, 39);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(202, 13);
            this.lblEnunciado.TabIndex = 1;
            this.lblEnunciado.Text = "Entre com a largura e altura do retângulo:";
            // 
            // txtEnunciadoLargura
            // 
            this.txtEnunciadoLargura.Location = new System.Drawing.Point(15, 64);
            this.txtEnunciadoLargura.Name = "txtEnunciadoLargura";
            this.txtEnunciadoLargura.Size = new System.Drawing.Size(100, 20);
            this.txtEnunciadoLargura.TabIndex = 2;
            // 
            // txtEnunciadoAltura
            // 
            this.txtEnunciadoAltura.Location = new System.Drawing.Point(15, 100);
            this.txtEnunciadoAltura.Name = "txtEnunciadoAltura";
            this.txtEnunciadoAltura.Size = new System.Drawing.Size(100, 20);
            this.txtEnunciadoAltura.TabIndex = 3;
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(15, 154);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(263, 134);
            this.lstResultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(327, 154);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 37);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(327, 206);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(104, 34);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(327, 255);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(104, 33);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmPrimeiroExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.txtEnunciadoAltura);
            this.Controls.Add(this.txtEnunciadoLargura);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.lblNomeDupla);
            this.Name = "FrmPrimeiroExercicio";
            this.Text = "FrmPrimeiroExercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeDupla;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.TextBox txtEnunciadoLargura;
        private System.Windows.Forms.TextBox txtEnunciadoAltura;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}
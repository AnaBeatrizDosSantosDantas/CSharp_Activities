namespace WindowsFormsAulas
{
    partial class FrmCheckBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbCachorro = new System.Windows.Forms.CheckBox();
            this.ckbGato = new System.Windows.Forms.CheckBox();
            this.ckbPassarinho = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbPassarinho);
            this.groupBox1.Controls.Add(this.ckbGato);
            this.groupBox1.Controls.Add(this.ckbCachorro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal preferido";
            // 
            // ckbCachorro
            // 
            this.ckbCachorro.AutoSize = true;
            this.ckbCachorro.Location = new System.Drawing.Point(6, 31);
            this.ckbCachorro.Name = "ckbCachorro";
            this.ckbCachorro.Size = new System.Drawing.Size(69, 17);
            this.ckbCachorro.TabIndex = 0;
            this.ckbCachorro.Text = "Cachorro";
            this.ckbCachorro.UseVisualStyleBackColor = true;
            // 
            // ckbGato
            // 
            this.ckbGato.AutoSize = true;
            this.ckbGato.Location = new System.Drawing.Point(6, 63);
            this.ckbGato.Name = "ckbGato";
            this.ckbGato.Size = new System.Drawing.Size(49, 17);
            this.ckbGato.TabIndex = 1;
            this.ckbGato.Text = "Gato";
            this.ckbGato.UseVisualStyleBackColor = true;
            // 
            // ckbPassarinho
            // 
            this.ckbPassarinho.AutoSize = true;
            this.ckbPassarinho.Location = new System.Drawing.Point(6, 98);
            this.ckbPassarinho.Name = "ckbPassarinho";
            this.ckbPassarinho.Size = new System.Drawing.Size(78, 17);
            this.ckbPassarinho.TabIndex = 2;
            this.ckbPassarinho.Text = "Passarinho";
            this.ckbPassarinho.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(231, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 35);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(231, 69);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 34);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCheckBox";
            this.Text = "FrmCheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbPassarinho;
        private System.Windows.Forms.CheckBox ckbGato;
        private System.Windows.Forms.CheckBox ckbCachorro;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnLimpar;
    }
}
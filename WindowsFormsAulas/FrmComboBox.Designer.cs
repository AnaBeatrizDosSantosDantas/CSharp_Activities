namespace WindowsFormsAulas
{
    partial class FrmComboBox
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
            this.cboRegiao = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboRegiao
            // 
            this.cboRegiao.FormattingEnabled = true;
            this.cboRegiao.Items.AddRange(new object[] {
            "Norte",
            "Nordeste",
            "Centro-Oeste",
            "Sul",
            "Sudeste"});
            this.cboRegiao.Location = new System.Drawing.Point(25, 38);
            this.cboRegiao.Name = "cboRegiao";
            this.cboRegiao.Size = new System.Drawing.Size(121, 21);
            this.cboRegiao.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(176, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(176, 38);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(22, 9);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(100, 13);
            this.lblEscolha.TabIndex = 3;
            this.lblEscolha.Text = "Escolha sua região:";
            // 
            // FrmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboRegiao);
            this.Name = "FrmComboBox";
            this.Text = "FrmComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRegiao;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblEscolha;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAulas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Olá, " + txtNome.Text + " " + txtSobrenome.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtNome.Focus();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rdbAlemao.Checked == true)
            {
                MessageBox.Show("Escolheu o curso Alemão.");
            }
            else if (rdbEspanhol.Checked == true)
            {
                MessageBox.Show("Escolheu o curso Espanhol.");
            }
            else if (rdbIngles.Checked == true)
            {
                MessageBox.Show("Escolheu o curso Inglês.");
            }
            else
            {
                MessageBox.Show("Não escolheu nenhuma opção.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rdbAlemao.Checked = false;
            rdbEspanhol.Checked = false;
            rdbIngles.Checked = false;
        }
    }
}

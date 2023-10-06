using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cboEstado.Text = "";
            cboCivil.Text = "";
            rdbFeminino.Checked = false;
            rdbMasculino.Checked = false;
            ckbFilhos.Checked = false;
            lstCadastro.Items.Clear();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lstCadastro.Items.Add(txtNome.Text);
            txtNome.Text = "";
            lstCadastro.Items.Add(txtEndereco.Text);
            txtEndereco.Text = "";
            lstCadastro.Items.Add(txtNumero.Text);
            txtNumero.Text = "";
            lstCadastro.Items.Add(txtBairro.Text);
            txtBairro.Text = "";
            lstCadastro.Items.Add(txtCidade.Text);
            txtCidade.Text = "";
            lstCadastro.Items.Add(cboEstado.Text);
            cboEstado.Text = "";
            lstCadastro.Items.Add(cboCivil.Text);
            cboCivil.Text = "";

            //Sexo
            if (rdbFeminino.Checked == true)
            {
                lstCadastro.Items.Add(rdbFeminino.Text);
                rdbFeminino.Text = "Feminino";
            }
            else if (rdbMasculino.Checked == true)
            {
                lstCadastro.Items.Add(rdbMasculino.Text);
                rdbMasculino.Text = "Masculino";
            }
            else
            {
                MessageBox.Show("Não escolheu nenhuma opção de gênero.");
            }

            //Filhos
            if (ckbFilhos.Checked == true)
            {
                lstCadastro.Items.Add(ckbFilhos.Text);
                ckbFilhos.Text = "Filhos";
            }
            else
            {
                MessageBox.Show("Não possui filhos.");
            }
            txtNome.Focus();
        }
    }
}

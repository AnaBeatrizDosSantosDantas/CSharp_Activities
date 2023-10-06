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
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            lstNome.Items.Add(txtNome.Text);
            txtNome.Text = "";
            txtNome.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstNome.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstNome.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um nome da lista para excluir");
                return;
            }
            lstNome.Items.Remove(lstNome.SelectedItem);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNome.Items.Clear();
        }

        private void btnSelecionado_Click(object sender, EventArgs e)
        {
            if (lstNome.SelectedIndex == -1)
            {

                MessageBox.Show("Selecione um nome da lista.");
                return;
            }
            MessageBox.Show("Nome Selecionado :" + lstNome.Text);

        }
    }
}

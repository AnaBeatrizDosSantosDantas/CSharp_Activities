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
    public partial class FrmComboBox : Form
    {
        public FrmComboBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
			string uf = "";
			if (cboRegiao.SelectedIndex == 0)
			{
				uf = " Norte ";
			}
			else if (cboRegiao.SelectedIndex == 1)
			{
				uf = " Nordeste ";
			}
			else if (cboRegiao.SelectedIndex == 2)
			{
				uf = " Centro-Oeste ";
			}
			else if (cboRegiao.SelectedIndex == 3)
			{
				uf = " Sul ";
			}
			else
			{
				uf = " Sudeste ";
			}
			MessageBox.Show("Você escolheu a região" + uf + "do Brasil.");
		}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
			cboRegiao.SelectedIndex = -1;
		}
    }
}

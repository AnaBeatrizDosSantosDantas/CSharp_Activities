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
    public partial class FrmCheckBox : Form
    {
        public FrmCheckBox()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ckbCachorro.Checked)
            {
                msg = "cachorro";
            }
            if (ckbGato.Checked)
            {
                msg += " gato";
            }
            if (ckbPassarinho.Checked)
            {
                msg += " passarinho";
            }

            if (msg.Length > 0)
            {
                MessageBox.Show("Seu(s) animal(is) preferido(s) é(são): " + msg);
            }
            else
            {
                MessageBox.Show("Nenhuma opção selecionada!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ckbCachorro.Checked = false;
            ckbGato.Checked = false;
            ckbPassarinho.Checked = false;
        }
    }
}

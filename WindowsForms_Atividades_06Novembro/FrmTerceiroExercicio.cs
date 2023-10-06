using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Atividades_06Novembro
{
    public partial class FrmTerceiroExercicio : Form
    {
        public FrmTerceiroExercicio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaro as variáveis, as converto para decimal e as jogo nos labels
            double nota1, nota2, nota3, notafinal, pontosfaltantes;



            nota1 = double.Parse(txtNota1.Text, CultureInfo.InvariantCulture);
            nota2 = double.Parse(txtNota2.Text, CultureInfo.InvariantCulture);
            nota3 = double.Parse(txtNota3.Text, CultureInfo.InvariantCulture);


            notafinal = nota1 + nota2 + nota3;
            pontosfaltantes = 60.0 - notafinal;


            if (notafinal >= 60.0)
            {
                lstResultado.Items.Add("NOTA FINAL = " + notafinal.ToString("F2", CultureInfo.InvariantCulture));
                lstResultado.Items.Add("APROVADO");
            }
            else
            {
                lstResultado.Items.Add("NOTA FINAL = " + notafinal.ToString("F2", CultureInfo.InvariantCulture));
                lstResultado.Items.Add("REPROVADO");
                lstResultado.Items.Add("FALTARAM " + pontosfaltantes.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            lstResultado.Items.Clear();
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}

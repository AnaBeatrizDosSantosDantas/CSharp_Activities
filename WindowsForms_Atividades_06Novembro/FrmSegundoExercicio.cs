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
    public partial class FrmSegundoExercicio : Form
    {
        public FrmSegundoExercicio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaro as variáveis, as converto para decimal e as jogo nos labels
            double salario, imposto, resultado1, resultado2;


            salario = double.Parse(txtSalario.Text, CultureInfo.InvariantCulture);
            imposto = double.Parse(txtImposto.Text, CultureInfo.InvariantCulture);
           
            resultado1 = salario - imposto;
           
            lstPrimeiroResultado.Items.Add("Funcionário: " + txtNome.Text + ", $ " + resultado1.ToString("F2", CultureInfo.InvariantCulture));

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSalario.Text = "";
            txtImposto.Text = "";
            txtPorcentagem.Text = "";
            lstPrimeiroResultado.Items.Clear();
            lstResultadoFinal.Items.Clear();
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalcularAumento_Click(object sender, EventArgs e)
        {
            //Declaro as variáveis, as converto para decimal e as jogo nos labels
            double salario, imposto, porcentagem, resultado2;

            porcentagem = double.Parse(txtPorcentagem.Text, CultureInfo.InvariantCulture);
            salario = double.Parse(txtSalario.Text, CultureInfo.InvariantCulture);
            imposto = double.Parse(txtImposto.Text, CultureInfo.InvariantCulture);

            resultado2 = (salario - imposto) + (salario * porcentagem) / 100.0;
            lstResultadoFinal.Items.Add("Dados atualizados: " + txtNome.Text + ", $ " + resultado2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

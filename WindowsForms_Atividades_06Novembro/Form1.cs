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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {

                //Declaro as variáveis, as converto para decimal e as jogo nos labels
                double largura, altura, area, perimetro, diagonal;


                largura = double.Parse(txtEnunciadoLargura.Text, CultureInfo.InvariantCulture);
                altura = double.Parse(txtEnunciadoAltura.Text, CultureInfo.InvariantCulture);
                area = largura * altura;
                perimetro = (largura + altura) * 2;
                diagonal = Math.Sqrt(Math.Pow(largura, 2.00) + Math.Pow(altura, 2.00));

                lstResultado.Items.Add("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
                lstResultado.Items.Add("Perímetro =  " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
                lstResultado.Items.Add("Diagonal =  " + diagonal.ToString("F2", CultureInfo.InvariantCulture));




            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEnunciadoLargura.Text = "";
            txtEnunciadoAltura.Text = "";
            lstResultado.Items.Clear();
            txtEnunciadoLargura.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAulas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //PARA RODAR O PROGRAMA 1 ALTERE A LINHA 20 PARA Application.Run(new Form1());
            Application.Run(new FrmListBox());
        }
    }
}

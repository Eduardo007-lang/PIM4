using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.View;
using PIM_4_Periodo.View;
using PIM_4_PERIODO.View.__Tela_Principal__.Entrega_de_Veiculo;


 namespace PIM_4_PERIODO
{
    static class Principal
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tela_Login());
        }
    }
}

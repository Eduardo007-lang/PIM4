using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Chat
{
    public partial class Tela_Chat : Form
    {
        public Tela_Chat()
        {
            InitializeComponent();
        }

        private void Procurar_Btn_Enter(object sender, EventArgs e)
        {
            Procurar_Btn.Image = Properties.Resources.POCURAR_SELECT;
        }

        private void Procurar_Btn_Leave(object sender, EventArgs e)
        {
            Procurar_Btn.Image = Properties.Resources.POCURAR;
        }

        private void custom_Conversa1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.View.__Tela_Principal__.Chat;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Sac
{
    public partial class Tela_Sac : Form
    {
        public Tela_Sac()
        {            
            InitializeComponent();
        }

        private void Atendimento_Btn_Click(object sender, EventArgs e)
        {
            Sac_Label.Hide();
            Atendimento_Btn.Hide();

            Tela_Chat Chat = new Tela_Chat();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Chat.TopLevel = false;
            Chat.AutoScroll = true;
            Chat.Show();

            PainelCentral.Controls.Add(Chat);
            PainelCentral.Show();

            this.Controls.Add(PainelCentral);
        }
    }
}


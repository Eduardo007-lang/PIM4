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

namespace PIM_4_PERIODO.View.__Tela_Principal__.Atendimento
{
    public partial class Tela_Conversa : Form
    {
        public Tela_Conversa()
        {
            InitializeComponent();
        }

        private void Envia_Mensagem_Btn_Enter(object sender, EventArgs e)
        {
            Envia_Mensagem_Btn.Image = Properties.Resources.ENVIA_MENSAGEM_SELECT;
        }

        private void Envia_Mensagem_Btn_Leave(object sender, EventArgs e)
        {
            Envia_Mensagem_Btn.Image = Properties.Resources.ENVIA_MENSAGEM;
        }

        private void Voltar_Btn_Enter(object sender, EventArgs e)
        {
            Voltar_Btn.Image = Properties.Resources.VOLTAR_SELECT;
        }

        private void Voltar_Btn_Leave(object sender, EventArgs e)
        {
            Voltar_Btn.Image = Properties.Resources.VOLTAR;
        }

        private void Voltar_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Chat Chat = new Tela_Chat();
            Chat.TopLevel = false;
            Chat.AutoScroll = true;
            this.Controls.Add(Chat);
            Chat.Show();
        }
    }
}

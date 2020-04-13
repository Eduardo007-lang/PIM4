using System;
using System.Drawing;
using System.Windows.Forms;
using PIM_4_PERIODO.Model;
using PIM_4_PERIODO.Dao;
using PIM_4_PERIODO.View;



namespace PIM_4_Periodo.View
{
    public partial class Tela_Login : Form
    {
        public Tela_Login()
        {
            InitializeComponent();
            Label_Error.Visible = false;
        }
        private void Repoisicionamento_ErrorLabel()
        {
            Label_Error.Visible = true;
            int PanelImg_Center = (this.Size.Width - Label_Error.Size.Width) / 2;
            Label_Error.Location = new Point(PanelImg_Center, Panel_LoginImg.Location.Y + Panel_LoginImg.Height);
        }
        private void Entra_Button_Click(object sender, EventArgs e)
        {           
            if (TxTBox_Usuario.Text != "" && TxTBox_Senha.Text != "")
            {
                Login Login = new Login();
                Consultar Consulta = new Consultar();


                Login.Usuario = TxTBox_Usuario.Text.TrimEnd(' ');
                Login.Senha = TxTBox_Senha.Text;
                if (Consulta.Entra_Sistema(Login))
                {
                    this.Hide();
                    TelaPrincipal Principal = new TelaPrincipal(Login.Usuario, Login.Senha);
                    Principal.Show();
                }
                else
                {
                    Label_Error.Text = "Usuário ou Senha inválidos";
                    Repoisicionamento_ErrorLabel();
                }
            }
            else
            {
                Label_Error.Text = "Usuário e Senha não podem ser vazios";
                Repoisicionamento_ErrorLabel();
            }
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TxTBox_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Entra_Button_Click(sender, e);
            }
        }
        private void TxTBox_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Entra_Button_Click(sender, e);
            }
        }
    }
}
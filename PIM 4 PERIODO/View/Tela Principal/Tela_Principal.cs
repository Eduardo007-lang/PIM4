using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using PIM_4_PERIODO.Model;
using PIM_4_Periodo.View;
using PIM_4_PERIODO.View.__Tela_Principal__.Home;
using PIM_4_PERIODO.View.__Tela_Principal__.Solicitacao;
using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro;
using PIM_4_PERIODO.View.__Tela_Principal__.Sac;
using PIM_4_PERIODO.View.__Tela_Principal__.Chat;
using PIM_4_PERIODO.View.__Tela_Principal__.RedeifinirSenha;
using PIM_4_PERIODO.View.Tela_Principal.Solicitacao;

namespace PIM_4_PERIODO.View
{
    public partial class TelaPrincipal : Form
    {
        Tela_Home Home;
        Tela_Solicitação Solicitacao;
        Tela_Cadastro Cadastro;
        Tela_Sac Sac;
        Tela_Chat Chat;

        private string Usuario_VindoDoLogin = "";
        private string Senha_VindoDoLogin = "";



        public TelaPrincipal(String Usuario, String Senha)
        {
            InitializeComponent();
            Usuario_VindoDoLogin = Usuario;
            Senha_VindoDoLogin = Senha;
            Console.WriteLine("Usuario Logado: " + Usuario);
            Console.WriteLine("Usuario Logado: " + Senha);


            //Incia Sempre o sistema com o Botao Home Ativo
            if (!Home_btn.Active)
            {
                Home_btn.Active = true;
                Home = new Tela_Home();
                Home.TopLevel = false;
                Home.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Home);
                Home.Show();
            }
        }
        
        public void BotaoDoSac()
        {
            if (Home_btn.Active)
            {
                Home_btn.selected = false;
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (!Atendimento_btn.Active)
            {
                Atendimento_btn.Active = true;
                Chat = new Tela_Chat();
                Chat.TopLevel = false;
                Chat.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Chat);
                Chat.Show();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (Relatorios_btn.Active)
            {
                //Relatorios.Close();
            }
            if (Abastecimento_Btn.Active)
            {
                //Abastecimento.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            Tela_Login Login = new Tela_Login();
            this.Hide();
            Login.Show();
        }
        private void TrocaSenha_Btn_Click(object sender, EventArgs e)
        {
            RedefiniSenha Redefinir_Senha = new RedefiniSenha(Usuario_VindoDoLogin, Senha_VindoDoLogin);
            Redefinir_Senha.Show();
        }

        //Botões do Painel de menus
        private void Home_btn_Click(object sender, EventArgs e)
        {
            if (!Home_btn.Active)
            {
                Home = new Tela_Home();
                Home.TopLevel = false;
                Home.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Home);
                Home.Show();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (Relatorios_btn.Active)
            {
                //Relatorios.Close();
            }
            if (Abastecimento_Btn.Active)
            {
                //Abastecimento.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
        }
        private void Solicitacao_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home_btn.selected = false; 
                Home.Close();
            }
            if (!Solicitacao_btn.Active)
            {
                Solicitacao_btn.Active = true;
                Solicitacao = new Tela_Solicitação();
                Solicitacao.TopLevel = false;
                Solicitacao.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Solicitacao);
                Solicitacao.Show();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();

            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (Relatorios_btn.Active)
            {
                //Relatorios.Close();
            }
            if (Abastecimento_Btn.Active)
            {
                //Abastecimento.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
        }
        private void Atendimento_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home_btn.selected = false;
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (!Atendimento_btn.Active)
            {
                Atendimento_btn.Active = true;
                Chat = new Tela_Chat();
                Chat.TopLevel = false;
                Chat.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Chat);
                Chat.Show();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (Relatorios_btn.Active)
            {
                //Relatorios.Close();
            }
            if (Abastecimento_Btn.Active)
            {
                //Abastecimento.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }            
        }
        private void Cadastro_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                 Home_btn.selected = false; Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                
            }
            if (!Cadastro_btn.Active)
            {
                Cadastro_btn.Active = true;
                Cadastro = new Tela_Cadastro();
                Cadastro.TopLevel = false;
                Cadastro.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Cadastro);
                Cadastro.Show();
            }
            if (Relatorios_btn.Active)
            {
                //Relatorios.Close();
            }
            if (Abastecimento_Btn.Active)
            {
                //Abastecimento.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }

        }
        private void Relatorios_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                 Home_btn.selected = false; Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (!Relatorios_btn.Active)
            {
                Relatorios_btn.Active = true;
            }
            if (Abastecimento_Btn.Active)
            {
                //Abastecimento.Close();
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
        }
        private void SAC_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home_btn.selected = false;
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (Relatorios_btn.Active)
            {
                //Relatorios.Close();
            }
            if (Abastecimento_Btn.Active)
            {
                //Abastecimento.Close();
            }
            if (!SAC_btn.Active)
            {
                SAC_btn.selected = true;
                Sac = new Tela_Sac();
                Sac.TopLevel = false;
                Sac.AutoScroll = true;
                this.Panel_Menus.Controls.Add(Sac);
                Sac.Show();
            }
            
        }
        private void Abastecimento_btn_Click(object sender, EventArgs e)
        {
            if (Home_btn.Active)
            {
                Home_btn.selected = false;
                Home.Close();
            }
            if (Solicitacao_btn.Active)
            {
                Solicitacao.Close();
            }
            if (Atendimento_btn.Active)
            {
                Chat.Close();
                
            }
            if (Cadastro_btn.Active)
            {
                Cadastro.Close();
            }
            if (Relatorios_btn.Active)
            {
                //Relatorios.Close();
            }
            if (!Abastecimento_Btn.Active)
            {
                Abastecimento_Btn.Active = true;
            }
            if (SAC_btn.Active)
            {
                Sac.Close();
            }
        }

        
    }
}

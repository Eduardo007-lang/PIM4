using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.Model;
using PIM_4_PERIODO.Dao;

namespace PIM_4_PERIODO.View.__Tela_Principal__.RedeifinirSenha
{
    public partial class RedefiniSenha : Form
    {
        private Usuario Usuario = new Usuario();
        private Consultar Consulta = new Consultar();
        private String Usuario_VindoDaPrincial = "";
        private String Senha_VindoDaPrincial = "";

        public RedefiniSenha(String Usuario, String Senha)
        {
            Usuario_VindoDaPrincial = Usuario;
            Senha_VindoDaPrincial = Senha;
            
            InitializeComponent();
        }
        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2) , RedefSenha_Label.Location.Y + Error_Label.Height + RedefSenha_Label.Height + 5);
        }

        private Usuario FeedUsuario(String UserName)
        {
            Usuario.Username = UserName;
            DataTable Table = Consulta.Usuario(Usuario, 1);
            if (Table.Rows.Count > 0)
            {
                Console.WriteLine("Linhas"+Table.Rows.Count);
                Console.WriteLine("Colunas"+Table.Columns.Count);
                Console.WriteLine("Indo Entrar no For");

                for(int informações = Convert.ToInt32(Table.Columns.Count) - 1 ; informações >= 0; informações--)
                {
                    Console.WriteLine("Já no For");
                    Console.WriteLine(informações);
                    Console.WriteLine(Convert.ToString(Table.Rows[0][informações]));                    
                }

                Usuario.ID_Usuario = Convert.ToInt32(Table.Rows[0][0]);
                Usuario.Username = Convert.ToString(Table.Rows[0][1]);
                Usuario.Senha = Convert.ToString(Table.Rows[0][2]);
                Usuario.Departamento = Convert.ToInt32(Table.Rows[0][3]);
                Usuario.Nome = Convert.ToString(Table.Rows[0][4]);
                Usuario.Email = Convert.ToString(Table.Rows[0][5]);
                Usuario.CPF = Convert.ToString(Table.Rows[0][6]);
                Usuario.Telefone = Convert.ToInt32(Table.Rows[0][7]);
                Usuario.Celular = Convert.ToInt32(Table.Rows[0][8]);
                Usuario.Endereço = Convert.ToString(Table.Rows[0][9]);
                Usuario.CNH = Convert.ToInt32(Table.Rows[0][10]);
                Usuario.Validade_CNH = Convert.ToDateTime(Table.Rows[0][11]);
                Usuario.Categoria_CNH = Convert.ToString(Table.Rows[0][12]);
                Usuario.Data_Adimissao = Convert.ToDateTime(Table.Rows[0][13]);
            }
            return Usuario;
        }
        
        private void Cancelar_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Redefinir_Btn_Click(object sender, EventArgs e)
        {
            if (TxTBox_SenhaAntiga.Text != "" && TxTBox_NovaSenha.Text != "" && TxTBox_ConfirmaNovaSenha.Text != "")
            {
                if (TxTBox_NovaSenha.Text == TxTBox_ConfirmaNovaSenha.Text && TxTBox_SenhaAntiga.Text == Senha_VindoDaPrincial)
                {
                    Usuario = FeedUsuario(Usuario_VindoDaPrincial);
                    Console.WriteLine("Redefinição de Senha, ID Usuario: " + Usuario.ID_Usuario);
                    Console.WriteLine("Redefinição de Senha, UserName: " + Usuario.Username);
                    Console.WriteLine("Redefinição de Senha, Senha: " + Usuario.Senha);
                    Usuario.Senha = TxTBox_NovaSenha.Text;
                    Alterar Altera = new Alterar();

                    if(Altera.Usuario(Usuario, 1))
                    {
                        Repoisicionamento_Label(Sucesso_Label);
                    }
                    else
                    {
                        Error_Label.Text = "Ocorreu um erro durante a alteração";
                        Repoisicionamento_Label(Error_Label);
                    }
                }
                else
                {
                    Error_Label.Text = "As Senhas não correspondem";
                    Repoisicionamento_Label(Error_Label);
                }
            }
            else
            {
                Error_Label.Text = "As Senhas não podem ser vazias";
                Repoisicionamento_Label(Error_Label);
            }
        }

        private void TxTBox_SenhaAntiga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Redefinir_Btn_Click(sender, e);
            }
        }
        private void TxTBox_NovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Redefinir_Btn_Click(sender, e);
            }
        }
        private void TxTBox_ConfirmaNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Redefinir_Btn_Click(sender, e);
            }
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

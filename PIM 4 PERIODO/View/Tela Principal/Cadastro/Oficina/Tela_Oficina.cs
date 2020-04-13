using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Tela_Oficina
{
    public partial class Oficina : Form
    {
        Model.Oficina oficina = new Model.Oficina();
        Dao.Incluir Incluir = new Dao.Incluir();
        public Oficina()
        {
            InitializeComponent();
        }
        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            // Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroOfina_Label.Location.Y + Error_Label.Height + CadastroOleo_Label.Height + 5);
        }
        private void Cancelar_Btn_Click(object sender, EventArgs e)
        {
           
            Tela_Cadastro Cadastro = new Tela_Cadastro();
            Panel PainelCentral = new Panel();
            PainelCentral.Dock = DockStyle.Fill;
            Cadastro.TopLevel = false;
            PainelCentral.Controls.Add(Cadastro);
            this.Controls.Add(PainelCentral);
            PainelCentral.BringToFront();
            Cadastro.Show();
            PainelCentral.Show();
        }

        private void Cadastrar_Btn_Click(object sender, EventArgs e)
        {
            if (TxTBox_NomeOficina.Text != "" && TxTBox_RazaoSocial.Text != "" && TxTBox_CNPJ.Text != "" && TxTBox_Telefone.Text != "" && TxTBox_SiteOficina.Text != "" && TxTBox_Endereco.Text != "" && TxTBox_Celular.Text != "" && TxTBox_Endereco.Text != "")
            {
                oficina.Nome = TxTBox_NomeOficina.Text;
                oficina.RazaoSocial = TxTBox_RazaoSocial.Text;
                oficina.Site = TxTBox_SiteOficina.Text;
                oficina.Telefone = Convert.ToInt32(TxTBox_Telefone.Text);
                oficina.CNPJ = TxTBox_CNPJ.Text;
                oficina.Celular = Convert.ToInt32(TxTBox_Celular.Text);
                oficina.Endereço = TxTBox_Endereco.Text;

                if (Incluir.Oficina(oficina, 1))
                {
                    Repoisicionamento_Label(Sucesso_Label);
                }
                else
                {
                    Error_Label.Text = "Ocorreu um erro durante o Cadastro";
                    Repoisicionamento_Label(Error_Label);
                }
            }
            else
            {
                Error_Label.Text = "Os campos não podem ser vazios";
                Repoisicionamento_Label(Error_Label);
            }
        }
    }
}
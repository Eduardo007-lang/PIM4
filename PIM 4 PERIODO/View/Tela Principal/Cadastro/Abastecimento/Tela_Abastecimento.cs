using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Abastecimento
{
    public partial class Tela_Abastecimento : Form
    {
        Model.Abastecimento Abastecimento = new Model.Abastecimento();
        Dao.Incluir Incluir = new Dao.Incluir();

        public Tela_Abastecimento()
        {
            InitializeComponent();
        }

        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroAbastecimento_Label.Location.Y + Error_Label.Height + CadastroAbastecimento_Label.Height + 5);
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
            if (TxTBox_NomeMotorista.Text != "" && TxTBox_NomeEmpresa.Text != "" && TxTBox_Veiculo_Abastecimento.Text != "")
            {
                if (TxTBox_Veiculo_Abastecimento.Text.Contains(","))
                {
                    TxTBox_Veiculo_Abastecimento.Text = TxTBox_Veiculo_Abastecimento.Text.Replace(",", ".");
                }

                Abastecimento.Valor = float.Parse(TxTBox_Valor_Abastecidos.Text);
                Abastecimento.Litros = float.Parse(TxTBox_Litros.Text);


                if (Incluir.Abastecimento(Abastecimento, 1))
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

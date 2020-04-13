using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM_4_PERIODO.Dao;
using PIM_4_PERIODO.Model;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Veiculo
{
    public partial class Tela_Cadastro_Veiculo : Form
    {
        Model.Veiculo Veiculo = new Model.Veiculo();
        Incluir Incluir = new Incluir();

        public Tela_Cadastro_Veiculo()
        {
            InitializeComponent();
            
        }

        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroVeiculo_Label.Location.Y + Error_Label.Height + CadastroVeiculo_Label.Height + 5);
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
            if(
                TxTBox_Placa.Text != "" 
                && TxTBox_Marca.Text != "" && TxTBox_Modelo.Text != "" && TxTBox_Ano.Text != "" 
                && TxTBox_Combustivel.Text != "" && TxTBox_KmLitro.Text != "" && TxTBox_KmPneu.Text != ""
                && TxTBox_CapDoTanque.Text != "" && TxTBox_Renavan.Text != "" && TxTBox_Chassi.Text != ""
                )
            {
                if (TxTBox_KmLitro.Text.Contains(","))
                {
                    TxTBox_KmLitro.Text = TxTBox_KmLitro.Text.Replace(",", ".");
                }
                if (TxTBox_KmPneu.Text.Contains(","))
                {
                    TxTBox_KmPneu.Text = TxTBox_KmPneu.Text.Replace(",", ".");
                }
                if (TxTBox_Revisao.Text.Contains(","))
                {
                    TxTBox_Revisao.Text = TxTBox_Revisao.Text.Replace(",", ".");
                }
                if (TxTBox_KmTrocadeOloe.Text.Contains(","))
                {
                    TxTBox_KmTrocadeOloe.Text = TxTBox_KmTrocadeOloe.Text.Replace(",", ".");
                }

                Veiculo.Marca = TxTBox_Marca.Text;
                Veiculo.Placa = TxTBox_Placa.Text;
                Veiculo.Ano = Convert.ToInt32(TxTBox_Ano.Text);
                Veiculo.ID_Combustivel = Convert.ToInt32(TxTBox_Combustivel.Text);
                Veiculo.KM_Litro = float.Parse(TxTBox_KmLitro.Text);
                Veiculo.KM_TrocaPneu = float.Parse(TxTBox_KmPneu.Text);
                Veiculo.Capacidade_Tanque = float.Parse(TxTBox_CapDoTanque.Text);
                Veiculo.Chassi = TxTBox_Chassi.Text;
                Veiculo.Renavam = Convert.ToInt32(TxTBox_Renavan.Text);
                Veiculo.KM_Revisao = float.Parse(TxTBox_Revisao.Text);
                Veiculo.KM_TrocaOleo = float.Parse(TxTBox_KmTrocadeOloe.Text);
                Veiculo.Tipo = TxTBox_Tipo.Text;
                Veiculo.Modelo = TxTBox_Modelo.Text;

                if (Incluir.Veiculo(Veiculo, 1))
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


using PIM_4_PERIODO.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro
{
    public partial class Tela_Destino : Form
    {
        Model.Destino Destino = new Model.Destino();
        Dao.Incluir Incluir = new Dao.Incluir();
        public Tela_Destino()
        {
            InitializeComponent();
        }

        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroOleo_Label.Location.Y + Error_Label.Height + CadastroOleo_Label.Height + 5);
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
            if (TxTBox_Motorista.Text != "" && TxTBox_Email_Destino.Text != "" && TxTBox_Local_Chegada.Text != "" && TxTBox_Saida.Text != ""
                 && TxTBox_Data_chegada.Text != "" && TxTBox_Data_Saida.Text != "")
            {
                if (TxTBox_Data_Saida.Text.Contains(","))
                {
                    TxTBox_Data_Saida.Text = TxTBox_Data_Saida.Text.Replace(",", ".");
                }
                if (TxTBox_Data_chegada.Text.Contains(","))
                {
                    TxTBox_Data_chegada.Text = TxTBox_Data_chegada.Text.Replace(",", ".");
                }

                Destino.Local_Chegada = TxTBox_Local_Chegada.Text;
                Destino.Local_Saida = TxTBox_Saida.Text;
                Destino.Data_Chegada = Convert.ToDateTime(TxTBox_Data_chegada.Text);
                Destino.Data_Saida = Convert.ToDateTime(TxTBox_Data_Saida.Text);
                

                if (Incluir.Destino(Destino, 1))
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
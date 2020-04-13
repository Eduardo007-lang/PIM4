using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Combustivel
{
    public partial class Tela_Combustivel : Form
    {
        Model.Combustivel Combustivel = new Model.Combustivel();
        Dao.Incluir Incluir = new Dao.Incluir();

        public Tela_Combustivel()
        {
            InitializeComponent();
        }
        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroCombustivel_Label.Location.Y + Error_Label.Height + CadastroCombustivel_Label.Height + 5);
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
            if (TxTBox_Data.Text != "" && TxTBox_Nome.Text != "" && TxTBox_Valor.Text != "")
            {
                if (TxTBox_Valor.Text.Contains(","))
                {
                    TxTBox_Valor.Text = TxTBox_Valor.Text.Replace(",", ".");
                }


                Combustivel.Nome = TxTBox_Nome.Text;
                Combustivel.Valor = float.Parse(TxTBox_Valor.Text);
               // Combustivel.Data = Convert.ToDateTime(TxTBox_Data.Text);
                

                if (Incluir.Combustivel(Combustivel, 1))
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

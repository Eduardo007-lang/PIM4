using PIM_4_PERIODO.Model;
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
    public partial class Tela_Departamento : Form
    {
        Departamento departamento = new Departamento();
        Dao.Incluir Incluir = new Dao.Incluir();
        public Tela_Departamento()
        {
            InitializeComponent();
        }
        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), Sucesso_Label.Location.Y + Error_Label.Height + Error_Label.Height + 5);
        }

        private void Cadastrar_Btn_Click(object sender, EventArgs e)
        {

            if (TxTBox_Nivel_Departamento.Text != "" && TxTBox_Nome_Departamento.Text != "")
            {

                departamento.Nome = TxTBox_Nome_Departamento.Text;
                departamento.NivelAcesso = Convert.ToInt16(TxTBox_Nivel_Departamento.Text);


                if (Incluir.Departamento(departamento, 2))
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

        private void Bnt_Cancelar_Click(object sender, EventArgs e)
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
    }
  }


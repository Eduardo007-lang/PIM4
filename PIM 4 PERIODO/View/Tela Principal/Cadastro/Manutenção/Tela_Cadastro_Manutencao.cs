using PIM_4_PERIODO.View.__Tela_Principal__.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.Tela_Principal.Cadastro.Manutenção
{
    public partial class Tela_Cadastro_Manutencao : Form
    {
        Dao.Incluir Incluir = new Dao.Incluir();
        Model.Manutenção Manutenção = new Model.Manutenção();
        public Tela_Cadastro_Manutencao()
        {
            InitializeComponent();
            GenerateNumOs();
        }

        private int RandomNum()
        {
            Random r = new Random();
            int rInt = r.Next(0, 100); //for ints
            int range = 100;
            double rDouble = r.NextDouble() * range; //for doubles
            return Convert.ToInt32(rDouble);
        }
        private void GenerateNumOs()
        {
            Dao.Consultar Consulta = new Dao.Consultar();
            Manutenção.NumeroOS = Convert.ToInt32(RandomNum());
            Label_NumeroOS.Text = "Numero da Ordem de Serviço: " + Convert.ToString(Manutenção.NumeroOS);

            while (Consulta.Manutenção(Manutenção, 1).Rows.Count != 0)
            {
                Manutenção.NumeroOS = Convert.ToInt32(RandomNum());
                if(Consulta.Manutenção(Manutenção, 1).Rows.Count == 0)
                {
                    Label_NumeroOS.Text = Convert.ToString(Manutenção.NumeroOS);
                    break;
                }
            }
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
            if (TxTBox_Motivo_Manutecao.Text != "" && TxTBox_Nome.Text != "" && TxTBox_Valor_Manutencao.Text != "")
            {
                if (TxTBox_Valor_Manutencao.Text.Contains(","))
                {
                    TxTBox_Valor_Manutencao.Text = TxTBox_Valor_Manutencao.Text.Replace(",", ".");
                }

                Manutenção.ID_Oficina = Convert.ToInt32(TxTBox_ID_Oficina.Text);
                Manutenção.ID_Veiculo = Convert.ToInt32(TxTBox_ID_Oficina.Text);
                Manutenção.Valor = float.Parse(TxTBox_Valor_Manutencao.Text);
                Manutenção.Motivo = TxTBox_Motivo_Manutecao.Text;
                Manutenção.Data_Entrada = Convert.ToDateTime(TxTBox_Data_Entrada.Text);
                Manutenção.Data_Saida = Convert.ToDateTime(TxTBox_Data_Saida.Text);

                if (Incluir.Manutenção(Manutenção, 1))
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

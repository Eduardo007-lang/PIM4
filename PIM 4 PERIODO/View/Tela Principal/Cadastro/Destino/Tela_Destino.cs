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
    public partial class Tela_Destino : Form
    {
        private Dao.Incluir Incluir = new Dao.Incluir();
        private Dao.Consultar Consultar = new Dao.Consultar();
        private Destino Destino = new Destino();

        private DataTable VeiculosDicionary = new DataTable();
        private DataTable MotoristasDicionary = new DataTable();



        public Tela_Destino()
        {
            VeiculosDicionary.Columns.Add("ID",typeof(int));
            VeiculosDicionary.Columns.Add("Item",typeof(string));

            MotoristasDicionary.Columns.Add("ID", typeof(int));
            MotoristasDicionary.Columns.Add("Item", typeof(string));


            

            InitializeComponent();
            LoadMotoristas();
            LoadVeiculos();

        }
        private void LoadMotoristas()
        {
            DataTable Table_Deparatemnto = new DataTable();
            DataTable Table_Motoristas = new DataTable();
            Departamento Departamento = new Departamento();
            Model.Usuario Usuario = new Model.Usuario();

            int DepartamentoMotorista = 0;
            Table_Deparatemnto = Consultar.Departamento(Departamento, 3);
            for (int i = Table_Deparatemnto.Rows.Count - 1; i >= 0; i--)
            {
                if(Table_Deparatemnto.Rows[i][2].ToString() == "Motorista")
                {
                    DepartamentoMotorista = Convert.ToInt32(Table_Deparatemnto.Rows[i][0]);
                }
            }

            Table_Motoristas = Consultar.Usuario(Usuario, 8);
            for (int i = Table_Motoristas.Rows.Count - 1, j = 0; i >= 0; i--)
            { 
                if(Convert.ToInt32(Table_Motoristas.Rows[i][3]) == 3)
                {
                    ComboBox_Motorista.Items.Insert(j, Table_Motoristas.Rows[i][1]);

                    DataRow NovaLinha = MotoristasDicionary.NewRow();
                    NovaLinha["ID"] = MotoristasDicionary.Rows[i][0];
                    NovaLinha["Item"] = MotoristasDicionary.Rows[i][1];
                    MotoristasDicionary.Rows.InsertAt(NovaLinha, j);

                    j++;
                }
            }
            ComboBox_Motorista.SelectedItem = 0;

        }
        private void LoadVeiculos()
        {
            DataTable Table_Veiculos = new DataTable();
            Model.Veiculo Veiculo = new Model.Veiculo();

            Table_Veiculos = Consultar.Veiculo(Veiculo, 9);
            for(int i = Table_Veiculos.Rows.Count - 1, j = 0 ; i >= 0; i--, j++)
            {
                DataRow NovaLinha = VeiculosDicionary.NewRow();
                NovaLinha["ID"] = Table_Veiculos.Rows[i][0];
                NovaLinha["Item"] = Table_Veiculos.Rows[i][2];
                VeiculosDicionary.Rows.InsertAt(NovaLinha, j);

                ComboBox_Veiculo.Items.Insert(j, Convert.ToString(Table_Veiculos.Rows[j][2]));

                Console.WriteLine("Combox Veiculo: " + j + " | " + Table_Veiculos.Rows[j][2]);
                Console.WriteLine("Dicionario Veiculo: " + Table_Veiculos.Rows[j][0] + " | " + Table_Veiculos.Rows[j][2]);
            }
            ComboBox_Veiculo.SelectedItem = 0;
        }
        
        private bool Convert_VeiculoFrom_Combo()
        {
            bool Retorno = false;
            for(int i = VeiculosDicionary.Rows.Count; i >= 0; i--)
            {
                Console.WriteLine("Veiculo");
                Console.WriteLine("Item selecionado: " + ComboBox_Veiculo.SelectedItem + " | ID Selecionado: " + ComboBox_Veiculo.SelectedIndex);

                if (ComboBox_Veiculo.SelectedItem == Convert.ToString(VeiculosDicionary.Rows[i][1]))
                {
                    Destino.ID_Veiculo = Convert.ToInt32(VeiculosDicionary.Rows[i][0]);
                    Retorno = true;
                }
            }
            return Retorno;
        }
        private bool Convert_MotoristaFrom_Combo()
        {
            bool Retorno = false;
            for (int i = MotoristasDicionary.Rows.Count; i >= 0; i--)
            {
                Console.WriteLine("Motorista");
                Console.WriteLine("Item selecionado: " + ComboBox_Motorista.SelectedItem + " | ID Selecionado: " + ComboBox_Motorista.SelectedIndex);
                if (ComboBox_Motorista.SelectedItem == MotoristasDicionary.Rows[i][1])
                {
                    Destino.ID_Motorista = Convert.ToInt32(MotoristasDicionary.Rows[i][0]);
                    Retorno = true;
                }
            }
            return Retorno;
        }

        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroDestino_Label.Location.Y + Error_Label.Height + CadastroDestino_Label.Height + 5);
        }
        private void Cadastrar_Btn_Click(object sender, EventArgs e) 
        {
            if (TxTBox_Saida.Text != "" && TxTBox_Local_Chegada.Text != "" && TxTBox_Data_Saida.Text != "" && TxTBox_Data_Chegada.Text != "")
            {
                if (Convert_VeiculoFrom_Combo() && Convert_MotoristaFrom_Combo())
                {
                    Destino.Local_Saida = TxTBox_Saida.Text;
                    Destino.Local_Chegada = TxTBox_Local_Chegada.Text;
                    Destino.Data_Chegada = Convert.ToDateTime(TxTBox_Data_Chegada.Text);
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
                    Error_Label.Text = "Ocorreu um erro com Motorista/Veiculo";
                    Repoisicionamento_Label(Error_Label);
                }
            }
            else
            {
                Error_Label.Text = "Os campos não podem ser vazios";
                Repoisicionamento_Label(Error_Label);
            } 
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
    }
}

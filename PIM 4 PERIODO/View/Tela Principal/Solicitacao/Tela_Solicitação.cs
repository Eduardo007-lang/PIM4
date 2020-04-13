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

namespace PIM_4_PERIODO.View.Tela_Principal.Solicitacao
{
    public partial class Tela_Solicitação : Form
    {
        DataTable Table_TabelasDoBanco = new DataTable();
        DataTable Table_Consulta = new DataTable();
        Consultar Consultar = new Consultar();

        public Tela_Solicitação()
        {
            InitializeComponent();
            LoadTabelas();

            //Remove o Chat
            ComboBox_Tabelas.Items.RemoveAt(2);
        }
        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input)) 
            { 
                throw new ArgumentException("String não pode ser vazia");
            }
            else
            {
                input = input.ToLower();
            }
            return input.First().ToString().ToUpper() + String.Join("", input.Skip(1));
        }
        private void LoadTabelas()
        {
            Table_TabelasDoBanco = Consultar.TabelasDoBanco();
            for (int i = Table_TabelasDoBanco.Rows.Count - 1, j = 0; i >= 0; i--, j++)
            {
                string Nome = "";
                if (Table_TabelasDoBanco.Rows[j][0] != "")
                {
                    Nome = FirstCharToUpper(Convert.ToString(Table_TabelasDoBanco.Rows[j][0]));
                    ComboBox_Tabelas.Items.Insert(j, Nome);
                    Console.WriteLine("Tabela: " + Nome);
                }                
            }
        }
        private void LoadColumName()
        {
            if (Table_Consulta.Rows.Count > 0)
            {
                ComboBox_TipoBusca.SelectedItem = "";
                ComboBox_TipoBusca.Items.Clear();
                //Table_Consulta.Columns.Remove(Table_Consulta.Columns[0]);
                foreach (DataColumn column in Table_Consulta.Columns)
                { 
                    string Nome = "";
                    
                    Nome = FirstCharToUpper(Convert.ToString(column.ColumnName));
                    if (Name.Contains("_"))
                    {
                        Nome = Nome.Replace("_", " ");
                    }

                    Nome = FirstCharToUpper(Convert.ToString(Nome));
                    ComboBox_TipoBusca.Items.Add(Nome);
                    Console.Write("Item: " + column.ColumnName);
                }
                ComboBox_TipoBusca.SelectedItem = ComboBox_TipoBusca.Items[0];
            }
            else
            {
                ComboBox_TipoBusca.Items.Clear();
                ComboBox_TipoBusca.SelectedItem = "";
            }

        }


        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), Solicitação_Label.Location.Y + Error_Label.Height + Solicitação_Label.Height + 5);
        }
        private void ComboBox_Tabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectConsulta(ComboBox_Tabelas);
            LoadColumName();
            Console.WriteLine("ID: " + (ComboBox_Tabelas.SelectedIndex + 1) + " | Solicitação:" + ComboBox_Tabelas.SelectedItem);
        }

        private Consultar SelectConsulta(ComboBox ComboBoxi)
        {
            int i = ComboBoxi.SelectedIndex + 1;
            switch(i)
            {
                case 1:
                    Abastecimento Abastecimento = new Abastecimento();
                    Table_Consulta = Consultar.Abastecimento(Abastecimento, 4);
                    break;
                case 2:
                    Atendimento Atendimento = new Atendimento();
                    Table_Consulta = Consultar.Atendimento(Atendimento, 4);
                    break;
                case 3:
                    Combustivel Combustivel = new Combustivel();
                    Table_Consulta = Consultar.Combustivel(Combustivel, 4);
                    break;
                case 4:
                    Departamento Departamento = new Departamento();
                    Table_Consulta = Consultar.Departamento(Departamento, 3);
                    break;
                case 5:
                    Destino Destino = new Destino();
                    Table_Consulta = Consultar.Destino(Destino, 5);
                    break;
                case 6:
                    Manutenção Manutenção = new Manutenção();
                    Table_Consulta = Consultar.Manutenção(Manutenção, 5);
                    break;
                case 7:
                    Multa Multa = new Multa();
                    Table_Consulta = Consultar.Multa(Multa, 6);
                    break;
                case 8:
                    Notificação Notificação = new Notificação();
                    Table_Consulta = Consultar.Notificação(Notificação, 2);
                    break;
                case 9:
                    Oficina Oficina = new Oficina();
                    Table_Consulta = Consultar.Oficina(Oficina, 2);
                    break;
                case 10:
                    Oleo Oleo = new Oleo();
                    Table_Consulta = Consultar.Oleo(Oleo, 4);
                    break;
                case 11:
                    Posto Posto = new Posto();
                    Table_Consulta = Consultar.Posto(Posto, 5);
                    break;
                case 12:
                    Salario Salario = new Salario();
                    Table_Consulta = Consultar.Salario(Salario, 2);
                    break;
                case 13:
                    Usuario Usuario = new Usuario();
                    Table_Consulta = Consultar.Usuario(Usuario, 8);
                    break;
                case 14:
                    Veiculo Veiculo = new Veiculo();
                    Table_Consulta = Consultar.Veiculo(Veiculo, 9);
                    break;
            }
            return Consultar;
        }
        private void Pesquisar_Btn_Click(object sender, EventArgs e)
        {
            if(TxTBox_Pesquisa.Text != "")
            {
                int i = ComboBox_Tabelas.SelectedIndex + 1;
                int j = ComboBox_TipoBusca.SelectedIndex + 3;
                int TipoDaPesquisa = 0;

                switch (i)
                {
                    case 1:
                        Abastecimento Abastecimento = new Abastecimento();
                        switch (j)
                        {
                            case 1:
                                TipoDaPesquisa = 4;
                                break;
                            case 2:
                                TipoDaPesquisa = 5;
                                break;
                            case 3:
                                TipoDaPesquisa = 0;
                                break;
                            case 4:
                                TipoDaPesquisa = 1;
                                break;
                            case 5:
                                TipoDaPesquisa = 2;
                                break;
                            case 6:
                                TipoDaPesquisa = 3;
                                break;
                        }
                        Consultar.Abastecimento(Abastecimento, TipoDaPesquisa);
                        break;
                    case 2:
                        Atendimento Atendimento = new Atendimento();
                        switch (j)
                        {
                            case 1:
                                TipoDaPesquisa = 1;
                                break;
                            case 2:
                                TipoDaPesquisa = 2;
                                break;
                            case 3:
                                TipoDaPesquisa = 3;
                                break;
                        }
                        Consultar.Atendimento(Atendimento, TipoDaPesquisa);
                        break;
                    case 3:
                        Combustivel Combustivel = new Combustivel();
                        switch (j)
                        {
                            case 1:
                                TipoDaPesquisa = 0;
                                break;
                            case 2:
                                TipoDaPesquisa = 1;
                                break;
                            case 3:
                                TipoDaPesquisa = 2;
                                break;
                            case 4:
                                TipoDaPesquisa = 3;
                                break;
                        }
                        Consultar.Combustivel(Combustivel, TipoDaPesquisa);
                        break;
                    case 4:
                        Departamento Departamento = new Departamento();
                        switch (j)
                        {
                            case 1:
                                TipoDaPesquisa = 0;
                                break;
                            case 2:
                                TipoDaPesquisa = 1;
                                break;
                            case 3:
                                TipoDaPesquisa = 2;
                                break;
                        }
                        Consultar.Departamento(Departamento, TipoDaPesquisa);
                        break;
                    case 5:
                        Destino Destino = new Destino();
                        switch (j)
                        {
                            case 0:
                                TipoDaPesquisa = 0;
                                break;
                            case 1:
                                TipoDaPesquisa = 1;
                                break;
                            case 2:
                                TipoDaPesquisa = 2;
                                break;
                            case 3:
                                TipoDaPesquisa = 3;
                                break;
                            case 4:
                                TipoDaPesquisa = 4;
                                break;
                        }
                        Consultar.Destino(Destino, TipoDaPesquisa);
                        break;
                    case 6:
                        Manutenção Manutenção = new Manutenção();
                        switch (j)
                        {
                            case 0:
                                TipoDaPesquisa = 0;
                                break;
                            case 1:
                                TipoDaPesquisa = 1;
                                break;
                            case 2:
                                TipoDaPesquisa = 2;
                                break;
                            case 3:
                                TipoDaPesquisa = 3;
                                break;
                            case 4:
                                TipoDaPesquisa = 4;
                                break;
                        }
                        Consultar.Manutenção(Manutenção, TipoDaPesquisa);
                        break;
                    case 7:
                        Multa Multa = new Multa();
                        Consultar.Multa(Multa, 6);
                        break;
                    case 8:
                        Notificação Notificação = new Notificação();
                        Consultar.Notificação(Notificação, 2);
                        break;
                    case 9:
                        Oficina Oficina = new Oficina();
                        Consultar.Oficina(Oficina, 2);
                        break;
                    case 10:
                        Oleo Oleo = new Oleo();
                        Consultar.Oleo(Oleo, 4);
                        break;
                    case 11:
                        Posto Posto = new Posto();
                        Consultar.Posto(Posto, 5);
                        break;
                    case 12:
                        Salario Salario = new Salario();
                        Consultar.Salario(Salario, 2);
                        break;
                    case 13:
                        Usuario Usuario = new Usuario();
                        Consultar.Usuario(Usuario, 8);
                        break;
                    case 14:
                        Veiculo Veiculo = new Veiculo();
                        Consultar.Veiculo(Veiculo, 9);
                        break;
                }

                Console.WriteLine("Index da Tabela " + i + "Index da Pesquisa " + ComboBox_TipoBusca.SelectedIndex);
                Console.WriteLine("Nome da Tabela " + ComboBox_Tabelas.SelectedItem + "Tipo da Pesquisa " + ComboBox_TipoBusca.SelectedItem);
                if (!true)
                {
                    Repoisicionamento_Label(Sucesso_Label);
                }
                else
                {
                    Error_Label.Text = "Ocorreu um erro durante a pesquisa";
                    Repoisicionamento_Label(Error_Label);
                }
            }
            else
            {
                Error_Label.Text = "Os campos não podem ser vazios";
                Repoisicionamento_Label(Error_Label);
            }
        }

        private void ComboBox_TipoBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxTBox_Pesquisa.Enabled = false;
            TxTBox_Pesquisa.Text = "";
            if (ComboBox_TipoBusca.SelectedItem.ToString().Contains("Id_"))
            {
               TxTBox_Pesquisa.HintText = ComboBox_TipoBusca.SelectedItem.ToString().Replace("Id_", "ID ");
            }
            else
            {
                TxTBox_Pesquisa.HintText = ComboBox_TipoBusca.SelectedItem.ToString();
            }
            TxTBox_Pesquisa.Enabled = true;
        }

        private void TxTBox_Pesquisa_Leave(object sender, EventArgs e)
        {
            if (TxTBox_Pesquisa.Text != "")
            {
                Pesquisar_Btn.Enabled = true;
            }
            else
            {
                Pesquisar_Btn.Enabled = false;
            }
        }   
    }
}

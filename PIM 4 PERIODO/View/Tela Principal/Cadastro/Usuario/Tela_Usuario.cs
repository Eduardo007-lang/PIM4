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

namespace PIM_4_PERIODO.View.__Tela_Principal__.Cadastro.Usuario
{
    public partial class Tela_Usuario : Form
    {
        DataTable Table = new DataTable();
        Model.Usuario Usuario = new Model.Usuario();
        Model.Departamento Departamento = new Model.Departamento();
        Dao.Incluir Incluir = new Dao.Incluir();
        Dao.Consultar Conslutar = new Dao.Consultar();


        public Tela_Usuario()
        {
            InitializeComponent();
            LoadDepartamentos();
        }
        private void LoadDepartamentos()
        {
            Table = Conslutar.Departamento(Departamento, 3);
            for (int i = Table.Rows.Count - 1 , j = 0; i >= 0 ; i--, j++)
            {
                ComboBox_Departamentos.Items.Insert(j, Table.Rows[j][2]);
                //ComboBox_Departamentos.Items.Add(Table.Rows[j][2]);
                Console.WriteLine("ID: " + Table.Rows[j][0] + ", Deparatamento: " + Table.Rows[j][2]);

            }
        }
        private void Repoisicionamento_Label(Label Error_Label)
        {
            Error_Label.Visible = true;
            int PanelImg_Center = (this.Size.Width - Error_Label.Size.Width) / 2;
            Error_Label.Location = new Point((this.Width / 2) - (Error_Label.Width / 2), CadastroUsuario_Label.Location.Y + Error_Label.Height + CadastroUsuario_Label.Height + 5);
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
            if(TxTBox_UserName.Text != "" && TxTBox_Nome.Text != "" &&
                TxTBox_Senha.Text != "" && TxTBox_Email.Text != "" &&
                TxTBox_CPF.Text != "" && TxTBox_CNH.Text != "" &&
                TextBox_Validade_CNH.Text != "" 
                && TxTBox_CategoriaCNH.Text != "" &&
                TxTBox_ENDERECO.Text != "" && TxTBox_Data.Text != "" && TxTBox_Telefone.Text != "" && TxTBox_Celular.Text !="")
            {
                Usuario.Username = TxTBox_UserName.Text;
                Usuario.Nome = TxTBox_Nome.Text;
                Usuario.Senha = TxTBox_Senha.Text;
                Usuario.Email = TxTBox_Email.Text;
                Usuario.CPF = TxTBox_CPF.Text;
                Usuario.CNH = Convert.ToInt32(TxTBox_CNH.Text);
                Usuario.Telefone = Convert.ToInt32(TxTBox_Telefone.Text);
                Usuario.Data_Adimissao = Convert.ToDateTime(TxTBox_Data.Text);
                Usuario.Validade_CNH = Convert.ToDateTime(TextBox_Validade_CNH.Text);
                Usuario.Celular = Convert.ToInt32(TxTBox_Celular.Text);
                Usuario.Categoria_CNH = TxTBox_CategoriaCNH.Text;
                Usuario.Endereço = TxTBox_ENDERECO.Text;


                if (Incluir.Usuario(Usuario, 1))
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

        private void ComboBox_Departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario.Departamento = (ComboBox_Departamentos.SelectedIndex + 1);
            Console.WriteLine("ID: " + (ComboBox_Departamentos.SelectedIndex + 1) + " | Deparamtento:" + ComboBox_Departamentos.SelectedItem);
        }

        //Text Box Data
        private void TxTBox_Data_Enter(object sender, EventArgs e)
        {
            Label_DataAdimissao.ForeColor = Color.FromArgb(11, 184, 204);
            TxTBox_Data.ForeColor = Color.Silver;
        }
        private void TxTBox_Data_Leave(object sender, EventArgs e)
        {
            Label_DataAdimissao.ForeColor = Color.FromArgb(9, 154, 171);
            TxTBox_Data.ForeColor = Color.FromArgb(11, 184, 204);
        }

        //ComboBox Departamentos
        private void ComboBox_Departamentos_Enter(object sender, EventArgs e)
        {
            ComboBox_Departamentos.ForeColor = Color.Silver;
        }
        private void ComboBox_Departamentos_Leave(object sender, EventArgs e)
        {
            ComboBox_Departamentos.ForeColor = Color.FromArgb(11, 184, 204);
        }

        //Text Box CPF
        private void TxTBox_CPF_Enter(object sender, EventArgs e)
        {
            Label_CPF.ForeColor = Color.FromArgb(11, 184, 204);
            TxTBox_CPF.ForeColor = Color.Silver;
        }
        private void TxTBox_CPF_Leave(object sender, EventArgs e)
        {
            Label_CPF.ForeColor = Color.FromArgb(9, 154, 171);
            TxTBox_CPF.ForeColor = Color.FromArgb(11, 184, 204);
        }

        //Text Box Telefone
        private void TxTBox_Telefone_Enter(object sender, EventArgs e)
        {
            Label_Telefone.ForeColor = Color.FromArgb(11, 184, 204);
            TxTBox_Telefone.ForeColor = Color.Silver;
        }
        private void TxTBox_Telefone_Leave(object sender, EventArgs e)
        {
            Label_Telefone.ForeColor = Color.FromArgb(9, 154, 171);
            TxTBox_Telefone.ForeColor = Color.FromArgb(11, 184, 204);
        }

        //Text Box Celular
        private void TxTBox_Celular_Enter(object sender, EventArgs e)
        {
            Label_Celular.ForeColor = Color.FromArgb(11, 184, 204);
            TxTBox_Celular.ForeColor = Color.Silver;
        }
        private void TxTBox_Celular_Leave(object sender, EventArgs e)
        {
            Label_Celular.ForeColor = Color.FromArgb(9, 154, 171);
            TxTBox_Celular.ForeColor = Color.FromArgb(11, 184, 204);
        }

        //Text Box Validade
        private void TextBox_Validade_CNH_Enter(object sender, EventArgs e)
        {
            TextBox_Validade_CNH.ForeColor = Color.Silver;
            Label_ValidadeCNH.ForeColor = Color.FromArgb(11, 184, 204);
        }
        private void TextBox_Validade_CNH_Leave(object sender, EventArgs e)
        {
            TextBox_Validade_CNH.ForeColor = Color.FromArgb(11, 184, 204);
            Label_ValidadeCNH.ForeColor = Color.FromArgb(9, 154, 171);
        }

        //Text Box Categoria da CNH
        private void TxTBox_CategoriaCNH_Enter(object sender, EventArgs e)
        {
            TxTBox_CategoriaCNH.ForeColor = Color.Silver;
            Label_CategoriaCNH.ForeColor = Color.FromArgb(11, 184, 204);
        }
        private void TxTBox_CategoriaCNH_Leave(object sender, EventArgs e)
        {
            TxTBox_CategoriaCNH.ForeColor = Color.FromArgb(11, 184, 204);
            Label_CategoriaCNH.ForeColor = Color.FromArgb(9, 154, 171);
        }

        //Only Number CNH
        private void TxTBox_CNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

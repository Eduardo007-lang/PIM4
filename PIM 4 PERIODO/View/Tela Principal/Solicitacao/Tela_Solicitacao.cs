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

namespace PIM_4_PERIODO.View.__Tela_Principal__.Solicitacao
{
    public partial class Tela_Solicitacao : Form
    {
        
        public Tela_Solicitacao()
        {
            InitializeComponent();
        }
        private void Vai_Btn_Click(object sender, EventArgs e)
        {
            if (TxTBox_NomeUsuario.Text != "")
            {
                Consultar Consultar = new Consultar();
                Usuario Usuario = new Usuario();
                Usuario.Username = TxTBox_NomeUsuario.Text;
                Usuario_DataGridView.DataSource = Consultar.Usuario(Usuario, 0);


                Console.WriteLine(Usuario_DataGridView.SelectedRows.ToString());
            }

        }

        private void TxTBox_NomeUsuario_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_4_PERIODO.View.__Tela_Principal__.Saida_de_Veiculo
{
    public partial class telaSaidadeVeiculo : Form
    {

        public telaSaidadeVeiculo()
        {
            InitializeComponent();
        }


        private void Bnt_Salvar_Departamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veículo Retirado com sucesso");

        }
      
    }
}

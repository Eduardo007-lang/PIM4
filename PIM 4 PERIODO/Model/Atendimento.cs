using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Atendimento
    {
        private int id_Atendimento;
        private int id_Destino;
        private int id_Veiculo;
        private int id_Motorista;


        public int ID_Atendimento { get => id_Atendimento; set => id_Atendimento = value; }
        public int ID_Destino { get => id_Destino; set => id_Destino = value; }
        public int ID_Veiculo { get => id_Veiculo; set => id_Veiculo = value; }
        public int ID_Motorista { get => id_Motorista; set => id_Motorista = value; }

    }
}

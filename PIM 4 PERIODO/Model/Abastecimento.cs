using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Abastecimento
    {

        private DateTime data;
        private int id_Abastecimento;
        private int id_Posto;
        private int id_Veiculo;
        private float Km_Abastecimento;
        private float valor;
        private float litros;


        public DateTime Data { get => data; set => data = value; }
        public int ID_Posto { get => id_Posto; set => id_Posto = value; }
        public int ID_Veiculo { get => id_Veiculo; set => id_Veiculo = value; }
        public int ID_bastecimento { get => id_Abastecimento; set => id_Abastecimento = value; }
        public float Valor { get => valor; set => valor = value; }
        public float Litros { get => litros; set => litros = value; }
        public float Km_No_Abastecimento { get => Km_Abastecimento; set => Km_Abastecimento = value; }

    }
}

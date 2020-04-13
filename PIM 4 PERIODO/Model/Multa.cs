using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Multa
    {
        private DateTime data;
        private string tipo_Infração;
        private string endereço;
        private int id_Multa;
        private int num_infração;
        private int id_Motorista;
        private int id_Veiculo;
        private float valor;



        public DateTime Data { get => data; set => data = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string Tipo { get => tipo_Infração; set => tipo_Infração = value; }
        public int ID_Multa { get => id_Multa; set => id_Multa = value; }
        public int Infração { get => num_infração; set => num_infração = value; }
        public int Motorista { get => id_Motorista; set => id_Motorista = value; }
        public int Veiculo { get => id_Veiculo; set => id_Veiculo = value; }
        public float Valor { get => valor; set => valor = value; }
 
    }
}

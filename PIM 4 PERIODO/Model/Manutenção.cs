using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Manutenção
    {
        private DateTime data_entrada;
        private DateTime data_saida;
        private string motivo;
        private int numeroOS;
        private int id_Veiculo;
        private int id_Oficina;
        private int id_Manutencao;
        private float valor;


        public DateTime Data_Entrada { get => data_entrada; set => data_entrada = value; }
        public DateTime Data_Saida { get => data_saida; set => data_saida = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public int NumeroOS { get => numeroOS; set => numeroOS = value; }
        public int ID_Veiculo { get => id_Veiculo; set => id_Veiculo = value; }
        public int ID_Oficina { get => id_Oficina; set => id_Oficina = value; }
        public int ID_Manutencao { get => id_Manutencao; set => id_Manutencao = value; }
        public float Valor { get => valor; set => valor = value; }
  
    }
}

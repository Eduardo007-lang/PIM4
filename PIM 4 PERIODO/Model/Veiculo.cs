using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Veiculo
    {
        private int ano;
        private string modelo;
        private string marca;
        private string placa;
        private string tipo;
        private string chassi_num;
        private int id_Combustivel;
        private int id_Veiculo;
        private int id_Oleo;
        private int renavam;
        private float KM_litro;
        private float KM_revisao;
        private float KM_trocaOleo;
        private float KM_trocaPneu;
        private float capacidade_Tanque;



        public int Ano { get => ano; set => ano = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Chassi { get => chassi_num; set => chassi_num = value; }
        public int ID_Combustivel { get => id_Combustivel; set => id_Combustivel = value; }
        public int ID_Veiculo { get => id_Veiculo; set => id_Veiculo = value; }
        public int ID_Oleo { get => id_Oleo; set => id_Oleo = value; }
        public int Renavam { get => renavam; set => renavam = value; }
        public float KM_Litro { get => KM_litro; set => KM_litro = value; }
        public float KM_Revisao { get => KM_revisao; set => KM_revisao = value; }
        public float KM_TrocaOleo { get => KM_trocaOleo; set => KM_trocaOleo = value; }
        public float KM_TrocaPneu { get => KM_trocaPneu; set => KM_trocaPneu = value; }
        public float Capacidade_Tanque { get => capacidade_Tanque; set => capacidade_Tanque = value; }

        

    }
   
}

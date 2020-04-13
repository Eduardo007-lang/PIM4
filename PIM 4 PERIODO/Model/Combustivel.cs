using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Combustivel
    {
        private DateTime data;
        private string nome;
        private int id_Combustivel;
        private float valor;


        public DateTime Data { get => data; set => data = value; }
        public string Nome { get => nome; set => nome = value; }
        public int ID_Combustivel { get => id_Combustivel; set => id_Combustivel = value; }
        public float Valor { get => valor; set => valor = value; }

    }
}

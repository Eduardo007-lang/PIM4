using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Oleo
    {
        private string nome;
        private string marca;
        private int id_Oleo;
        private float litros;


        public string Nome { get => nome; set => nome = value; }
        public string Marca { get => marca; set => marca = value; }
        public int ID_Oleo { get => id_Oleo; set => id_Oleo = value; }
        public float Litros { get => litros; set => litros = value; }

    }
}

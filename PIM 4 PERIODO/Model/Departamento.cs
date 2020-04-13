using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Departamento
    {
        private string nome;
        private int departamento;
        private int nivelAcesso;


        public string Nome { get => nome; set => nome = value; }
        public int ID_Departamento { get => departamento; set => departamento = value; }
        public int NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }
        

    }
}

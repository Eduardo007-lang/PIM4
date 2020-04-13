using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Posto
    {
        private string razao_social;
        private string endereço;
        private string nome;
        private string cnpj;
        private int id_Posto;
        private int telefone;
        private int celular;


        public string RazaoSocial { get => razao_social; set => razao_social = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CNPJ { get => cnpj; set => cnpj = value; }
        public int ID_Posto { get => id_Posto; set => id_Posto = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public int Celular { get => celular; set => celular = value; }

    }
}

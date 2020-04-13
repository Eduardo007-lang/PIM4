using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Notificação
    {
        private string descrição;
        private string titulo;
        private string imagem;
        private int id_Departamento;
        private int id_Notificacao;


        public string Descrição { get => descrição; set => descrição = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Imagem { get => imagem; set => imagem = value; }
        public int ID_Departamento { get => id_Departamento; set => id_Departamento = value; }
        public int ID_Notificacao { get => id_Notificacao; set => id_Notificacao = value; }
 
    }
}

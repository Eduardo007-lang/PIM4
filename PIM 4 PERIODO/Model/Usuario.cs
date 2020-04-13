using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PIM_4_PERIODO.Model
{
    class Usuario
    {
        private DateTime data_Adimissao;
        private DateTime validade_cnh;
        private string username;
        private string senha;
        private int departamento;
        private string endereço;
        private string nome;
        private string email;
        private string cpf;
        private string categoria_cnh;
        private int id_Usuario; 
        private int telefone;
        private int celular;
        private int cnh;


        public DateTime Data_Adimissao { get => data_Adimissao; set => data_Adimissao = value; }
        public DateTime Validade_CNH { get => validade_cnh; set => validade_cnh = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string CPF { get => cpf; set => cpf = value; }
        public string Categoria_CNH { get => categoria_cnh; set => categoria_cnh = value; }
        public int Departamento { get => departamento; set => departamento = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Username { get => username; set => username = value; }
        public int ID_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public int Celular { get => celular; set => celular = value; }
        public int CNH { get => cnh; set => cnh = value; }
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PIM_4_PERIODO.Dao
{
    class Conexao
    {
        private MySqlConnection conexao = new MySqlConnection("server = remotemysql.com; port = 3306; User Id = UTJAG6N7YD; database = UTJAG6N7YD; password = iaJ8jMEJEY");


        public void Conectar()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
        }
        public void Desconectar()
        {
            try
            {
                if (conexao.State == System.Data.ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
            catch (SqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
        }
        public bool Checkconection()
        {
            bool retorno = false;
            try
            {
                if (conexao.State == ConnectionState.Open)
                {
                    retorno = true;
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return retorno;
        }
        public MySqlConnection Pega_Conexão()
        {
            return conexao;
        }

    }
}

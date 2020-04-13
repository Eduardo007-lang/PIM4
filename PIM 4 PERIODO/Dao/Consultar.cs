using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using PIM_4_PERIODO.Model;
using System.Windows.Forms;

namespace PIM_4_PERIODO.Dao
{
    class Consultar
    {
        private bool Login_Existe = false;
        public Conexao Conexão = new Conexao();

        DataTable TodasDoBanco = new DataTable();
        DataTable TableAbastecimento = new DataTable();
        DataTable TableAtendimento = new DataTable();
        DataTable TableCombustivel = new DataTable();
        DataTable TableDepartamento = new DataTable();
        DataTable TableDestino = new DataTable();
        DataTable TableManutenção = new DataTable();
        DataTable TableMulta = new DataTable();
        DataTable TableNotificação = new DataTable();
        DataTable TableOficina = new DataTable();
        DataTable TableOleo = new DataTable();
        DataTable TablePosto = new DataTable();
        DataTable TableSalario = new DataTable();
        DataTable TableUsuario = new DataTable();
        DataTable TableVeiculo = new DataTable();


        public bool Entra_Sistema(Login Login)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM USUARIO WHERE USERNAME = @usuario OR SENHA = @senha", Conexão.Pega_Conexão());

                    command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = Login.Usuario;
                    command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Login.Senha;
                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    //Verifica se há uma lina no banco com esse Usuário.
                    int retorno = command.ExecuteNonQuery();
                    if (table.Rows.Count > 0)
                    {
                        if (Convert.ToString(table.Rows[0][1]) == Login.Usuario && Convert.ToString(table.Rows[0][2]) == Login.Senha)
                        {
                            Login_Existe = true;
                        }
                    }
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Consulta");
            }
            return Login_Existe;
        }

        public DataTable TabelasDoBanco()
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaAbastecimento = "SHOW TABLES;";


                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    command.CommandText = ConsultaAbastecimento;
                    command.Connection = Conexão.Pega_Conexão();

                    adapter.SelectCommand = command;
                    adapter.Fill(TodasDoBanco);

                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Consulta");
            }

            return TodasDoBanco;
        }
        public DataTable Abastecimento(Abastecimento Abastecimento, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaAbastecimento = "SELECT * FROM ABASTECIMENTO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaAbastecimento = ConsultaAbastecimento + "ID_POSTO = @ID_POSTO";
                            break;
                        case 1:
                            ConsultaAbastecimento = ConsultaAbastecimento + "ID_VEICULO = @ID_VEICULO";
                            break;
                        case 2:
                            ConsultaAbastecimento = ConsultaAbastecimento + "DATAS = @DATAS";
                            break;
                        case 3:
                            ConsultaAbastecimento = ConsultaAbastecimento + "ID_ABASTECIMENTO = @ID_ABASTECIMENTO";
                            break;
                        case 4:
                            ConsultaAbastecimento = ConsultaAbastecimento + "LITROS = @LITROS";
                            break;
                        case 5:
                            ConsultaAbastecimento = ConsultaAbastecimento + "VALOR = @VALOR";
                            break;
                        case 6:
                            ConsultaAbastecimento = ConsultaAbastecimento + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaAbastecimento = ConsultaAbastecimento + ";";
                    command.CommandText = ConsultaAbastecimento;
                    command.Connection = Conexão.Pega_Conexão();


                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_POSTO", MySqlDbType.VarChar).Value = Abastecimento.ID_Posto;
                            break;
                        case 1:
                            command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Abastecimento.ID_Veiculo;
                            break;
                        case 2:
                            command.Parameters.Add("@DATAS", MySqlDbType.VarChar).Value = Abastecimento.Data;
                            break;
                        case 3:
                            command.Parameters.Add("@ID_ABASTECIMENTO", MySqlDbType.Int32).Value = Abastecimento.ID_bastecimento;
                            break;
                        case 4:
                            command.Parameters.Add("@LITROS", MySqlDbType.Int32).Value = Abastecimento.Litros;
                            break;
                        case 5:
                            command.Parameters.Add("@VALOR", MySqlDbType.Int32).Value = Abastecimento.Valor;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableAbastecimento);

                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Consulta");
            }

            return TableAbastecimento;
        }
        public DataTable Atendimento(Atendimento Atendimento, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaAtendimento = "SELECT * FROM ATENDIMENTO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaAtendimento = ConsultaAtendimento + "ID_ATENDIMENTO = @ID_ATENDIMENTO";
                            break;
                        case 1:
                            ConsultaAtendimento = ConsultaAtendimento + "ID_VEICULO = @ID_VEICULO";
                            break;
                        case 2:
                            ConsultaAtendimento = ConsultaAtendimento + "ID_MOTORISTA = @ID_MOTORISTA";
                            break;
                        case 3:
                            ConsultaAtendimento = ConsultaAtendimento + "ID_DESTINO = @ID_DESTINO";
                            break;
                        case 4:
                            ConsultaAtendimento = ConsultaAtendimento + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();


                    ConsultaAtendimento = ConsultaAtendimento + ";";
                    command.CommandText = ConsultaAtendimento;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_ATENDIMENTO", MySqlDbType.Int32).Value = Atendimento.ID_Atendimento;
                            break;
                        case 1:
                            command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Atendimento.ID_Veiculo;
                            break;
                        case 2:
                            command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Atendimento.ID_Motorista;
                            break;
                        case 3:
                            command.Parameters.Add("@ID_DESTINO", MySqlDbType.VarChar).Value = Atendimento.ID_Destino;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableAtendimento);

                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return TableAtendimento;
        }
        public DataTable Combustivel(Combustivel Combustivel, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaCombustivel = "SELECT * FROM COMBUSTIVEL WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaCombustivel = ConsultaCombustivel + "ID_COMBUSTIVEL = @ID_COMBUSTIVEL";
                            break;
                        case 1:
                            ConsultaCombustivel = ConsultaCombustivel + "NOME = @NOME";
                            break;
                        case 2:
                            ConsultaCombustivel = ConsultaCombustivel + "VALOR = @VALOR";
                            break;
                        case 3:
                            ConsultaCombustivel = ConsultaCombustivel + "DATAS = @DATAS";
                            break;
                        case 4:
                            ConsultaCombustivel = ConsultaCombustivel + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaCombustivel = ConsultaCombustivel + ";";
                    command.CommandText = ConsultaCombustivel;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_COMBUSTIVEL", MySqlDbType.Int32).Value = Combustivel.ID_Combustivel;
                            break;
                        case 1:
                            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Combustivel.Nome;
                            break;
                        case 2:
                            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Combustivel.Valor;
                            break;
                        case 3:
                            command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Combustivel.Data;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableCombustivel);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableCombustivel;
        }
        public DataTable Departamento(Departamento Depatamento, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    string ConsultaDepartamento = "SELECT * FROM DEPARTAMENTO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaDepartamento = ConsultaDepartamento + "ID_DEPARTAMENTO = @ID_DEPARTAMENTO";
                            break;
                        case 1:
                            ConsultaDepartamento = ConsultaDepartamento + "NIVELACESSO = @NIVELACESSO";
                            break;
                        case 2:
                            ConsultaDepartamento = ConsultaDepartamento + "NOME = @NOME";
                            break;
                        case 3:
                            ConsultaDepartamento = ConsultaDepartamento + "1";
                            break;
                    }

                    ConsultaDepartamento = ConsultaDepartamento + ";";
                    command.CommandText = ConsultaDepartamento;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = Depatamento.ID_Departamento;
                            break;
                        case 1:
                            command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
                            break;
                        case 2:
                            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableDepartamento);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableDepartamento;
        }
        public DataTable Destino(Destino Destino, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaDestino = "SELECT * FROM DESTINO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaDestino = ConsultaDestino + "ID_DESTINO = @ID_DESTINO";
                            break;
                        case 1:
                            ConsultaDestino = ConsultaDestino + "ID_VEICULO = @ID_VEICULO";
                            break;
                        case 2:
                            ConsultaDestino = ConsultaDestino + "ID_MOTORISTA = @ID_MOTORISTA";
                            break;
                        case 3:
                            ConsultaDestino = ConsultaDestino + "LOCAL_CHEGADA = @LOCAL_CHEGADA";
                            break;
                        case 4:
                            ConsultaDestino = ConsultaDestino + "DATAS_SAIDA = @DATAS_SAIDA";
                            break;
                        case 5:
                            ConsultaDestino = ConsultaDestino + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();



                    ConsultaDestino = ConsultaDestino + ";";
                    command.CommandText = ConsultaDestino;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_DESTINO", MySqlDbType.Int32).Value = Destino.ID_Destino;
                            break;
                        case 1:
                            command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Destino.ID_Veiculo;
                            break;
                        case 2:
                            command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Destino.ID_Motorista;
                            break;
                        case 3:
                            command.Parameters.Add("@LOCAL_CHEGADA", MySqlDbType.VarChar).Value = Destino.Local_Chegada;
                            break;
                        case 4:
                            command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.VarChar).Value = Destino.Data_Saida;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableDestino);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableDestino;
        }
        public DataTable Manutenção(Manutenção Manutenção, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaManutenção = "SELECT * FROM MANUTENCAO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaManutenção = ConsultaManutenção + "ID_MANUTENCAO = @ID_MANUTENCAO";
                            break;
                        case 1:
                            ConsultaManutenção = ConsultaManutenção + "NUM_OS = @NUM_OS";
                            break;
                        case 2:
                            ConsultaManutenção = ConsultaManutenção + "DATAS_ENTRADA = @DATAS_ENTRADA";
                            break;
                        case 3:
                            ConsultaManutenção = ConsultaManutenção + "MOTIVO = @MOTIVO";
                            break;
                        case 4:
                            ConsultaManutenção = ConsultaManutenção + "ID_VEICULO = @ID_VEICULO";
                            break;
                        case 5:
                            ConsultaManutenção = ConsultaManutenção + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaManutenção = ConsultaManutenção + ";";
                    command.CommandText = ConsultaManutenção;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_MANUTENCAO", MySqlDbType.Int32).Value = Manutenção.ID_Manutencao;
                            break;
                        case 1:
                            command.Parameters.Add("@NUM_OS", MySqlDbType.Int32).Value = Manutenção.NumeroOS;
                            break;
                        case 2:
                            command.Parameters.Add("@DATAS_ENTRADA", MySqlDbType.Date).Value = Manutenção.Data_Entrada;
                            break;
                        case 3:
                            command.Parameters.Add("@MOTIVO", MySqlDbType.VarChar).Value = Manutenção.Motivo;
                            break;
                        case 4:
                            command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Manutenção.ID_Veiculo;
                            break;
                    }


                    adapter.SelectCommand = command;
                    adapter.Fill(TableManutenção);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableManutenção;
        }
        public DataTable Multa(Multa Multa, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaMulta = "SELECT * FROM MULTA WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaMulta = ConsultaMulta + "ID_MULTA = @ID_MULTA";
                            break;
                        case 1:
                            ConsultaMulta = ConsultaMulta + "NUM_INFRACAO = @NUM_INFRACAO";
                            break;
                        case 2:
                            ConsultaMulta = ConsultaMulta + "TIPO_INFRACAO = @TIPO_INFRACAO";
                            break;
                        case 3:
                            ConsultaMulta = ConsultaMulta + "ID_MOTORISTA = @ID_MOTORISTA";
                            break;
                        case 4:
                            ConsultaMulta = ConsultaMulta + "ID_VEICULO = @ID_VEICULO";
                            break;
                        case 5:
                            ConsultaMulta = ConsultaMulta + "DATAS = @DATAS";
                            break;
                        case 6:
                            ConsultaMulta = ConsultaMulta + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaMulta = ConsultaMulta + ";";
                    command.CommandText = ConsultaMulta;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_MULTA", MySqlDbType.Int32).Value = Multa.ID_Multa;
                            break;
                        case 1:
                            command.Parameters.Add("@NUM_INFRACAO", MySqlDbType.Int32).Value = Multa.Infração;
                            break;
                        case 2:
                            command.Parameters.Add("@TIPO_INFRACAO", MySqlDbType.VarChar).Value = Multa.Tipo;
                            break;
                        case 3:
                            command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.Int32).Value = Multa.Motorista;
                            break;
                        case 4:
                            command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Multa.Veiculo;
                            break;
                        case 5:
                            command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Multa.Data;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableMulta);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableMulta;
        }
        public DataTable Notificação(Notificação Notificação, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaNotificação = "SELECT * FROM NOTIFICACAO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaNotificação = ConsultaNotificação + "ID_DEPARTAMENTO = @ID_DEPARTAMENTO";
                            break;
                        case 1:
                            ConsultaNotificação = ConsultaNotificação + "TITULO = @TITULO";
                            break;
                        case 2:
                            ConsultaNotificação = ConsultaNotificação + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();


                    ConsultaNotificação = ConsultaNotificação + ";";
                    command.CommandText = ConsultaNotificação;
                    command.Connection = Conexão.Pega_Conexão();


                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = Notificação.ID_Departamento;
                            break;
                        case 1:
                            command.Parameters.Add("@TITULO", MySqlDbType.VarChar).Value = Notificação.Titulo;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableNotificação);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableNotificação;
        }
        public DataTable Oficina(Oficina Oficina, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaOficina = "SELECT * FROM OFICINA WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaOficina = ConsultaOficina + "ID_OFICINA = @ID_OFICINA";
                            break;
                        case 1:
                            ConsultaOficina = ConsultaOficina + "NOME = @NOME";
                            break;
                        case 2:
                            ConsultaOficina = ConsultaOficina + "CNPJ = @CNPJ";
                            break;
                        case 3:
                            ConsultaOficina = ConsultaOficina + "RAZAO_SOCIAL = @RAZAO_SOCIAL";
                            break;
                        case 4:
                            ConsultaOficina = ConsultaOficina + "ENDERECO = @ENDERECO";
                            break;
                        case 5:
                            ConsultaOficina = ConsultaOficina + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();


                    ConsultaOficina = ConsultaOficina + ";";
                    command.CommandText = ConsultaOficina;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = Oficina.ID_Oficina;

                            break;
                        case 1:
                            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oficina.Nome;
                            break;
                        case 2:
                            command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Oficina.CNPJ;
                            break;
                        case 3:
                            command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Oficina.RazaoSocial;
                            break;
                        case 4:
                            command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Oficina.Endereço;

                            break;
                    }


                    adapter.SelectCommand = command;
                    adapter.Fill(TableOficina);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableOficina;
        }
        public DataTable Oleo(Oleo Oleo, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaOleo = "SELECT * FROM OLEO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaOleo = ConsultaOleo + "ID_OLEO = @ID_OLEO";
                            break;
                        case 1:
                            ConsultaOleo = ConsultaOleo + "NOME = @NOME";
                            break;
                        case 2:
                            ConsultaOleo = ConsultaOleo + "MARCA =  @MARCA";
                            break;
                        case 3:
                            ConsultaOleo = ConsultaOleo + "LITROS = @LITROS";
                            break;
                        case 4:
                            ConsultaOleo = ConsultaOleo + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaOleo = ConsultaOleo + ";";
                    command.CommandText = ConsultaOleo;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@NOME", MySqlDbType.Int32).Value = Oleo.ID_Oleo;
                            break;
                        case 1:
                            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oleo.Nome;
                            break;
                        case 2:
                            command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Oleo.Marca;
                            break;
                        case 3:
                            command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Oleo.Litros;
                            break;

                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableOleo);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableOleo;
        }
        public DataTable Posto(Posto Posto, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {

                    string ConsultaPosto = "SELECT * FROM POSTO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaPosto = ConsultaPosto + "ID_POSTO = @ID_POSTO";
                            break;
                        case 1:
                            ConsultaPosto = ConsultaPosto + "NOME = @NOME";
                            break;
                        case 2:
                            ConsultaPosto = ConsultaPosto + "CNPJ = @CNPJ";
                            break;
                        case 3:
                            ConsultaPosto = ConsultaPosto + "RAZAO_SOCIAL = @RAZAO_SOCIAL";
                            break;
                        case 4:
                            ConsultaPosto = ConsultaPosto + "ENDERECO = @ENDERECO";
                            break;
                        case 5:
                            ConsultaPosto = ConsultaPosto + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaPosto = ConsultaPosto + ";";
                    command.CommandText = ConsultaPosto;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_POSTO", MySqlDbType.Int32).Value = Posto.ID_Posto;
                            break;
                        case 1:
                            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Posto.Nome;

                            break;
                        case 2:
                            command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Posto.CNPJ;

                            break;
                        case 3:
                            command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Posto.RazaoSocial;
                            break;
                        case 4:
                            command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Posto.Endereço;

                            break;

                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TablePosto);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TablePosto;
        }
        public DataTable Salario(Salario Salario, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaSalario = "SELECT * FROM SALARIO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaSalario = ConsultaSalario + "SALARIO = @SALARIO";
                            break;
                        case 1:
                            ConsultaSalario = ConsultaSalario + "VALOR = @VALOR";
                            break;
                        case 2:
                            ConsultaSalario = ConsultaSalario + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaSalario = ConsultaSalario + ";";
                    command.CommandText = ConsultaSalario;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@VALOR", MySqlDbType.Int32).Value = Salario.ID_Salario;
                            break;
                        case 1:
                            command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Salario.Valor;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableSalario);
                    Conexão.Desconectar();
                }

            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableSalario;
        }
        public DataTable Usuario(Usuario Usuario, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaUsuario = "SELECT * FROM USUARIO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaUsuario = ConsultaUsuario + "ID_USUARIO = @ID_USUARIO";
                            break;
                        case 1:
                            ConsultaUsuario = ConsultaUsuario + "USERNAME = @USERNAME";
                            break;
                        case 2:
                            ConsultaUsuario = ConsultaUsuario + "DEPARTAMENTO = @DEPARTAMENTO";
                            break;
                        case 3:
                            ConsultaUsuario = ConsultaUsuario + "NOME = @NOME";
                            break;
                        case 4:
                            ConsultaUsuario = ConsultaUsuario + "EMAIL = @EMAIL";
                            break;
                        case 5:
                            ConsultaUsuario = ConsultaUsuario + "CPF = @CPF";
                            break;
                        case 6:
                            ConsultaUsuario = ConsultaUsuario + "CNH = @CNH";
                            break;
                        case 7:
                            ConsultaUsuario = ConsultaUsuario + "DATAS_ADIMISSAO = @DATAS_ADIMISSAO";
                            break;
                        case 8:
                            ConsultaUsuario = ConsultaUsuario + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaUsuario = ConsultaUsuario + ";";
                    command.CommandText = ConsultaUsuario;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_USUARIO", MySqlDbType.Int32).Value = Usuario.ID_Usuario;
                            break; ;
                        case 1:
                            command.Parameters.Add("@USERNAME", MySqlDbType.VarChar).Value = Usuario.Username;
                            break;
                        case 2:
                            command.Parameters.Add("@DEPARTAMENTO", MySqlDbType.Int32).Value = Usuario.Departamento;
                            break;
                        case 3:
                            command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Usuario.Nome;
                            break;
                        case 4:
                            command.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = Usuario.Email;
                            break;
                        case 5:
                            command.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = Usuario.CPF;
                            break;
                        case 6:
                            command.Parameters.Add("@CNH", MySqlDbType.Int32).Value = Usuario.CNH;
                            break;
                        case 7:
                            command.Parameters.Add("@DATAS_ADIMISSAO", MySqlDbType.Date).Value = Usuario.Categoria_CNH;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableUsuario);
                    Conexão.Desconectar();
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableUsuario;
        }
        public DataTable Veiculo(Veiculo Veiculo, int TipoPesquisa)
        {
            try
            {
                if (!Conexão.Checkconection())
                {
                    Conexão.Conectar();
                }

                if (Conexão.Checkconection())
                {
                    string ConsultaVeiculo = "SELECT * FROM VEICULO WHERE ";

                    switch (TipoPesquisa)
                    {
                        case 0:
                            ConsultaVeiculo = ConsultaVeiculo + "ID_VEICULO = @ID_VEICULO";
                            break;
                        case 1:
                            ConsultaVeiculo = ConsultaVeiculo + "PLACA = @PLACA";
                            break;
                        case 2:
                            ConsultaVeiculo = ConsultaVeiculo + "MODELO = @MODELO";
                            break;
                        case 3:
                            ConsultaVeiculo = ConsultaVeiculo + "TIPO = @TIPO";
                            break;
                        case 4:
                            ConsultaVeiculo = ConsultaVeiculo + "MARCA = @MARCA";
                            break;
                        case 5:
                            ConsultaVeiculo = ConsultaVeiculo + "ANO = @ANO";
                            break;
                        case 6:
                            ConsultaVeiculo = ConsultaVeiculo + "RENAVAM = @RENAVAM";
                            break;
                        case 7:
                            ConsultaVeiculo = ConsultaVeiculo + "CHSSI_NUM = @CHSSI_NUM ";
                            break;
                        case 8:
                            ConsultaVeiculo = ConsultaVeiculo + "ID_COMBUSTIVEL = @ID_COMBUSTIVEL ";
                            break;
                        case 9:
                            ConsultaVeiculo = ConsultaVeiculo + "1";
                            break;
                    }

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand();

                    ConsultaVeiculo = ConsultaVeiculo + ";";
                    command.CommandText = ConsultaVeiculo;
                    command.Connection = Conexão.Pega_Conexão();

                    switch (TipoPesquisa)
                    {
                        case 0:
                            command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Veiculo.ID_Veiculo;
                            break; 
                        case 1:
                            command.Parameters.Add("@PLACA", MySqlDbType.VarChar).Value = Veiculo.Placa;
                            break;
                        case 2:
                            command.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = Veiculo.Modelo;
                            break;
                        case 3:
                            command.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = Veiculo.Tipo;
                            break;
                        case 4:
                            command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Veiculo.Marca;
                            break;
                        case 5:
                            command.Parameters.Add("@ANO", MySqlDbType.Date).Value = Veiculo.Ano;
                            break;
                        case 6:
                            command.Parameters.Add("@RENAVAM", MySqlDbType.Int32).Value = Veiculo.Renavam;
                            break;
                        case 7:
                            command.Parameters.Add("@CHSSI_NUM", MySqlDbType.VarChar).Value = Veiculo.Chassi;
                            break;
                        case 8:
                            command.Parameters.Add("@ID_COMBUSTIVEL", MySqlDbType.Int32).Value = Veiculo.ID_Combustivel;
                            break;
                    }

                    adapter.SelectCommand = command;
                    adapter.Fill(TableVeiculo);
                    Conexão.Desconectar();
                }

            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }
            return TableVeiculo;
        }
    }
}
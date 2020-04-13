using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PIM_4_PERIODO.Model;



namespace PIM_4_PERIODO.Dao
{
    class Alterar
    {
        private Conexao Conexão = new Conexao();
        private Consultar Consulta = new Consultar();

        private bool Abastecimento_Alterado = false;
        private bool Combustivel_Alterado = false;
        private bool Departamento_Alterado = false;
        private bool Manutenção_Alterado = false;
        private bool Multa_Alterado = false;
        private bool Notificação_Alterado = false;
        private bool Oficina_Alterado = false;
        private bool Oleo_Alterado = false;
        private bool Posto_Alterado = false;
        private bool Salario_Alterado = false;
        private bool Usuario_Alterado = false;
        private bool Veiculo_Alterado = false;
        private bool Atendimento_Alterado = false;
        private bool Destino_Alterado = false;


        public bool Abastecimento(Abastecimento Abastecimento, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                table = Consulta.Abastecimento(Abastecimento, TipoPesquisa);

                //Verifica se o Abastecimento Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterAbastecimento = "UPDATE ABASTECIMENTO SET KM_NO_ABASTECIMENTO = @KM_NO_ABASTECIMENTO, LITROS = @LITROS, VALOR = @VALOR, ID_POSTO = @ID_POSTO, ID_VEICULO = @ID_VEICULO, DATAS = @DATAS WHERE ID_ABASTECIMENTO = @ID_ABASTECIMENTO;";


                        command.CommandText = AlterAbastecimento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@KM_NO_ABASTECIMENTO", MySqlDbType.VarChar).Value = Abastecimento.Km_No_Abastecimento;
                        command.Parameters.Add("@LITROS", MySqlDbType.VarChar).Value = Abastecimento.Litros;
                        command.Parameters.Add("@VALOR", MySqlDbType.VarChar).Value = Abastecimento.Valor;
                        command.Parameters.Add("@ID_POSTO", MySqlDbType.VarChar).Value = Abastecimento.ID_Posto;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Abastecimento.ID_Veiculo;
                        command.Parameters.Add("@DATAS", MySqlDbType.VarChar).Value = Abastecimento.Data;
                        command.Parameters.Add("@ID_ABASTECIMENTO", MySqlDbType.Int32).Value =  table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Abastecimento_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Abastecimento_Alterado;
                    }
                }
                else
                {

                    MessageBox.Show("Atendimento não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Abastecimento_Alterado;

        }
        public bool Combustivel(Combustivel Combustivel, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Combustivel(Combustivel, TipoPesquisa);

                //Verifica se o Combustivel Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterCombustivel = "UPDATE COMBUSTIVEL SET NOME = @NOME, VALOR = @VALOR, DATAS = @DATAS WHERE ID_COMBUSTIVEL = @ID_COMBUSTIVEL;";


                        command.CommandText = AlterCombustivel;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Combustivel.Nome;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Combustivel.Valor;
                        command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Combustivel.Data;
                        command.Parameters.Add("@ID_COMBUSTIVEL", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Combustivel_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Combustivel_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Combustivel não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Combustivel_Alterado;
        }
        public bool Departamento(Departamento Depatamento, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Departamento(Depatamento, TipoPesquisa);

                //Verifica se o Departamento Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterDepartamento = "UPDATE DEPARTAMENTO SET NOME = @NOME, NIVELACESSO = @NIVELACESSO WHERE ID_DEPARTAMENTO = @ID_DEPARTAMENTO;";


                        command.CommandText = AlterDepartamento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;
                        command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value =  table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Departamento_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Departamento_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Departamento não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Departamento_Alterado;
        }
        public bool Manutenção(Manutenção Manutenção, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Manutenção(Manutenção, TipoPesquisa);


                //Verifica se o Manutenção Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterManutençãoo = "UPDATE MANUTENCAO SET NUM_OS = @NUM_OS, ID_OFICINA = @ID_OFICINA, DATAS_ENTRADA = @DATAS_ENTRADA, DATAS_SAIDA = @DATAS_SAIDA, MOTIVO = @MOTIVO, VALOR = @VALOR, ID_VEICULO = @ID_VEICULO WHERE ID_MANUTENCAO = @ID_MANUTENCAO;";


                        command.CommandText = AlterManutençãoo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NUM_OS", MySqlDbType.Int32).Value = Manutenção.NumeroOS;
                        command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = Manutenção.ID_Oficina;
                        command.Parameters.Add("@DATAS_ENTRADA", MySqlDbType.Date).Value = Manutenção.Data_Entrada;
                        command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.Date).Value = Manutenção.Data_Saida;
                        command.Parameters.Add("@MOTIVO", MySqlDbType.VarChar).Value = Manutenção.Motivo;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Manutenção.Valor;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Manutenção.ID_Veiculo;
                        command.Parameters.Add("@ID_MANUTENCAO", MySqlDbType.Int32).Value =  table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Manutenção_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Manutenção_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Manutenção não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Manutenção_Alterado;
        }
        public bool Multa(Multa Multa, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Multa(Multa, TipoPesquisa);

                //Verifica se o Multa Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        
                        string AlterMulta = "UPDATE MULTA SET NUM_INFRACAO = @NUM_INFRACAO, TIPO_INFRACAO = @TIPO_INFRACAO, ID_MOTORISTA = @ID_MOTORISTA, ID_VEICULO = @ID_VEICULO, VALOR = @VALOR, DATAS = @DATAS, ENDERECO = @ENDERECO WHERE ID_MULTA = @ID_MULTA";


                        command.CommandText = AlterMulta;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NUM_INFRACAO", MySqlDbType.Int32).Value = Multa.Infração;
                        command.Parameters.Add("@TIPO_INFRACAO", MySqlDbType.VarChar).Value = Multa.Tipo;
                        command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.Int32).Value = Multa.Motorista;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = Multa.Veiculo;
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Multa.Valor;
                        command.Parameters.Add("@DATAS", MySqlDbType.Date).Value = Multa.Data;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Multa.Endereço;
                        command.Parameters.Add("@ID_MULTA", MySqlDbType.Int32).Value =  table.Rows[0][0];
                        
                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Multa_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Multa_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Multa não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Multa_Alterado;
        }
        public bool Notificação(Notificação Notificação, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Notificação(Notificação, TipoPesquisa);

                //Verifica se o Notificação Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterNotificação = "UPDATE NOTIFICACAO SET ID_NOTIFICACAO = @ID_NOTIFICACAO, TITULO = @TITULO, IMAGEM = @IMAGEM, DESCRICAO = @DESCRICAO  WHERE ID_NOTIFICACAO = @ID_NOTIFICACAO;";


                        command.CommandText = AlterNotificação;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = Notificação.ID_Departamento;
                        command.Parameters.Add("@TITULO", MySqlDbType.VarChar).Value = Notificação.Titulo;
                        command.Parameters.Add("@IMAGEM", MySqlDbType.VarChar).Value = Notificação.Imagem;
                        command.Parameters.Add("@DESCRICAO", MySqlDbType.VarChar).Value = Notificação.Descrição;
                        command.Parameters.Add("@ID_NOTIFICACAO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Notificação_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Notificação_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Notificação não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Notificação_Alterado;
        }
        public bool Oficina(Oficina Oficina, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Oficina(Oficina, TipoPesquisa);

                //Verifica se o Oficina Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterOficina = "UPDATE OFICINA SET NOME = @NOME, CNPJ = @CNPJ, RAZAO_SOCIAL = @RAZAO_SOCIAL, TELEFONE = @TELEFONE, CELULAR = @CELULAR, SITE = @SITE, ENDERECO = @ENDERECO WHERE ID_OFICINA = @ID_OFICINA;";


                        command.CommandText = AlterOficina;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oficina.Nome;
                        command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Oficina.CNPJ;
                        command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Oficina.RazaoSocial;
                        command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Oficina.Telefone;
                        command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Oficina.Celular;
                        command.Parameters.Add("@SITE", MySqlDbType.VarChar).Value = Oficina.Site;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Oficina.Endereço;
                        command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Oficina_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Oficina_Alterado;    
                    }
                }
                else
                {
                    MessageBox.Show("Oficina não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Oficina_Alterado;
        }
        public bool Oleo(Oleo Oleo, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Oleo(Oleo, TipoPesquisa);

                //Verifica se o Oleo Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterOleo = "UPDATE OLEO SET NOME = @NOME, MARCA = @MARCA, LITROS = @LITROS  WHERE ID_OLEO = @ID_OLEO;";

                        command.CommandText = AlterOleo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Oleo.Nome;
                        command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Oleo.Marca;
                        command.Parameters.Add("@LITROS", MySqlDbType.Float).Value = Oleo.Litros;
                        command.Parameters.Add("@ID_OLEO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Oleo_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Oleo_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Oleo não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Oleo_Alterado;
        }
        public bool Posto(Posto Posto, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Posto(Posto, TipoPesquisa);

                //Verifica se o Posto Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterPosto = "UPDATE POSTO SET NOME = @NOME, CNPJ = @CNPJ, RAZAO_SOCIAL = @RAZAO_SOCIAL, TELEFONE = @TELEFONE, CELULAR = @CELULAR, SITE = @SITE, ENDERECO = @ENDERECO WHERE ID_POSTO = @ID_POSTO";


                        command.CommandText = AlterPosto;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Posto.Nome;
                        command.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = Posto.CNPJ;
                        command.Parameters.Add("@RAZAO_SOCIAL", MySqlDbType.VarChar).Value = Posto.RazaoSocial;
                        command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Posto.Telefone;
                        command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Posto.Celular;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Posto.Endereço;
                        command.Parameters.Add("@ID_POSTO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Posto_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Posto_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Posto não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Posto_Alterado;
        }
        public bool Salario(Salario Salario, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Salario(Salario, TipoPesquisa);

                //Verifica se o Salario Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterSalario = "UPDATE SALARIO SET VALOR = @VALOR WHERE ID_SALARIO = @ID_SALARIO;";
                        
                        command.CommandText = AlterSalario;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@VALOR", MySqlDbType.Float).Value = Salario.Valor;
                        command.Parameters.Add("@ID_SALARIO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Salario_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Salario_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Salario não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Salario_Alterado;
        }
        public bool Usuario(Usuario Usuario, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Usuario(Usuario, TipoPesquisa);

                Console.WriteLine("Vindo da Função: ");
                Console.WriteLine("Chegou Aqui, Usuario Procurado: " + Usuario.ID_Usuario);
                Console.WriteLine("Chegou Aqui, Usuario Procurado: " + Usuario.Username);
                Console.WriteLine("Chegou Aqui, Senha do Usuario: " + Usuario.Senha);

                Console.WriteLine("Vindo da Tabela: ");
                


                //Verifica se o Usuario Ja esta cadastrado.
                if (table.Rows.Count > 0)
                {
                    Console.WriteLine(Convert.ToString(table));
                    
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        //UPDATE `USUARIO` SET `SENHA`= '55555' WHERE `USERNAME`= 'Fábio';


                        string AlterUsuario = "UPDATE USUARIO SET USERNAME = @USERNAME, SENHA = @SENHA, DEPARTAMENTO = @DEPARTAMENTO, NOME = @NOME, EMAIL = @EMAIL, CPF = @CPF, TELEFONE = @TELEFONE, CELULAR = @CELULAR, ENDERECO = @ENDERECO, CNH = @CNH, VALIDADE_CNH = @VALIDADE_CNH, CATEGORIA_CNH = @CATEGORIA_CNH, DATA_ADIMISSAO = @DATA_ADIMISSAO WHERE ID_USUARIO = @ID_USUARIO;";

                        command.CommandText = AlterUsuario;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@USERNAME", MySqlDbType.VarChar).Value = Usuario.Username;
                        command.Parameters.Add("@SENHA", MySqlDbType.VarChar).Value = Usuario.Senha;
                        command.Parameters.Add("@DEPARTAMENTO", MySqlDbType.Int32).Value = Usuario.Departamento;
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Usuario.Nome;
                        command.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = Usuario.Email;
                        command.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = Usuario.CPF;
                        command.Parameters.Add("@TELEFONE", MySqlDbType.Int32).Value = Usuario.Telefone;
                        command.Parameters.Add("@CELULAR", MySqlDbType.Int32).Value = Usuario.Celular;
                        command.Parameters.Add("@ENDERECO", MySqlDbType.VarChar).Value = Usuario.Endereço;
                        command.Parameters.Add("@CNH", MySqlDbType.Int32).Value = Usuario.CNH;
                        command.Parameters.Add("@VALIDADE_CNH", MySqlDbType.Date).Value = Usuario.Validade_CNH;
                        command.Parameters.Add("@CATEGORIA_CNH", MySqlDbType.VarChar).Value = Usuario.Categoria_CNH;
                        command.Parameters.Add("@DATA_ADIMISSAO", MySqlDbType.Date).Value = Usuario.Data_Adimissao;
                        command.Parameters.Add("@ID_USUARIO", MySqlDbType.Int32).Value = Usuario.ID_Usuario;
                        
                        String commandtext = command.CommandText;
                        foreach (MySqlParameter p in command.Parameters)
                            commandtext = commandtext.Replace(p.ParameterName, p.Value.ToString());

                        //command.CommandText = commandtext;
                        Console.WriteLine("String de Update: " + commandtext);

                        adapter.SelectCommand = command;

                        
                        if (command.ExecuteNonQuery() > 0)
                        {
                            Usuario_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Usuario_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Usuario_Alterado;    
        }
        public bool Veiculo(Veiculo Veiculo, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Veiculo(Veiculo, TipoPesquisa);

                //Verifica se o Veiculo Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterVeiculo = "UPDATE VEICULO SET PLACA = @PLACA, MODELO = @MODELO, TIPO = @TIPO, MARCA = @MARCA, ANO = @ANO, RENAVAM = @RENAVAM, CHSSI_NUM = @CHSSI_NUM, KM_POR_LITRO = @KM_POR_LITRO, KM_TROCA_OLEO = @KM_TROCA_OLEO, KM_REVISAO = @KM_REVISAO, KM_PNEU = @KM_PNEU, CAPACIDADE_TANQUE = @CAPACIDADE_TANQUE, ID_COMBUSTIVEL = @ID_COMBUSTIVEL WHERE ID_VEICULO = @ID_VEICULO;";


                        command.CommandText = AlterVeiculo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@PLACA", MySqlDbType.VarChar).Value = Veiculo.Placa;
                        command.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = Veiculo.Modelo;
                        command.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = Veiculo.Tipo;
                        command.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = Veiculo.Marca;
                        command.Parameters.Add("@ANO", MySqlDbType.Int32).Value = Veiculo.Ano;
                        command.Parameters.Add("@RENAVAM", MySqlDbType.Int32).Value = Veiculo.Renavam;
                        command.Parameters.Add("@CHSSI_NUM", MySqlDbType.VarChar).Value = Veiculo.Chassi;
                        command.Parameters.Add("@KM_POR_LITRO", MySqlDbType.Float).Value = Veiculo.KM_Litro;
                        command.Parameters.Add("@KM_TROCA_OLEO", MySqlDbType.Float).Value = Veiculo.KM_TrocaOleo;
                        command.Parameters.Add("@KM_REVISAO", MySqlDbType.Float).Value = Veiculo.KM_Revisao;
                        command.Parameters.Add("@KM_PNEU", MySqlDbType.Float).Value = Veiculo.KM_TrocaPneu;
                        command.Parameters.Add("@CAPACIDADE_TANQUE", MySqlDbType.Float).Value = Veiculo.Capacidade_Tanque;
                        command.Parameters.Add("@ID_COMBUSTIVEL", MySqlDbType.Int32).Value = Veiculo.ID_Combustivel;
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Veiculo_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Veiculo_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Veiculo não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Veiculo_Alterado;
        }
        public bool Atendimento(Atendimento Atendimento, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();

                table = Consulta.Atendimento(Atendimento, TipoPesquisa);
                
                //Verifica se o Atendimento Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterAtendimento = "UPDATE ATENDIMENTO SET ID_VEICULO = @ID_VEICULO, ID_MOTORISTA = @ID_MOTORISTA, ID_DESTINO = @ID_DESTINO WHERE ID_ATENDIMENTO = @ID_ATENDIMENTO;";


                        command.CommandText = AlterAtendimento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Atendimento.ID_Veiculo;
                        command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Atendimento.ID_Motorista;
                        command.Parameters.Add("@ID_DESTINO", MySqlDbType.VarChar).Value = Atendimento.ID_Destino;
                        command.Parameters.Add("@ID_ATENDIMENTO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Atendimento_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Atendimento_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Atendimento não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Atendimento_Alterado;
        }
        public bool Destino(Destino Destino, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Destino(Destino, TipoPesquisa);

                //Verifica se o Destino Ja esta cadastrado.
                if (table.Rows.Count != 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string AlterDestino = "UPDATE DESTINO SET ID_VEICULO = @ID_VEICULO, ID_MOTORISTA = @ID_MOTORISTA, LOCAL_CHEGADA = @LOCAL_CHEGADA, LOCAL_SAIDA = @LOCAL_SAIDA, DATAS_CHEGADA = @DATAS_CHEGADA, DATAS_SAIDA = @DATAS_SAIDA WHERE ID_DESTINO = @ID_DESTINO;";


                        command.CommandText = AlterDestino;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.VarChar).Value = Destino.ID_Veiculo;
                        command.Parameters.Add("@ID_MOTORISTA", MySqlDbType.VarChar).Value = Destino.ID_Motorista;
                        command.Parameters.Add("@LOCAL_CHEGADA", MySqlDbType.VarChar).Value = Destino.Local_Chegada;
                        command.Parameters.Add("@LOCAL_SAIDA", MySqlDbType.VarChar).Value = Destino.Local_Saida;
                        command.Parameters.Add("@DATAS_CHEGADA", MySqlDbType.VarChar).Value = Destino.Data_Chegada;
                        command.Parameters.Add("@DATAS_SAIDA", MySqlDbType.VarChar).Value = Destino.Data_Saida;
                        command.Parameters.Add("@ID_DESTINO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Destino_Alterado = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Destino_Alterado;
                    }
                }
                else
                {
                    MessageBox.Show("Salario não pode ser Alterado", "Problemas ao Alterar");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Destino_Alterado;
        }
    }
}
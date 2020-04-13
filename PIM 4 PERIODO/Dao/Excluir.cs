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
    class Excluir
    {
        private Conexao Conexão = new Conexao();
        private Consultar Consulta = new Consultar();

        private bool Abastecimento_Excluido = false;
        private bool Combustivel_Excluido = false;
        private bool Departamento_Excluido = false;
        private bool Manutenção_Excluido = false;
        private bool Multa_Excluido = false;
        private bool Notificação_Excluido = false;
        private bool Oficina_Excluido = false;
        private bool Oleo_Excluido = false;
        private bool Posto_Excluido = false;
        private bool Salario_Excluido = false;
        private bool Usuario_Excluido = false;
        private bool Veiculo_Excluido = false;
        private bool Atendimento_Excluido = false;
        private bool Destino_Excluido = false;


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
                        string ExcludAbastecimento = "DELETE FROM `ABASTECIMENTO` WHERE ID_ABASTECIMENTO = @ID_ABASTECIMENTO;";


                        command.CommandText = ExcludAbastecimento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_ABASTECIMENTO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Abastecimento_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Abastecimento_Excluido;
                    }
                }
                else
                {

                    MessageBox.Show("Atendimento não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Abastecimento_Excluido;

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
                        
                        string ExcludCombustivel = "DELETE FROM `COMBUSTIVEL` WHERE ID_COMBUSTIVEL = @ID_COMBUSTIVEL;";


                        command.CommandText = ExcludCombustivel;
                        command.Parameters.Add("@ID_COMBUSTIVEL", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Combustivel_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Combustivel_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Combustivel não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Combustivel_Excluido;
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
                        string ExcludDepartamento = "DELETE FROM `DEPARTAMENTO` WHERE ID_DEPARTAMENTO = @ID_DEPARTAMENTO;";


                        command.CommandText = ExcludDepartamento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@NIVELACESSO", MySqlDbType.Int32).Value = Depatamento.NivelAcesso;
                        command.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = Depatamento.Nome;
                        command.Parameters.Add("@ID_DEPARTAMENTO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Departamento_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Departamento_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Departamento não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Departamento_Excluido;
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
                        string ExcludManutençãoo = "DELETE FROM `MANUTENCAO` WHERE ID_MANUTENCAO = @ID_MANUTENCAO;";


                        command.CommandText = ExcludManutençãoo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_MANUTENCAO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Manutenção_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Manutenção_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Manutenção não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Manutenção_Excluido;
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
                        string ExcludMulta = "DELETE FROM `MULTA` WHERE ID_MULTA = @ID_MULTA;";
                        

                        command.CommandText = ExcludMulta;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_MULTA", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Multa_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Multa_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Multa não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Multa_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludNotificação = "DELETE FROM `NOTIFICACAO` WHERE ID_NOTIFICACAO = @ID_NOTIFICACAO;";


                        command.CommandText = ExcludNotificação;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_NOTIFICACAO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Notificação_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Notificação_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Notificação não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Notificação_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludOficina = "DELETE FROM `OFICINA` WHERE ID_OFICINA = @ID_OFICINA;";


                        command.CommandText = ExcludOficina;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_OFICINA", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Oficina_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Oficina_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Oficina não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Oficina_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludOleo = "DELETE FROM `OLEO` WHERE ID_OLEO = @ID_OLEO;";

                        command.CommandText = ExcludOleo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_OLEO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Oleo_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Oleo_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Oleo não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Oleo_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludPosto = "DELETE FROM `POSTO` WHERE ID_POSTO = @ID_POSTO;";


                        command.CommandText = ExcludPosto;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_POSTO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Posto_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Posto_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Posto não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Posto_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludSalario = "DELETE FROM `SALARIO` WHERE ID_SALARIO = @ID_SALARIO;";

                        command.CommandText = ExcludSalario;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_SALARIO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Salario_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Salario_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Salario não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Salario_Excluido;
        }
        public bool Usuario(Usuario Usuario, int TipoPesquisa)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand();
                table = Consulta.Usuario(Usuario, TipoPesquisa);

                //Verifica se o Usuario Ja esta cadastrado.
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludUsuario = "DELETE FROM `USUARIO` WHERE ID_USUARIO = @ID_USUARIO;";


                        command.CommandText = ExcludUsuario;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_USUARIO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Usuario_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Usuario_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Usuario_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludVeiculo = "DELETE FROM `VEICULO` WHERE ID_VEICULO = @ID_VEICULO;";


                        command.CommandText = ExcludVeiculo;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_VEICULO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Veiculo_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Veiculo_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Veiculo não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Veiculo_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludAtendimento = "DELETE FROM `ATENDIMENTO` WHERE ID_ATENDIMENTO = @ID_ATENDIMENTO;";


                        command.CommandText = ExcludAtendimento;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_ATENDIMENTO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Atendimento_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Atendimento_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Atendimento não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Atendimento_Excluido;
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
                if (table.Rows.Count == 0)
                {
                    if (!Conexão.Checkconection())
                    {
                        Conexão.Conectar();
                    }

                    if (Conexão.Checkconection())
                    {
                        string ExcludDestino = "DELETE FROM `DESTINO` WHERE ID_DESTINO = @ID_DESTINO;";


                        command.CommandText = ExcludDestino;
                        command.Connection = Conexão.Pega_Conexão();
                        command.Parameters.Add("@ID_DESTINO", MySqlDbType.Int32).Value = table.Rows[0][0];

                        int retorno = command.ExecuteNonQuery();
                        if (retorno > 0)
                        {
                            Destino_Excluido = true;
                        }
                        Conexão.Desconectar();
                    }
                    else
                    {
                        return Destino_Excluido;
                    }
                }
                else
                {
                    MessageBox.Show("Salario não pode ser Excluido", "Problemas ao Excluir");
                }
            }
            catch (MySqlException Exception)
            {
                MessageBox.Show(Convert.ToString(Exception), "Estado da Conexão");
            }

            return Destino_Excluido;
        }
    }
}
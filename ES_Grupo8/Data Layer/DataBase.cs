using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BO;
using Npgsql;
using System.Data;

namespace DL
{
    /// <summary>
    /// Summary description for DataBase
    /// </summary>
    public class DataBase
    {
       
        DataTable dt = new DataTable();
        List<Horario> listaHorarios = new List<Horario>();
        List<Perfil> listaPerfis = new List<Perfil>();
        List<Protocolo> listaProtocolos = new List<Protocolo>();
        List<Tipo_Profissional> listaTiposProfissional = new List<Tipo_Profissional>();

        public DataBase()
        {


        }

        private static string host = "localhost";
        private static string username = "postgres";
        private static string password = "1307";
        private static string database = "ES_Clinica";

        private static string connectionString = "Host=" + host + ";Username=" + username + ";Password=" + password + ";Database=" + database;

        /// <summary>
        /// Função que verifica se o login é válido
        /// </summary>
        /// <param name="currentUser"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>
        /// currentUser -  caso seja esse o utilizador com as credenciais inseridas
        /// null - Caso não haja nenhum utilizador com as credencias inseridas
        /// </returns>
        public Utilizador Login(Utilizador currentUser, string email, string password)
        {
            //Query a ser executada
            string query = "select * from Utilizador where email='" + email + "' and senha='" + password + "'";

            //Funções 
            GetHorarios();
            GetPerfis();
            GetProtocolos();
            GetTipoProfissional();

            dt = ExecuteReturnQuery(query);

            if (dt.Rows.Count == 1)
            {
                currentUser.CC = Convert.ToInt32(dt.Rows[0]["cc"]);
                currentUser.Data_Contrato = Convert.ToDateTime(dt.Rows[0]["data_contrato"]);
                currentUser.Data_Nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                currentUser.Email = dt.Rows[0]["email"].ToString();
                currentUser.ID = Convert.ToInt32(dt.Rows[0]["id"]);

                //Para atribuir horário do tipo Horario ao currentUser
                foreach(Horario horario in listaHorarios)
                {
                    if(horario.ID == Convert.ToInt32(dt.Rows[0]["id_horário"]))
                    {
                        currentUser.Horário = horario;
                    }
                }

                //Para atribuir perfil do tipo Perfil ao currentUser
                foreach (Perfil perfil in listaPerfis)
                {
                    if (perfil.ID == Convert.ToInt32(dt.Rows[0]["id_perfil"]))
                    {
                        currentUser.Perfil = perfil;
                    }
                }

                //Para atribuir protocolo do tipo Protocolo ao currentUser
                foreach (Protocolo protocolo in listaProtocolos)
                {
                    if (protocolo.ID == Convert.ToInt32(dt.Rows[0]["id_protocolo"]))
                    {
                        currentUser.Protocolo = protocolo;
                    }
                }

                //Para atribuir tipoProfissional do tipo Tipo_Profissioanl ao currentUser
                foreach (Tipo_Profissional tipoProfissional in listaTiposProfissional)
                {
                    if (tipoProfissional.ID == Convert.ToInt32(dt.Rows[0]["id_tipoprofissional"]))
                    {
                        currentUser.TipoProfissional = tipoProfissional;
                    }
                }

                currentUser.Morada = dt.Rows[0]["morada"].ToString();
                currentUser.Nacionalidade = dt.Rows[0]["nacionalidade"].ToString();
                currentUser.Nome = dt.Rows[0]["nome"].ToString();
                currentUser.Senha = dt.Rows[0]["senha"].ToString();
                currentUser.Sexo = dt.Rows[0]["sexo"].ToString();
                currentUser.Telemovel = dt.Rows[0]["telemovel"].ToString();


                return currentUser;
            }
            return null;
        }

        /// <summary>
        /// Função que adiciona todos os horarios existentes para uma lista do tipo Horario
        /// </summary>
        void GetHorarios()
        {
            string query = "select * from Horario";
            dt = ExecuteReturnQuery(query);

            foreach (DataRow linha in dt.Rows)
            {
                Horario horario = new Horario(
                    Convert.ToInt32(linha["id"]),
                    Convert.ToInt32(linha["hora_entrada"]),
                    Convert.ToInt32(linha["hora_saída"]),
                    Convert.ToInt32(linha["hora_almoço"]),
                    linha["dias_disponíveis"].ToString()
                );
                listaHorarios.Add(horario);
            }
        }

        /// <summary>
        /// Função que adiciona todos os perfis existentes para uma lista do tipo Perfil
        /// </summary>
        void GetPerfis()
        {
            string query = "select * from Perfil";
            dt = ExecuteReturnQuery(query);

            foreach (DataRow linha in dt.Rows)
            {
                Perfil perfil = new Perfil(
                    Convert.ToInt32(linha["id"]),
                    linha["descrição"].ToString()
                );
                listaPerfis.Add(perfil);
            }
        }

        /// <summary>
        /// Função que adiciona todos os protocolos existentes para uma lista do tipo Protocolo
        /// </summary>
        void GetProtocolos()
        {
            string query = "select * from Protocolo";
            dt = ExecuteReturnQuery(query);

            foreach (DataRow linha in dt.Rows)
            {
                Protocolo protocolo = new Protocolo(
                    Convert.ToInt32(linha["id"]),
                    linha["descrição"].ToString()
                );
                listaProtocolos.Add(protocolo);
            }
        }

        /// <summary>
        /// Função que adiciona todos os tipos de profissionais existentes para uma lista do tipo Tipo_Profissional
        /// </summary>
        void GetTipoProfissional()
        {
            string query = "select * from tipo_profissional";
            dt = ExecuteReturnQuery(query);

            foreach (DataRow linha in dt.Rows)
            {
                Tipo_Profissional tipoProfissional = new Tipo_Profissional(
                    Convert.ToInt32(linha["id"]),
                    linha["categoria"].ToString()
                );
                listaTiposProfissional.Add(tipoProfissional);
            }
        }

        public DataTable ExecuteReturnQuery(string query)
        {
            DataTable dt = new DataTable();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connectionString);

                da.Fill(dt);
            }
            return dt;
        }
    }
}
//public int ExecuteInsertEvento(Evento evento)
//{

//    string query = "INSERT INTO Evento(ID, Data, Titulo, Descricao, Id_Utilizador) VALUES (@id, @data, @titulo, @descricao, @id_utilizador);";

//    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
//    {
//        connection.Open();

//        using (var command = new NpgsqlCommand(query, connection))
//        {

//            command.Parameters.AddWithValue("@id", evento.id);
//            command.Parameters.AddWithValue("@data", evento.data);
//            command.Parameters.AddWithValue("@titulo", evento.titulo);
//            command.Parameters.AddWithValue("@descricao", evento.descricao);
//            command.Parameters.AddWithValue("@id_utilizador", evento.id_utilizador);

//            return command.ExecuteNonQuery();
//        }
//    }

//}



        //public int ExecuteDeleteEvento(Evento eventoDeserialized)
        //{
        //    string query = "DELETE FROM Evento WHERE ID = @id;";

        //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        using (var command = new NpgsqlCommand(query, connection))
        //        {

        //            command.Parameters.AddWithValue("@id", eventoDeserialized.id);

        //            return command.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public int ExecuteInsertUser(Utilizador currentUser)
        //{

        //    string query = "INSERT INTO Utilizador(ID, Nome, Cidade, Id_Cidade, Email, Password) VALUES (@id, @nome, @cidade, @idCidade, @email, @password);";

        //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        using (var command = new NpgsqlCommand(query, connection))
        //        {

        //            command.Parameters.AddWithValue("@id", currentUser.id);
        //            command.Parameters.AddWithValue("@nome", currentUser.nome);
        //            command.Parameters.AddWithValue("@cidade", currentUser.cidade);
        //            command.Parameters.AddWithValue("@idCidade", currentUser.id_cidade);
        //            command.Parameters.AddWithValue("@email", currentUser.email);
        //            command.Parameters.AddWithValue("@password", currentUser.password);

        //            return command.ExecuteNonQuery();
        //        }
        //    }

        //}

        //public int ExecuteUpdateEvento(Evento evento)
        //{

        //    string query = "UPDATE Evento SET Data = @data, Titulo = @titulo, Descricao = @descricao, Id_Utilizador = @id_utilizador WHERE ID = @id;";

        //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        using (var command = new NpgsqlCommand(query, connection))
        //        {

        //            command.Parameters.AddWithValue("@id", evento.id);
        //            command.Parameters.AddWithValue("@data", evento.data);
        //            command.Parameters.AddWithValue("@titulo", evento.titulo);
        //            command.Parameters.AddWithValue("@descricao", evento.descricao);
        //            command.Parameters.AddWithValue("@id_utilizador", evento.id_utilizador);

        //            return command.ExecuteNonQuery();
        //        }
        //    }

        //}

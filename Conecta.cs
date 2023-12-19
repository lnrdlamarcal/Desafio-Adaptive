using System;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Desafio
{
    public class Conn
    {
        public NpgsqlConnection _connection;
        public string connString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=desafio_db";  //String de conexão do banco de dados

        public void Conecta() //Method para abrir o banco de addos
        {
            _connection = new NpgsqlConnection(connString);
            _connection.Open();
        }

        public void Fecha() //Method para fechar o banco de dados
        {
            _connection.Close();
        }

        public void RodaQuery(string query) //Executa a query em que não espera receber um return
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, _connection);
            cmd.ExecuteNonQuery();
        }

        public string RodaConsulta(string query) //Executa a query em que se espera receber um return
        {
            var lendo = "";
            var command = new NpgsqlDataSourceBuilder(connString);
            using var dataSource = command.Build();
            using var comando = dataSource.CreateCommand(query);
            using var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                lendo = reader.GetString(0);
            }
            return lendo;
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGEducation.Core
{
    public class SqlTableManager : IDisposable
    {
        const string DEFAULT_CONNECT = "Server=localhost;Port=5432;Username=postgres;Password=admin;Database=PGEducation;";

        private readonly string _connectionString;
        private readonly NpgsqlConnection _sqlConnection;

        public SqlTableManager() : this(DEFAULT_CONNECT) { }

        public SqlTableManager(string connectString)
        {
            _connectionString = connectString;
            _sqlConnection = new NpgsqlConnection(_connectionString);
        }

        public void Dispose()
        {
            CloseConnection();
        }

        public void OpenConnection()
        {
           _sqlConnection.Open();
        }

        public DataTable PerformCommand(string commandText)
        {
            if (_sqlConnection.State != ConnectionState.Open)
            {
                throw new Exception("Sql connection not opened");
            }

            NpgsqlCommand command = new NpgsqlCommand()
            {
                Connection = _sqlConnection,
                CommandType = CommandType.Text,
                CommandText = commandText
            };
            NpgsqlDataReader dataReader = command.ExecuteReader();
            DataTable convertedData = new DataTable();
            convertedData.Load(dataReader);
            
            command.Dispose();
            return convertedData;
        }

        public void CloseConnection()
        {
            _sqlConnection.Close();
        }
    }
}

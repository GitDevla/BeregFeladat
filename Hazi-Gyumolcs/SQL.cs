using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi_Gyumolcs {
    class SQL {
        private readonly MySqlConnection connection;
        public SQL(string url, string username, string password, string databaseName) {
            var conString = new MySqlConnectionStringBuilder();
            conString.Server = url;
            conString.UserID = username;
            conString.Password = password;
            conString.Database = databaseName;
            connection = new MySqlConnection(conString.ConnectionString);
        }

        public QueryResponse Query(string query) {
            try {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                return new QueryResponse(command.ExecuteReader());
            } finally {
                connection.Close();
            }
        }

        public int NonQuery(MySqlCommand query) {
            try {
                connection.Open();
                return query.ExecuteNonQuery();
            } finally {
                connection.Close();
            }
        }
    }

    class QueryResponse {
        public readonly List<string> Headers = new List<string>();
        public readonly List<List<string>> Values = new List<List<string>>();

        public QueryResponse(MySqlDataReader reader) {
            for (int i = 0; i < reader.FieldCount; i++)
                Headers.Add(reader.GetName(i));

            while (reader.Read()) {
                var values = new List<string>();
                for (int i = 0; i < reader.FieldCount; i++)
                    values.Add(reader[i].ToString());
                Values.Add(values);
            }
        }
    }
}

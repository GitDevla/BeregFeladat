using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DLib {
    public class SQL {
        private readonly MySqlConnection connection;
        public SQL(string url, string username, string password, string databaseName) {
            connection = new MySqlConnection($"Server={url};Database={databaseName};Uid={username};Pwd={password};");
        }

        private QueryResponse fetch(MySqlCommand cmd) {
            try {
                connection.Open();
                cmd.Connection = connection;
                return new QueryResponse(cmd.ExecuteReader());
            } finally {
                connection.Close();
            }
        }

        public QueryResponse Query(string query) {
            return fetch(new MySqlCommand(query));
        }

        public QueryResponse Query(string query, params object[] args) {
            MySqlCommand cmd = new MySqlCommand(query);
            for (int i = 0; i < args.Length; i++)
                cmd.Parameters.AddWithValue($"@{i + 1}", args[i]);
            return fetch(cmd);
        }

        public bool TestConnection() {
            try {
                var response = Query("show tables;");
                if (response.Values.Count == 0) return false;
                return true;
            } catch {
                return false;
            }
        }
    }

    public class QueryResponse {
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
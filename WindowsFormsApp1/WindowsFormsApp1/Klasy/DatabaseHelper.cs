using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Klasy
{
    internal class DatabaseHelper
    {
        private readonly string ConnectionString;

        public DatabaseHelper(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            if (string.IsNullOrWhiteSpace(query)) throw new ArgumentException("Query cannot be null or whitespace.", nameof(query));

            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    connection.Open();
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception($"An error occurred executing the query: {ex.Message}", ex);
                }
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            if (string.IsNullOrWhiteSpace(query)) throw new ArgumentException("Query cannot be null or whitespace.", nameof(query));

            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(((ICloneable)param).Clone());
                    }
                }

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result;
                }
                catch (SqlException ex)
                {
                    throw new Exception($"An error occurred executing the non-query command: {ex.Message}", ex);
                }
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            if (string.IsNullOrWhiteSpace(query)) throw new ArgumentException("Query cannot be null or whitespace.", nameof(query));

            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    connection.Open();
                    return command.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    throw new Exception($"An error occurred executing the scalar command: {ex.Message}", ex);
                }
            }
        }
    }
}

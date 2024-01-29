using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1.Klasy
{
    internal class ImportFromCSV
    {
        private string connectionString;
        public ImportFromCSV(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void ImportData(string[] tables)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    foreach (var table in tables)
                    {
                        DeleteExistingRecords(connection, table);
                        ImportDataFromCsv(connection, table);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd: " + ex.Message);
                }
            }
        }

        private void DeleteExistingRecords(SqlConnection connection, string tableName)
        {
            string query = $"DELETE FROM {tableName}";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        private void ImportDataFromCsv(SqlConnection connection, string tableName)
        {
            string csvFilePath = $"{tableName}.csv";
            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                string line = reader.ReadLine();
                if (line == null) return;

                string[] headers = line.Split(',');

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    string columns = string.Join(", ", headers);
                    string parameters = string.Join(", ", headers.Select(h => "@" + h));
                    string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";

                    SqlCommand command = new SqlCommand(query, connection);

                    for (int i = 0; i < headers.Length; i++)
                    {
                        command.Parameters.AddWithValue("@" + headers[i], values[i]);
                    }

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

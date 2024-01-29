using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1.Klasy
{
    internal class DataExportToCSV
    {
        private string connectionString;
        
        public DataExportToCSV(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void ExportData(string[] tables)
        {
            if (tables == null || tables.Length == 0) throw new ArgumentException("Tables array cannot be null or empty.", nameof(tables));

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    foreach (var table in tables)
                    {
                        ExportTableData(connection, table);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error while exporting data: {ex.Message}", ex);
                }
            }
        }
        private void ExportTableData(SqlConnection connection, string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                using (StreamWriter writer = new StreamWriter($"{tableName}.csv"))
                {
                    bool headerWritten = false;
                    while (reader.Read())
                    {
                        if (!headerWritten)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                writer.Write(reader.GetName(i) + (i < reader.FieldCount - 1 ? "," : ""));
                            }
                            writer.WriteLine();
                            headerWritten = true;
                        }

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            writer.Write(reader.GetValue(i).ToString() + (i < reader.FieldCount - 1 ? "," : ""));
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace Lab6
{
    static class DataBaseManager
    {
        static public void SaveFileToDatabase(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string fileName = Path.GetFileName(filePath);

            string connectionString = "Host=localhost;Port=5433;Username=postgres;Password=postgres;Database=cs";

            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS files (
                id SERIAL PRIMARY KEY,
                file_name TEXT NOT NULL,
                file_data BYTEA NOT NULL,
                created_at TIMESTAMP DEFAULT NOW()
            );";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(createTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new NpgsqlCommand("INSERT INTO files (file_name, file_data) VALUES (@name, @data)", conn))
                {
                    cmd.Parameters.AddWithValue("name", fileName);
                    cmd.Parameters.AddWithValue("data", fileBytes);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Файл успешно сохранён в БД!");
                }
            }
        }
    }
}

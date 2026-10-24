using System.Data;
using MySqlConnector;

namespace QuanLySinhVien;

public static class Database
{
    public const string ConnectionString = "Server=127.0.0.1;Port=3306;Database=quan_ly_sinh_vien_w6;User ID=root;Password=;Character Set=utf8mb4;SslMode=None";

    public static DataTable Select(string sql, params MySqlParameter[] parameters)
    {
        using var connection = new MySqlConnection(ConnectionString);
        using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddRange(parameters);
        using var adapter = new MySqlDataAdapter(command);
        var table = new DataTable();
        adapter.Fill(table);
        return table;
    }

    public static int Execute(string sql, params MySqlParameter[] parameters)
    {
        using var connection = new MySqlConnection(ConnectionString);
        using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddRange(parameters);
        connection.Open();
        return command.ExecuteNonQuery();
    }

    public static int Count(string sql, params MySqlParameter[] parameters)
    {
        using var connection = new MySqlConnection(ConnectionString);
        using var command = new MySqlCommand(sql, connection);
        command.Parameters.AddRange(parameters);
        connection.Open();
        return Convert.ToInt32(command.ExecuteScalar());
    }

    public static MySqlParameter Param(string name, object value) => new(name, value);
}

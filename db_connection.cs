using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

public class db_connection
{
    private string connectionString = "server=localhost; database=StudentInfoDB; uid=root; pwd=;";

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}

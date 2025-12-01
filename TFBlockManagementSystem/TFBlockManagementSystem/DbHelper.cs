using System.Data;
using Microsoft.Data.SqlClient;

public static class DbHelper
{
    private static readonly string _conStr =
        "Server=TALHA\\SQLEXPRESS; Database=MSBlockDB; Integrated Security=True; TrustServerCertificate=True;";

    // -----------------------------
    // SELECT → DataTable
    // -----------------------------
    public static DataTable ExecuteDataTable(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection con = new SqlConnection(_conStr))
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }

    // -----------------------------
    // INSERT / UPDATE / DELETE
    // -----------------------------
    public static int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection con = new SqlConnection(_conStr))
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            con.Open();
            return cmd.ExecuteNonQuery();
        }
    }

    // -----------------------------
    // SELECT SINGLE VALUE → ExecuteScalar
    // -----------------------------
    public static object? ExecuteScalar(string query, SqlParameter[]? parameters = null)
    {
        using (SqlConnection con = new SqlConnection(_conStr))
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            con.Open();
            return cmd.ExecuteScalar();
        }
    }


}

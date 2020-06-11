using System.Data;
using Npgsql;

namespace Arkanoid
{
    public static class ArkanoidDBcn
    {
        private static string host = "ec2-52-207-25-133.compute-1.amazonaws.com",
            database = "d3v2esh56jr4ke",
            UserId = "yxpdnpyfajkiup",
            password = "d3efa8677f595ed0e850497305c89c5c31e34d8f058dd30c3a2f1a57f58e97f1";

        private static string sConnection =
            $"Host={host};Port=5432;User Id={UserId};Password={password};Database={database};" +
            $"sslmode=Require;Trust Server Certificate=true";


        public static DataTable ExecuteQuery(string query)
        {

            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();

            connection.Open();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();

            return ds.Tables[0];
        }

        public static void ExecuteNonquery(string act)
        {

            NpgsqlConnection connection = new NpgsqlConnection(sConnection);

            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(act, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
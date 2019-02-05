using System;
using System.Data;
using System.Data.SqlClient;

namespace SOLID._1___SRP.SRP.Corrigido
{
    class ClientRepository
    {
        public void AddClient(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (NAME, EMAIL, CPF, REGDATE) VALUES (@name, @email, @cpf, @regDate))";
                cmd.Parameters.AddWithValue("name", client.Name);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("cpf", client.CPF);
                cmd.Parameters.AddWithValue("regDate", client.RegDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

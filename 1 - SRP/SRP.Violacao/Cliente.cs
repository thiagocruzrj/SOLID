using System;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID._1___SRP.SRP.Incorreto
{
    class Cliente
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string AddClient()
        {
            if (!Email.Contains("@"))
                return "E-mail invalid !";

            if (CPF.Length != 11)
                return "CPF invalid !";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MyConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENT (NAME, EMAIL, CPF, REGISTRATIONDATE) VALUES (@name, @email, @cpf, @registrationdate))";

                cmd.Parameters.AddWithValue("nome", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("registrationdate", RegistrationDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("business@mybusiness.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome !";
            mail.Body = "Congrats! You are registered.";
            client.Send(mail);

            return "Client registered with success !";
        }
    }
}

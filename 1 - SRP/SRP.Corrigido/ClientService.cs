using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP.Corrigido
{
    class ClientService
    {
        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data !";

            var rep = new ClientRepository();
            rep.AddClient(client);

            EmailServices.Send("business@business.com", client.Email, "Welcome !", "You are registered");
            return "Cliente registered with sucess !";
        }
    }
}

namespace SOLID._5___DIP.DIP
{
    class ClientServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailService;

        public ClientServices(
            IEmailServices emailService,
            IClienteRepository clienteRepository
            )
        {
            _emailService = emailService;
            _clienteRepository = clienteRepository;
        }

        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid data !";

            _clienteRepository.AddClient(client);

            _emailService.Send("business@business.com", client.Email, "Welcome !", "You are registered");
            return "Cliente registered with success !";
        }
    }
}

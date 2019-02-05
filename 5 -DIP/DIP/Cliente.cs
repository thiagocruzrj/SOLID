using System;

namespace SOLID._5___DIP.DIP
{
    public class Client
    {
        private readonly ICPFServices _cpfService;
        private readonly IEmailServices _emailService;

        public Client( ICPFServices cpfService, IEmailServices emailService )
        {
            _cpfService = cpfService;
            _emailService = emailService;
        }

        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime RegDate { get; set; }

        public bool IsValid()
        {
            return _emailService.IsValid(Email) && _cpfService.IsValid(CPF);
        }
    }
}

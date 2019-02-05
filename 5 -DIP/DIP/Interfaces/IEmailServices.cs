namespace SOLID._5___DIP.DIP
{
    public interface IEmailServices
    {
        bool IsValid(string email);
        void Send(string from, string to, string subject, string message);
    }
}

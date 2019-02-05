namespace SOLID._5___DIP.DIP
{
    public class CPFServices: ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}

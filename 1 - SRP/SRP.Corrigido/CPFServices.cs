namespace SOLID._1___SRP.SRP.Corrigido
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}

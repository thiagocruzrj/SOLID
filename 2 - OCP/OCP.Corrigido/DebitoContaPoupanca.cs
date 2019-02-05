using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Corrigido
{
    class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Regras de negócio
            // Debitar da conta poupança
            // Aplicar taxas
            return NumeroTransacao;
        }
    }
}

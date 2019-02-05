using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Corrigido
{
    class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Insentar taxa
            // Debitar de conta investimento

            return NumeroTransacao;
        }
    }
}

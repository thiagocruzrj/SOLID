using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Corrigido
{
    class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // regras de negócio
            // Debitar de conta corrente
            // Aplicar taxas
            return NumeroTransacao;
        }
    }
}

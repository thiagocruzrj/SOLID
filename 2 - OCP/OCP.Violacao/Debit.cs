using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Violado
{
    class Debit
    {
        public void DebitarValor(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // Debita da conta corrente
            }
            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida aniversário da conta
                // Debita Conta Poupança
            }
        }
    }
}

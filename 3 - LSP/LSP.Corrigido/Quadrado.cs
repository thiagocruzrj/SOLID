using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP.LSP.Corrigido
{
    public class Quadrado: Paralelogramo
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            if (largura != altura)
            {
                throw new ArgumentException("Lados necessitam ser iguais !");
            }
        }
    }
}

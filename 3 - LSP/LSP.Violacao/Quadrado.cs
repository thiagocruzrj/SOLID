﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP.LSP.Violado
{
    class Quadrado: Retangulo
    {
        public override double Altura { set { base.Altura = base.Largura = value;  } }
        public override double Largura { set { base.Altura = base.Largura = value; } }
    }
}

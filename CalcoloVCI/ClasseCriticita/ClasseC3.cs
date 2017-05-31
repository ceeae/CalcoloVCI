
using System;
using CalcoloVCI.ClasseCriticita;

namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC3 : AbstractClasseCriticita
    {
        public ClasseC3(): base(new VCIRange(425, true, 1250, true))
        {            
        }

        public override string ToString()
        {
            return "C3";
        }
    }
}

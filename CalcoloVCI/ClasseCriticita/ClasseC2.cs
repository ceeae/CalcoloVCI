
using System;
using CalcoloVCI.ClasseCriticita;

namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC2 : AbstractClasseCriticita
    {
        public ClasseC2() : base(new VCIRange(200, true, 425, false))
        {
        }

        public override string ToString()
        {
            return "C2";
        }
    }
}

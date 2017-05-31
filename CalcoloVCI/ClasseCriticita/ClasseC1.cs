
using System;
using System.Security.Policy;
using CalcoloVCI.ClasseCriticita;

namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC1 : AbstractClasseCriticita
    {

        public ClasseC1() : base(new VCIRange(0, false, 200, true))
        {
        }

        public override string ToString()
        {
            return "C1";
        }
    }
}

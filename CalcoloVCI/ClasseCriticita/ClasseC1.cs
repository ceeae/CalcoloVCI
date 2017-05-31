
using System;
using CalcoloVCI.ClasseCriticita;

namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC1 : AbstractClasseCriticita
    {
        private double VCIMIN = 0;
        private double VCIMAX = 200;

        public override bool match(double vci)
        {
            if (vci >= VCIMIN && vci < VCIMAX)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "C1";
        }
    }
}

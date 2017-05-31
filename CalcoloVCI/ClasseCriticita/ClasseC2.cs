
using System;
using CalcoloVCI.ClasseCriticita;

namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC2 : AbstractClasseCriticita
    {
        private double VCIMIN = 200;
        private double VCIMAX = 425;

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
            return "C2";
        }
    }
}

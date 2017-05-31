
using System;
using CalcoloVCI.ClasseCriticita;

namespace CalcoloVCI.ClasseCriticita
{
    public class ClasseC3 : AbstractClasseCriticita
    {
        private double VCIMIN = 200;
        private double VCIMAX = 1250;

        public override bool match(double vci)
        {
            if (vci >= VCIMIN && vci <= VCIMAX) // 1250 included!
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "C3";
        }
    }
}

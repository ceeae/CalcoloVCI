
using System;
using System.CodeDom;

namespace CalcoloVCI.ClasseCriticita
{

    public interface IClasseCriticita
    {
        bool match(double vci);
    }


    public class MalformedRangeException : Exception
    {
        //
    }

    public class AbstractClasseCriticita : IClasseCriticita
    {
        protected Range range;

        protected AbstractClasseCriticita(Range range)
        {
            this.range = range;
        }

        public bool match(double vci)
        {
            return range.isInRange(vci);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

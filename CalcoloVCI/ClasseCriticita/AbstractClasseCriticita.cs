
using System;
using System.CodeDom;

namespace CalcoloVCI.ClasseCriticita
{

    public interface IClasseCriticita
    {
        bool match(double vci);
    }


    public class MalformedRangeException : Exception { }

    public class VCIRange
    {
        private double min = 0;
        private double max = 0;
        private bool openmin = true;
        private bool openmax = true;

        #region constructor
        public VCIRange(double min, bool openmin, double max, bool openmax)
        {
            if (min > max)
            {
                throw new MalformedRangeException();
            }

            if (min.CompareTo(max) == 0 && openmax && openmin)
            {
                throw new MalformedRangeException();
            }

            this.min = min;
            this.max = max;
            this.openmin = openmin;
            this.openmax = openmax;
        }
        #endregion

        public bool isInRange(double value)
        {
            if (value > min && value < max)
            {
                return true;
            }
            if (value.CompareTo(min) == 0 && openmin)
            {
                return true;
            }
            else if (value.CompareTo(max) == 0 && openmax)
            {
                return true;
            }
            return false;
        }

    }

    public class AbstractClasseCriticita : IClasseCriticita
    {
        protected VCIRange range;

        protected AbstractClasseCriticita(VCIRange range)
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

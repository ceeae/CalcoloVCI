using System.ComponentModel;

namespace CalcoloVCI.ClasseCriticita
{
    public class Range
    {
        public static string MaggioreUguale =">=";
        public static string MinoreUguale = "<=";

        private double min = 0;
        private double max = 0;
        private bool openmin = true;
        private bool openmax = true;

        #region constructor
        public Range(string condmin, double min, string condmax, double max)
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
            this.openmin = string.Compare(condmin, MaggioreUguale) == 0 ? true : false;
            this.openmax = string.Compare(condmax, MinoreUguale) == 0 ? true: false;
        }
        #endregion

        public bool isInRange(double value)
        {
            if (ValoreInterno(value) || EstremoInferiore(value) || EstremoSuperiore(value))
            {
                return true;
            }
            return false;
        }

        private bool ValoreInterno(double value)
        {
            return (value > min && value < max);
        }

        private bool EstremoInferiore(double value)
        {
            return (value.CompareTo(min) == 0 && openmin);
        }

        private bool EstremoSuperiore(double value)
        {
            return (value.CompareTo(max) == 0 && openmax);
        }

    }
}
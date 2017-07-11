using System;
using System.ComponentModel;
using System.Xml.Schema;

namespace CalcoloVCI.ClasseCriticita
{
    public class Range
    {
        public static string MaggioreUguale = ">=";
        public static string MinoreUguale = "<=";

        private double min = 0;
        private double max = 0;
        private bool includemin = true;
        private bool includemax = true;

        #region constructor
        public Range(string condmin, double minvalue, string condmax, double maxvalue)
        {
            min = minvalue;
            max = maxvalue;
            includemin = string.Equals(condmin, MaggioreUguale);
            includemax = string.Equals(condmax, MinoreUguale);
            Validate();
        }
        #endregion


        public void Validate()
        {
            if (min > max)
            {
                throw new MalformedRangeException();
            }

            if (Double.Equals(min, max) && !(includemin && includemax))
            {
                throw new MalformedRangeException();
            }
            // other validation rules here ....
        }



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
            return (value.CompareTo(min) == 0 && includemin);
        }

        private bool EstremoSuperiore(double value)
        {
            return (value.CompareTo(max) == 0 && includemax);
        }

    }
}
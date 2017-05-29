using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloVCI
{
    public class SezioneImpatti
    {
        private readonly int[] V = { 1, 1, 1, 2, 2, 2, 3, 4, 5, 5 };

        private int rid;

        public SezioneImpatti()
        {
            rid = 2;
        }

        public int ValoreRID()
        {
            return rid;
        }

        public void ImpostaRID(int r, int i, int d)
        {
            rid = r + i + d;
        }

        public int CalcolaVb()
        {
            return V[rid-1];
        }
    }
}

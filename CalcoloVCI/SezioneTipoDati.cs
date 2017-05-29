using System.Linq;
using DomandeRisposte.TipoDati;

namespace CalcoloVCI
{
    public class SezioneTipoDati
    {
        private const int NPERIMETRI = 6;

        // Pesi dei perimetri
        private readonly double[] Pj =
        {
            0.5, 1.5, 3, 3, 3.8, 2
        };

        private int[] Ij;

        private double[] PjIj = new double[NPERIMETRI];

        public SezioneTipoDati()
        {
            ImpostaTutteLeDomandeConNessunoImpatto();
        }

        private void ImpostaTutteLeDomandeConNessunoImpatto()
        {
            Ij = (int[])Enumerable.Repeat(Risposta.No, NPERIMETRI).ToArray();
        }

        public void ImpostaDomandaQuestionario(int processo, int impatto)
        {
            Ij[processo] = impatto;
        }

        private void CalcolaPjxIj()
        {
            for (int j = 0; j < Pj.Length; j++)
            {
                PjIj[j] = Pj[j] * Ij[j];
            }
        }

        public double CalcolaVc()
        {
            CalcolaPjxIj();
            return PjIj.Max();
        }
    }
}

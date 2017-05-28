using System.Linq;
using Compliance;

namespace CalcoloVCI
{
    public class SezioneCompliance
    {
        private const int NPERIMETRI = 35;

        // Pesi dei perimetri
        private readonly double[] Pj =
        {
            4, 3.9, 3, 3, 2, 2.25, 2.5, 2.3, 0.5, 1.5, 1.7, 1.7, 3.25, 0, 3, 3, 3, 1.5, 0,
            1.7, 1.7, 1.7, 1.7, 1.7, 1.7, 0, 1.5, 1.7, 3, 4, 1.5, 1.7, 1.7, 1.7, 1.7
        
        };

        private int[] Ij;

        private double[] PjIj = new double[NPERIMETRI];

        public int TrattaDatiPCIDSS { get; set; }

        public int TrattaDatiCarteDiPagamento { get; set; }

        public SezioneCompliance()
        {
            TrattaDatiPCIDSS = (int)Risposta.No;
            TrattaDatiCarteDiPagamento = (int)Risposta.No;
            ImpostaQuestionariConNessunoImpatto();
        }

        private void ImpostaQuestionariConNessunoImpatto()
        {
            Ij = (int[])Enumerable.Repeat((int)Risposta.No, NPERIMETRI).ToArray();
        }

        public bool CasoSpeciale()
        {
            return TrattaDatiPCIDSS == (int)Risposta.Si ||
                   TrattaDatiCarteDiPagamento == (int)Risposta.Si;
        }
        public void ImpostaQuestionario(int processo, int impatto)
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

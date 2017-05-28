using System;
using System.Linq;

namespace CalcoloVCI
{
    public class SezioneProcessi
    {
        private const int NPROCESSI = 15;

        // Pesi dei processi
        private readonly int[] Pj = { 5, 5, 4, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1 };

        private int[] Ij;

        private int[] PjIj = new int[NPROCESSI];

        private readonly int[] Delta = {0, 1, 1, 1, 1, 1, 2, 0, 1, 1, 2, 0, 3, 0, 0, 1, 4, 0, 0, 0, 5, 0, 0, 0, 0, 0};

        public SezioneProcessi()
        {
            ImpostaQuestionariConNessunoImpatto();
        }

        private void ImpostaQuestionariConNessunoImpatto()
        {
            Ij = (int[])Enumerable.Repeat((int)Processi.Risposta.Nessuno, NPROCESSI).ToArray();
        }

        public double CalcolaPp()
        {
            CalcolaPjxIj();
            int M = PjIj.Max();
            int IMax = PjIj.ToList().IndexOf(M) + 1;
            int PjMax = Pj[IMax];
            int S = PjIj.Sum() - M;
            int T = Pj.Sum() - IMax;
            int DeltaM = Delta[M];
            double X = (double) S / (5*T);
            double Gamma = Math.Pow(X, 1.0 /6);
            return Math.Round(M + DeltaM*Gamma, 2);
        }

        public void ImpostaQuestionario(int processo, int impatto)
        {
            Ij[processo] = impatto;
        }

        private void CalcolaPjxIj()
        {
            for (int j = 0; j < Pj.Length; j++)
            {
                PjIj[j] = Pj[j]*Ij[j];
            }
        }
    }
}

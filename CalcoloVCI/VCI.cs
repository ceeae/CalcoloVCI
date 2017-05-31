using System;
using System.Collections.Generic;
using System.Linq;
using CalcoloVCI.ClasseCriticita;

namespace CalcoloVCI
{
    public class VCI
    {
        private const double VCIMIN = 312.0;
        private const double PPICTMERCATO = 12.0;

        private SezioneAnagrafica sezioneAnagrafica;
        private SezioneCompliance sezioneCompliance;
        private SezioneProcessi sezioneProcessi;
        private SezioneTipoDati sezioneTipoDati;
        private SezioneImpatti sezioneImpatti;

        private ClasseCriticitaSelector selector = new ClasseCriticitaSelector();

        #region constructor
        public VCI(
                    SezioneAnagrafica sa, 
                    SezioneCompliance sc, 
                    SezioneProcessi sp, 
                    SezioneTipoDati st, 
                    SezioneImpatti si
            )
        {
            sezioneAnagrafica = sa;
            sezioneCompliance = sc;
            sezioneProcessi = sp;
            sezioneTipoDati = st;
            sezioneImpatti = si;

        }
        #endregion

        public double CalcolaVCI()
        {
            double pp = CalcolaPp();
            double vc = CalcolaVc();
            double vb = CalcolaVb();

            // 2 digit precision e.g. 2.24
            double vci = Math.Round(5*pp*vb + Math.Pow(5, vc), 2);

            if (CasoSpecialeConVCISottoMinimo(vci))
            {
                return VCIMIN;
            }
            return vci;
        }

        public string ClasseCriticita(double vci)
        {
            AbstractClasseCriticita classe = selector.ClasseCriticita(vci);
            return classe?.ToString();
        }

        private bool CasoSpecialeConVCISottoMinimo(double vci)
        {
            return vci < VCIMIN && CasoSpeciale();
        }

        private bool CasoSpeciale()
        {
            return sezioneAnagrafica.CasoSpeciale() || sezioneCompliance.CasoSpeciale();
        }

        private double CalcolaPp()
        {
            if (sezioneAnagrafica.AmbitoICTMercato())
            {
                return PPICTMERCATO;
            }
            return sezioneProcessi.CalcolaPp();
        }

        private double CalcolaVb()
        {
            return sezioneImpatti.CalcolaVb();
        }

        private double CalcolaVc()
        {
            double[] Vc = {0.5, sezioneCompliance.CalcolaVc(), sezioneTipoDati.CalcolaVc()};
            return Vc.Max();
        }

    }
}

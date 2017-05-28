

using System;
using System.Security.Permissions;

namespace CalcoloVCI
{
    public class VCI
    {
        private const double MINVCI = 312.0;
        private const double PPICTMERCATO = 12.0;

        private SezioneAnagrafica sezioneAnagrafica;
        private SezioneCompliance sezioneCompliance;
        private SezioneProcessi sezioneProcessi;
        private SezioneTipoDati sezioneTipoDati;
        private SezioneImpatti sezioneImpatti;

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

        public double CalcolaVCI()
        {
            // 2 digit precision e.g. 2.24
            return Math.Round(5 * CalcolaPp()*CalcolaVb() + Math.Pow(5, CalcolaVc()), 2);
        }

        private double CalcolaPp()
        {
            //if (sezioneAnagrafica.AmbitoICTMercato())
            //{
            //    return PPICTMERCATO;
            //}
            //return sezioneProcessi.CalcolaPp();
            return 0;
        }

        private double CalcolaVb()
        {
            return 0;
        }

        private double CalcolaVc()
        {
            return 0.5;
        }

    }
}

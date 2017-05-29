﻿

using System;
using System.Linq;
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
            double pp = CalcolaPp();
            double vc = CalcolaVc();
            double vb = CalcolaVb();
            // 2 digit precision e.g. 2.24
            return Math.Round(5 * pp* vb + Math.Pow(5, vc), 2);
        }

        private double CalcolaPp()
        {
            if (sezioneAnagrafica.ICTMercato())
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

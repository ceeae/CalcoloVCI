
using System;
using CalcoloVCI;
using UnitTests;
using DomandeRisposte.Processi;
using DomandeRisposte.Anagrafica;
using DomandeRisposte.Compliance;
using DomandeRisposte.TipoDati;
using DomandeRisposte.Impatti;

namespace UnitTests
{

    public interface IVCIBuilder
    {
        VCI Build();
    }

    public class NotSupportedVCIScenarioException : Exception
    {
    }

    public static class VCIBuilder
    {

        public static VCI CreateFromScenario(int scenarioType)
        {
            IVCIBuilder builder = null;

            if (scenarioType == Scenarios.NessunImpatto)
            {
                builder = new VCIScenarioNessunImpatto();
            }
            else if (scenarioType == Scenarios.MassimoImpatto)
            {
                builder = new VCIScenarioMassimoImpatto();
            }
            else if (scenarioType == Scenarios.ICTMercatoImpattoMedio)
            {
                builder = new VCIScenarioICTMercatoImpattoMedio();
            }

            if (builder != null)
            {
                return builder.Build();
            }
            else
            {
                throw new NotSupportedVCIScenarioException();
            }
        }
    }
}



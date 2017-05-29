
using System;
using CalcoloVCI;
using UnitTests;
using DomandeRisposte.Processi;
using DomandeRisposte.Anagrafica;
using DomandeRisposte.Compliance;
using DomandeRisposte.TipoDati;
using DomandeRisposte.Impatti;
using UnitTests.VCIScenarios;

namespace UnitTests
{

    public static class VCIBuilder
    {

        public static VCI CreateFromScenario(int scenarioType)
        {
            IVCIBuilder builder = null;

            switch (scenarioType)
            {
                case Scenarios.NessunImpatto:
                    builder = new VCIScenarioNessunImpatto();
                    break;

                case Scenarios.MassimoImpatto:
                    builder = new VCIScenarioMassimoImpatto();
                    break;

                case Scenarios.ICTMercatoImpattoMedio:
                    builder = new VCIScenarioICTMercatoImpattoMedio();
                    break;

                case Scenarios.ICTMercatoImpattoMedioCasoCritico:
                    builder = new VCIScenarioIctMercatoImpattoMedioCasoCritico();
                    break;

                default:
                    throw new NotSupportedException();
            }

            return builder.Build();
        }
    }
}



using System;
using CalcoloVCI;

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
                    builder = new VCIScenarioIctMercatoImpattoMedio();
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



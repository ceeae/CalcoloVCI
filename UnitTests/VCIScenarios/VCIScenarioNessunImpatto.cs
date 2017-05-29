using CalcoloVCI;

namespace UnitTests
{
    public class VCIScenarioNessunImpatto : VCIAbstractScenario
    {
        protected override void CreateScenario()
        {
            vci = new VCI(sa, sc, sp, st, si);
        }
    }
}
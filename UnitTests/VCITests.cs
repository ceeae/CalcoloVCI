using System.Dynamic;
using Xunit;
using FluentAssertions;

using CalcoloVCI;

namespace UnitTests
{
    //public enum Scenario : int
    //{
    //    NessunImpatto = 1    
    //}

    //public class Scenarios
    //{
    //    public VCI vci;

    //    public void ScenarioVCI(VCI scenarioVci)
    //    {
    //        vci = scenarioVci;
    //    }

    //    public static VCI CreateVCI(int scenarioType)
    //    {
    //        VCI vci = new VCI();
    //        return new Scenarios().vci;
    //    }
    //}

    public class VCITests
    {

        [Fact]
        public void CalcolaVCI_NoImpatti_Risultato()
        {
            SezioneAnagrafica sa = new SezioneAnagrafica();
            SezioneCompliance sc  = new SezioneCompliance();
            SezioneProcessi sp = new SezioneProcessi();
            SezioneTipoDati st = new SezioneTipoDati();
            SezioneImpatti si = new SezioneImpatti();
            VCI vci = new VCI(sa,sc,sp,st,si);

            double result = vci.CalcolaVCI();

            result.Should().Be(2.24);
        }

        //[Theory]
        //[InlineData(Scenario.NessunImpatto, 2.24)]
        //public void CalcolaVCI_VariScenari(int scenario, double vcivalue)
        //{
        //    VCI newvci = Scenarios.CreateVCI(scenario);

        //    double result = newvci.CalcolaVCI();

        //    result.Should().Be(vcivalue);

        //}
    }
}

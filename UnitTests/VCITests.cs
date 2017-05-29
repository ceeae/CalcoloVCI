using System.Dynamic;
using Xunit;
using FluentAssertions;

using CalcoloVCI;

namespace UnitTests
{

    public class VCITests
    {

        [Theory]
        [InlineData(Scenarios.NessunImpatto, 2.24)]
        [InlineData(Scenarios.MassimoImpatto, 1250.00)]
        [InlineData(Scenarios.ICTMercatoImpattoMedio, 306.92)]
        [InlineData(Scenarios.ICTMercatoImpattoMedioCasoCritico, 312.00)]

        public void CalcolaVCI_VariScenari(int scenario, double vcivalue)
        {
            VCI vci = VCIBuilder.CreateFromScenario(scenario);

            double result = vci.CalcolaVCI();

            result.Should().Be(vcivalue);
        }
    }
}

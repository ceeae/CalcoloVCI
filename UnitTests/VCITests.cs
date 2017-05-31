using System.Dynamic;
using Xunit;
using FluentAssertions;

using CalcoloVCI;

namespace UnitTests
{

    public class VCITests
    {

        [Theory]
        [InlineData(Scenarios.NessunImpatto, 2.24, "C1")]
        [InlineData(Scenarios.ICTMercatoImpattoMedio, 306.92, "C2")]
        [InlineData(Scenarios.ICTMercatoImpattoMedioCasoCritico, 312.00, "C2")]
        [InlineData(Scenarios.MassimoImpatto, 1250.00, "C3")]

        public void CalcolaVCI_VariScenari(int scenario, double vcivalue, string classevalue)
        {
            VCI vci = VCIBuilder.CreateFromScenario(scenario);

            double result = vci.CalcolaVCI();
            string classe = vci.ClasseCriticita(result);

            result.Should().Be(vcivalue);
            classe.Should().Be(classevalue);
        }

    }
}

using Xunit;
using FluentAssertions;

using CalcoloVCI;
using DomandeRisposte.Processi;

namespace UnitTests
{
    public class SezioneProcessiTests
    {
        private SezioneProcessi processi;


        public SezioneProcessiTests()
        {
            processi = new SezioneProcessi();
        }

        [Fact]
        public void CalcolaPp_DefaultNessunImpatto_RitornaZero()
        {
            double Pp = processi.CalcolaPp();

            Pp.Should().Be(0);
        }

        [Theory]
        [InlineData(
            Domanda.CustomerRelationshipManagement, Risposta.Determinante,
            Domanda.SupplierAndPartnerRelationshipManagement, Risposta.Determinante,
            25)]
        [InlineData(
            Domanda.ServiceDevelopmentAndManagement, Risposta.Influente,
            Domanda.StrategicEnterprisePlanning, Risposta.PocoInfluente,
            13.56)]
        [InlineData(
            Domanda.SupplierAndPartnerRelationshipManagement, Risposta.Determinante,
            Domanda.ResourceManagementAndOperations, Risposta.Determinante,
            23.39)]
        public void CalcolaPp_DoppioPerimetro(int d1, int r1, int d2, int r2, double pp)
        {
            processi.ImpostaQuestionario(d1, r1);
            processi.ImpostaQuestionario(d2, r2);

            double result = processi.CalcolaPp();

            result.Should().Be(pp);
        }

    }
}

using Xunit;
using FluentAssertions;

using CalcoloVCI;
using DomandeRisposte.Compliance;

namespace UnitTests
{
    public class SezioneComplianceTests
    {
        private readonly SezioneCompliance sezioneCompliance;

        public SezioneComplianceTests()
        {
            sezioneCompliance = new SezioneCompliance();
        }

        [Fact]
        public void CasoSpeciale_TrattaDatiPCIDSS_RitornaVero()
        {

            sezioneCompliance.TrattaDatiPCIDSS = Risposta.Si;

            bool isASpecialCase = sezioneCompliance.CasoSpeciale();

            isASpecialCase.Should().BeTrue();
        }


        [Fact]
        public void CasoSpeciale_ValoriDefault_RitornaFalso()
        {
            bool isASpecialCase = sezioneCompliance.CasoSpeciale();

            isASpecialCase.Should().BeFalse();
        }

        [Fact]
        public void CasoSpeciale_TrattaDatiCarteDiPagamento_RitornaVero()
        {
            sezioneCompliance.TrattaDatiCarteDiPagamento = Risposta.Si;

            bool isASpecialCase = sezioneCompliance.CasoSpeciale();

            isASpecialCase.Should().BeTrue();
        }


        [Theory]
        [InlineData(Perimetro.Magistratura, Risposta.Si, 4)]
        [InlineData(Perimetro.DatiIntercettazzione, Risposta.Si, 3.9)]
        [InlineData(Perimetro.PortaliWeb, Risposta.Si, 1.7)]
        [InlineData(Perimetro.ICTMercatoPortaliWeb, Risposta.Si, 1.7)]
        public void CalcolaVc_SuUnicoPerimetro_RitornaVc(int perimetro, int risposta, double vc)
        {
            sezioneCompliance.ImpostaDomandaQuestionario(perimetro, risposta);

            double result = sezioneCompliance.CalcolaVc();

            result.Should().Be(vc);
        }

        [Fact]
        public void CalcolaVc_SuPerimetroMagistraturaEPCIDSS_Ritorna4()
        {
            sezioneCompliance.ImpostaDomandaQuestionario(
                Perimetro.Magistratura, 
                Risposta.Si
            );

            sezioneCompliance.ImpostaDomandaQuestionario(
                Perimetro.PCIDSS,
                Risposta.Si
            );

            double result = sezioneCompliance.CalcolaVc();

            result.Should().Be(4.0);

        }

    }
}

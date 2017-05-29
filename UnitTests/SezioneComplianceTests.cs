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

            sezioneCompliance.ImpostaDomandaQuestionario(
                Perimetro.PCIDSS,
                Risposta.Si
                );

            bool isASpecialCase = sezioneCompliance.CasoSpeciale();

            isASpecialCase.Should().BeTrue();
        }


        [Fact]
        public void CasoSpeciale_ValoriDefault_RitornaFalso()
        {
            bool isASpecialCase = sezioneCompliance.CasoSpeciale();

            isASpecialCase.Should().BeFalse();
        }

        [Theory]
        [InlineData(Perimetro.PCIDSS)]
        [InlineData(Perimetro.ICTMercatoCartePagamento)]
        [InlineData(Perimetro.SOX)]
        public void CasoSpeciale_RitornaVero(int perimetro)
        {
            sezioneCompliance.ImpostaDomandaQuestionario(
                perimetro,
                Risposta.Si
                );
 
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

        [Theory]
        [InlineData(
            Perimetro.Magistratura, Risposta.Si,
            Perimetro.PCIDSS, Risposta.Si, 
            4.0
            )]
        public void CalcolaVc_SuPerimetroMagistraturaEPCIDSS_Ritorna4(int d1, int r1, int d2, int r2, int vc)
        {
            sezioneCompliance.ImpostaDomandaQuestionario(d1, r1);
            sezioneCompliance.ImpostaDomandaQuestionario(d2, r2);

            double result = sezioneCompliance.CalcolaVc();

            result.Should().Be(vc);

        }

    }
}

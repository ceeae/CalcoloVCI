using Xunit;
using FluentAssertions;

using CalcoloVCI;
using DomandeRisposte.TipoDati;

namespace UnitTests
{

    public class SezioneTipoDatiTests
    {
        private readonly SezioneTipoDati sezioneTipoDati;

        public SezioneTipoDatiTests()
        {
            sezioneTipoDati = new SezioneTipoDati();
        }

        [Theory]
        [InlineData(Perimetro.NO196, Risposta.Si, 0.5)]
        [InlineData(Perimetro.DatiSensibili, Risposta.Si, 3.0)]
        [InlineData(Perimetro.DatiTraffico, Risposta.Si, 3.8)]
        public void CalcolaVc_SuUnicoPerimetro_RitornaVc(int perimetro, int risposta, double vc)
        {
            sezioneTipoDati.ImpostaQuestionario(perimetro, risposta);

            double result = sezioneTipoDati.CalcolaVc();

            result.Should().Be(vc);
        }

        [Theory]
        [InlineData(
            Perimetro.DatiLocalizzazione, Risposta.Si,
            Perimetro.NO196, Risposta.Si,
            2.0)]
        [InlineData(
            Perimetro.DatiPersonali, Risposta.Si,
            Perimetro.DatiSensibili, Risposta.Si,
            3.0)]
        public void CalcolaVc_SuDoppioPerimetro(int d1, int r1, int d2, int r2, double vc)
        {
            sezioneTipoDati.ImpostaQuestionario(d1, r1);
            sezioneTipoDati.ImpostaQuestionario(d2, r2);

            double result = sezioneTipoDati.CalcolaVc();

            result.Should().Be(vc);
        }
    }
}

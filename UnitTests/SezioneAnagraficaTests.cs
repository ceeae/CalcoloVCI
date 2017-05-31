using Xunit;
using FluentAssertions;
using CalcoloVCI;

using DomandeRisposte.Anagrafica;

namespace UnitTests
{
    public class SezioneAnagraficaTests
    {
        private readonly SezioneAnagrafica sezioneAnagrafica;

        public SezioneAnagraficaTests()
        {
             sezioneAnagrafica = new SezioneAnagrafica();            
        }

        [Fact]
        public void CasoSpeciale_ApplicazioneConAlmeno5AppC3_RitornaVero()
        {

            sezioneAnagrafica.DomandaApplicazioneConAlmeno5AppC3(Risposta.Si);

            bool result = sezioneAnagrafica.CasoSpeciale();

            result.Should().BeTrue();
        }


        [Fact]
        public void CasoSpeciale_ValoriDefault_RitornaFalso()
        {
            bool result = sezioneAnagrafica.CasoSpeciale();

            result.Should().BeFalse();
        }

        [Fact]
        public void CasoSpeciale_AppartenenzaRealtaCritiche_RitornaVero()
        {
            sezioneAnagrafica.DomandaAppartenenzaRealtaCritiche(Risposta.Si);

            bool result = sezioneAnagrafica.CasoSpeciale();

            result.Should().BeTrue();
        }

        [Fact]
        public void ICTMercatp_AmbitoTecnologicoICTMercato_RitornaVero()
        {
            sezioneAnagrafica.ImpostaAmbitoTecnologico(Ambito.BusinessICTMercato);

            bool result = sezioneAnagrafica.AmbitoICTMercato();

            result.Should().BeTrue();
        }

    }
}

using Xunit;
using FluentAssertions;
using CalcoloVCI;

using Anagrafica;

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

            sezioneAnagrafica.ApplicazioneConAlmeno5AppC3((int) Risposta.Si);

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
            sezioneAnagrafica.AppartenenzaRealtaCritiche((int) Risposta.Si);

            bool result = sezioneAnagrafica.CasoSpeciale();

            result.Should().BeTrue();
        }

        [Fact]
        public void ICTMercatp_AmbitoTecnologicoICTMercato_RitornaVero()
        {
            sezioneAnagrafica.AmbitoTecnologico((int)Ambito.BusinessICTMercato);

            bool result = sezioneAnagrafica.ICTMercato();

            result.Should().BeTrue();
        }


    }
}

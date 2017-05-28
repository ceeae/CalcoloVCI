using Xunit;
using FluentAssertions;
using CalcoloVCI;

using Anagrafica;

namespace UnitTests
{
    public class SezioneAnagraficaTests
    {
        // UnitOfWorkName_Scenario_ExpectedBehavior
        // IsValidFilename_BadExtension_ReturnFalse
        private readonly SezioneAnagrafica sezioneAnagrafica;

        public SezioneAnagraficaTests()
        {
             sezioneAnagrafica = new SezioneAnagrafica();            
        }

        [Fact]
        public void CasoSpeciale_ApplicazioneConAlmeno5AppC3_RitornaVero()
        {

            sezioneAnagrafica.ApplicazioneConAlmeno5AppC3 = (int) Risposta.Si;

            bool isASpecialCase = sezioneAnagrafica.CasoSpeciale();

            isASpecialCase.Should().BeTrue();
        }


        [Fact]
        public void CasoSpeciale_ValoriDefault_RitornaFalso()
        {
            bool isASpecialCase = sezioneAnagrafica.CasoSpeciale();

            isASpecialCase.Should().BeFalse();
        }

        [Fact]
        public void CasoSpeciale_AppartenenzaRealtaCritiche_RitornaVero()
        {
            sezioneAnagrafica.AppartenenzaRealtaCritiche = (int) Risposta.Si;

            bool isASpecialCase = sezioneAnagrafica.CasoSpeciale();

            isASpecialCase.Should().BeTrue();
        }



    }
}

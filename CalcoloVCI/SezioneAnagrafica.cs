using DomandeRisposte.Anagrafica;

namespace CalcoloVCI
{

    public class SezioneAnagrafica
    {
        // Domande: ImpostaAmbitoTecnologico, Applicazione5C3, DomandaAppartenenzaRealtaCritiche
        private int ambitoTecnologico = Ambito.IT;

        private int applicazioneConAlmeno5AppC3 = Risposta.NonDisponibile;

        private int appartenenzaRealtaCritiche = Risposta.NonDisponibile;

        public void ImpostaAmbitoTecnologico(int ambito)
        {
            ambitoTecnologico = ambito;
        }

        public void DomandaApplicazioneConAlmeno5AppC3(int risposta)
        {
            applicazioneConAlmeno5AppC3 = risposta;
        }

        public void DomandaAppartenenzaRealtaCritiche(int risposta)
        {
            applicazioneConAlmeno5AppC3 = risposta;
        }

        public bool CasoSpeciale()
        {
            return applicazioneConAlmeno5AppC3 == Risposta.Si || 
                   appartenenzaRealtaCritiche == Risposta.Si;
        }

        public bool AmbitoICTMercato()
        {
            return ambitoTecnologico == Ambito.BusinessICTMercato;
        }
    }
}

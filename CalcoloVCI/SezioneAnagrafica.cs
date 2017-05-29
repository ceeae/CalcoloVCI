using DomandeRisposte.Anagrafica;

namespace CalcoloVCI
{

    public class SezioneAnagrafica
    {
        // Domande: AmbitoTecnologico, Applicazione5C3, AppartenenzaRealtaCritiche
        private int ambitoTecnologico = Ambito.IT;
        private int applicazioneConAlmeno5AppC3 = Risposta.NonDisponibile;
        private int appartenenzaRealtaCritiche = Risposta.NonDisponibile;

        public SezioneAnagrafica()
        {
        }

        public void AmbitoTecnologico(int ambito)
        {
            ambitoTecnologico = ambito;
        }

        public void ApplicazioneConAlmeno5AppC3(int risposta)
        {
            applicazioneConAlmeno5AppC3 = risposta;
        }

        public void AppartenenzaRealtaCritiche(int risposta)
        {
            applicazioneConAlmeno5AppC3 = risposta;
        }

        public bool CasoSpeciale()
        {
            return applicazioneConAlmeno5AppC3 == Risposta.Si || 
                   appartenenzaRealtaCritiche == Risposta.Si;
        }

        public bool ICTMercato()
        {
            return ambitoTecnologico == Ambito.BusinessICTMercato;
        }
    }
}

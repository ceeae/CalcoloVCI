using Anagrafica;

namespace CalcoloVCI
{

    public class SezioneAnagrafica
    {
        // Domande: AmbitoTecnologico, Applicazione5C3, AppartenenzaRealtaCritiche
        private int ambitoTecnologico = (int) Ambito.IT;
        private int applicazioneConAlmeno5AppC3 = (int) Risposta.NonDisponibile;
        private int appartenenzaRealtaCritiche = (int)Risposta.NonDisponibile;

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
            return applicazioneConAlmeno5AppC3 == (int) Risposta.Si || 
                   appartenenzaRealtaCritiche == (int) Risposta.Si;
        }

        public bool ICTMercato()
        {
            return ambitoTecnologico == (int) Ambito.BusinessICTMercato;
        }
    }
}

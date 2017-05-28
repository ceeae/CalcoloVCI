using Anagrafica;

namespace CalcoloVCI
{

    public class SezioneAnagrafica
    {

        public int ApplicazioneConAlmeno5AppC3 { get; set; }
        public int AppartenenzaRealtaCritiche { get; set; }

        public SezioneAnagrafica()
        {
            ApplicazioneConAlmeno5AppC3 = (int) Risposta.NonDisponibile;
            AppartenenzaRealtaCritiche = (int) Risposta.NonDisponibile;
        }

        public bool CasoSpeciale()
        {
            return ApplicazioneConAlmeno5AppC3 == (int) Risposta.Si || 
                   AppartenenzaRealtaCritiche == (int) Risposta.Si;
        }
    }
}
